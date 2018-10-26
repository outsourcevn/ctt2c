using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using AppPortal.ApiHost.ViewModels;
using AppPortal.Core.Interfaces;
using AppPortal.Core.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Configuration;

namespace AppPortal.ApiHost.Controllers.Base
{
    [Route("api/[controller]")]
    [Authorize]
    public abstract class ApiBaseController<T> : Controller
    {
        protected readonly IConfiguration _configuration;
        protected readonly IAppLogger<T> _logger;
        public ApiBaseController(
            IConfiguration configuration,
            IAppLogger<T> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        private ApiSettings _apiSettings;
        protected ApiSettings apiSettings
        {
            get
            {
                if (_apiSettings == null) this._apiSettings = _configuration.GetSection("AppSettings").Get<ApiSettings>();
                return this._apiSettings;
            }
        }

        protected IActionResult RedirectToLocal(string returnUrl = null)
        {
            if (returnUrl != null && Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return Redirect(_apiSettings.CorsSites.AdminSite);
        }

        #region ' Response Intercepter '
        protected void TryAction(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        protected IActionResult ResponseInterceptor<TModel>(TModel model)
        {
            var response = new SingleModelResponse<TModel>();
            try
            {
                response.Model = model;
            }
            catch (Exception ex)
            {
                response.DidError = true;
                response.Errors.Add(ex.ToString());
            }
            return ToHttpResponse(response);
        }

        protected IActionResult ResponseInterceptor<TModel>(IEnumerable<TModel> models, int rows, Paging paging)
        {
            var response = new ListModelResponse<TModel>();
            try
            {
                response.Datas = models;
                response.Counts = rows;
                response.Page = paging;
            }
            catch (Exception ex)
            {
                response.DidError = true;
                response.Errors.Add(ex.ToString());
            }
            return ToHttpResponse(response);
        }

        protected IEnumerable<IdentityError> AddErrors(ModelStateDictionary modelState)
        {
            var errors = new List<IdentityError>();
            foreach (var error in ModelState)
            {
                errors.Add(new IdentityError()
                {
                    Code = error.Key,
                    Description = error.Value.Errors.FirstOrDefault()?.ErrorMessage
                });
            }
            return errors;
        }

        protected IEnumerable<IdentityError> AddErrors(IdentityResult result)
        {
            var errors = new List<IdentityError>();
            foreach (var error in result.Errors)
            {
                errors.Add(new IdentityError
                {
                    Code = error.Code,
                    Description = error.Description
                });
            }
            return errors;
        }

        protected IEnumerable<IdentityError> AddErrors(IdentityError error)
        {
            return new List<IdentityError>() { error };
        }

        protected IActionResult ToHttpBadRequest<TModel>(IEnumerable<TModel> errors)
        {
            return BadRequest(errors);
        }

        protected IActionResult ToHttpBadRequest<TModel>(params TModel[] errors)
        {
            return BadRequest(errors);
        }

        protected IActionResult ToBadUserNotExist()
        {
            return ToHttpBadRequest(AddErrors(new IdentityError
            {
                Code = "UserNotExist",
                Description = "Tài khoản không tồn tại.",
            }));
        }

        protected IActionResult ToBadUserNotAcess()
        {
            return ToHttpBadRequest(AddErrors(new IdentityError
            {
                Code = "UserNotAccess",
                Description = "Bạn không có quyền truy cập.",
            }));
        }

        #endregion

        #region ' Private '
        private IActionResult ToHttpResponse<TModel>(IListModelResponse<TModel> response)
        {
            var status = HttpStatusCode.OK;

            if (response.DidError)
            {
                status = HttpStatusCode.InternalServerError;
            }
            else if (response.Datas == null)
            {
                status = HttpStatusCode.NoContent;
            }

            return new ObjectResult(response)
            {
                StatusCode = (Int32)status
            };
        }

        private IActionResult ToHttpResponse<TModel>(ISingleModelResponse<TModel> response)
        {
            var status = HttpStatusCode.OK;

            if (response.DidError)
            {
                status = HttpStatusCode.InternalServerError;
            }
            else if (response.Model == null)
            {
                status = HttpStatusCode.NotFound;
            }
            return new ObjectResult(response)
            {
                StatusCode = (Int32)status
            };
        }
        #endregion
    }
}
