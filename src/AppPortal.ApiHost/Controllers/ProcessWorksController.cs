using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AppPortal.AdminSite.Services.Interfaces;
using AppPortal.AdminSite.Services.Models.News;
using AppPortal.ApiHost.Controllers.Base;
using AppPortal.ApiHost.ViewModels;
using AppPortal.ApiHost.ViewModels.News;
using AppPortal.Core;
using AppPortal.Core.Entities;
using AppPortal.Core.Interfaces;
using AppPortal.Infrastructure.Identity;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace AppPortal.ApiHost.Controllers
{
    [Produces("application/json")]
    public class ProcessWorksController : ApiBaseController<ProcessWorksController>
    {
        private readonly IEmailSender _emailSender;
        private readonly INewsService _newsService;
        private readonly INewsLog _newLog;
        private readonly UserManager<ApplicationUser> _userManager;
        public ProcessWorksController(
            UserManager<ApplicationUser> userManager,
            IEmailSender emailSender,
            INewsService newsService,
            INewsLog newLog,
            IConfiguration configuration, 
            IAppLogger<ProcessWorksController> logger) : base(configuration, logger)
        {
            _emailSender = emailSender;
            _newsService = newsService;
            _newLog = newLog;
            _userManager = userManager;
        }

        // list topic user
        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpGet("getTopics")]
        public IActionResult ListTopicsAsync(int? skip = 0, int? page = 1, int? take = 15, string keyword = "", int? categoryId = -1, int? status = -1, int? type = -1)
        {
            var query = _newsService.GetLstTopicPaging(out int rows, skip, take, keyword, categoryId, status, type);
            var vm = query.Select(n => Mapper.Map<ListItemNewsModel, ListItemNewsViewModel>(n));
            return ResponseInterceptor(vm, rows, new Paging()
            {
                PageNumber = page.Value,
                PageSize = take.Value,
                Take = take.Value,
                Skip = skip.Value,
                Query = keyword,
            });
        }

        // create or update
        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpPost("CreateOrUpdate")]
        public IActionResult CreateOrUpdate(int? Id, [FromBody] NewsViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return ToHttpBadRequest(AddErrors(ModelState));
            }
            string message = "Ý kiến góp ý đã được gửi tới hệ thống.";
            try
            {
                var entityModel = Mapper.Map<NewsViewModel, NewsModel>(model);
                if (Id.HasValue && Id > 0)
                {
                    entityModel.Id = Id.Value;
                    message = "Góp ý đã được cập nhật.";
                }
                entityModel.IsType = (int?)IsType.topic;
                _newsService.AddOrUpdate(entityModel);
            }
            catch (System.Exception ex)
            {
                _logger.LogInformation(ex.ToString());
                return ToHttpBadRequest(AddErrors(new IdentityError
                {
                    Code = "Exceptions",
                    Description = ex.ToString(),
                }));
            }
            return ResponseInterceptor(message);
        }

        // delete
        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpPost("Delete")]
        public IActionResult Delete(int? Id)
        {
            if (!Id.HasValue)
            {
                return ToHttpBadRequest("The Id is request");
            }
            var entity = _newsService.GetNewsById(Id.Value);
            if (entity == null)
            {
                return ToHttpBadRequest("Tin tức không tồn tại.");
            }
            string message = "";
            try
            {
                _newsService.Delete(Id.Value);
                message = "Tin tức đã được xóa.";
            }
            catch (System.Exception ex)
            {
                _logger.LogInformation(ex.ToString());
                return ToHttpBadRequest(AddErrors(new IdentityError
                {
                    Code = "Exceptions",
                    Description = ex.ToString(),
                }));
            }
            return ResponseInterceptor(message);
        }

        // Seturl seename
        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpPost("set-url-new")]
        public IActionResult SetUrl([FromBody] string title)
        {
            if (string.IsNullOrEmpty(title)) { return ResponseInterceptor(new { response = "" }); }
            return ResponseInterceptor(new { response = CommonHelper.UltilityHelper.unicodeToNoMark(title) });
        }

        // delete all
        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpPost("delete-all-new")]
        public IActionResult DeleteAllNew([FromBody] string[] ids)
        {
            if (ids == null || ids.Count() == 0)
            {
                return ToHttpBadRequest("The ids is required.");
            }
            string message = "";
            try
            {
                var count = _newsService.DeleteAll(ids);
                message = $"Đã xóa {count} tin tức.";
            }
            catch (System.Exception ex)
            {
                _logger.LogWarning(ex.ToString());
                return ToHttpBadRequest(AddErrors(new IdentityError
                {
                    Code = "Exceptions",
                    Description = ex.ToString(),
                }));
            }
            return ResponseInterceptor(message);
        }

        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpPost("save-process-new")]
        // save all to process
        public IActionResult ProcessNews([FromBody] string[] ids)
        {
            if (ids == null || ids.Count() == 0)
            {
                return ToHttpBadRequest("The ids is required.");
            }
            string message = "";
            try
            {
                var count = _newsService.Process(ids);
                message = $"Đang xử lý {count} tin tức.";
            }
            catch (System.Exception ex)
            {
                _logger.LogWarning(ex.ToString());
                return ToHttpBadRequest(AddErrors(new IdentityError
                {
                    Code = "Exceptions",
                    Description = ex.ToString(),
                }));
            }
            return ResponseInterceptor(message);
        }

        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpPost("save-publish-new")]
        // save all to Publishs
        public IActionResult PublishNews([FromBody] string[] ids)
        {
            if (ids == null || ids.Count() == 0)
            {
                return ToHttpBadRequest("The ids is required.");
            }
            string message = "";
            try
            {
                var count = _newsService.Publishs(ids);
                message = $"Đã publish {count} tin tức.";
            }
            catch (System.Exception ex)
            {
                _logger.LogWarning(ex.ToString());
                return ToHttpBadRequest(AddErrors(new IdentityError
                {
                    Code = "Exceptions",
                    Description = ex.ToString(),
                }));
            }
            return ResponseInterceptor(message);
        }

        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpPost("save-dafts-new")]
        // save all to dafts
        public IActionResult SaveDaftsNew([FromBody] string[] ids)
        {
            if (ids == null || ids.Count() == 0)
            {
                return ToHttpBadRequest("The ids is required.");
            }
            string message = "";
            try
            {
                var count = _newsService.Drafts(ids);
                message = $"Đã nháp {count} tin tức.";
            }
            catch (System.Exception ex)
            {
                _logger.LogWarning(ex.ToString());
                return ToHttpBadRequest(AddErrors(new IdentityError
                {
                    Code = "Exceptions",
                    Description = ex.ToString(),
                }));
            }
            return ResponseInterceptor(message);
        }

        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpPost("send-message")]
        // save all to process
        public async Task<IActionResult> SendMessage([FromBody] SendMessageModel model)
        {
            if (!ModelState.IsValid)
            {
                return ToHttpBadRequest(AddErrors(ModelState));
            }
            string message = "";
            try
            {
                var callbackUrl = $"{apiSettings.CorsSites.AdminSite}/ProcessWorks/Step?id={model.TopicId}";

                foreach (var id in model.Ids)
                {
                    var user = await _userManager.FindByIdAsync(id);

                    if (user == null) continue;

                    // ok sendemail 
                    await _emailSender.SendEmailAsync(user.Email, model.Message,
                    $"<b>Thông báo từ Admin, xử lý yêu cầu mã: {(model.TopicId)} </b> <a style='background: #22B8EB;" +
                    $"color: #fff; padding: 10px 20px; margin-bottom: 20px;'" +
                    $"href='{callbackUrl}'>Yêu cầu xử lý</a> <br/><br/>" +
                    $"<br/> <div>{model.Content}</div>"
                    , user?.FullName, 
                    apiSettings.EmailConfig.Email, 
                    apiSettings.EmailConfig.Password);
                }
                message = "Email đã được gởi tới người nhận.";
            }
            catch (System.Exception ex)
            {
                _logger.LogWarning(ex.ToString());
                return ToHttpBadRequest(AddErrors(new IdentityError
                {
                    Code = "Exceptions",
                    Description = ex.ToString(),
                }));
            }
            return ResponseInterceptor(message);
        }

        [AllowAnonymous]
        [HttpGet("city")]
        public IActionResult GetCity()
        {
            using (StreamReader r = new StreamReader("local.json"))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<city>>(json);
                return Ok(items);
            }
        }

        [AllowAnonymous]
        [HttpGet("quan/{id}")]
        public IActionResult GetQuan(string id)
        {
            using (StreamReader r = new StreamReader("local.json"))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<city>>(json);
                var data = items.Where(e => e.id == id).ToList();
                return Ok(data);
            }
        }

        [AllowAnonymous]
        [HttpGet("phuong/{id}/{cityid}")]
        public IActionResult GetPhuong(string id , string cityid)
        {
            using (StreamReader r = new StreamReader("local.json"))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<city>>(json);
                var data = items.Where(e => e.id == cityid).FirstOrDefault();
                var data2 = data.districts.Where(x => x.id == id).FirstOrDefault();
                return Ok(data2);
            }
        }

        [AllowAnonymous]
        [HttpPost("CreateOrUpdateAno")]
        public IActionResult CreateOrUpdateTEST(int? Id, [FromBody] NewsViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return ToHttpBadRequest(AddErrors(ModelState));
            }
            string message = "Ý kiến góp ý đã được gửi tới hệ thống.";
            try
            {
                var entityModel = Mapper.Map<NewsViewModel, NewsModel>(model);
                if (Id.HasValue && Id > 0)
                {
                    entityModel.Id = Id.Value;
                    message = "Góp ý đã được cập nhật.";
                }
                entityModel.IsType = (int?)IsType.topic;
                var newsData = _newsService.AddOrUpdateModel(entityModel);

                //logs 
                var logs = new NewsLog();
                logs.NewsId = newsData.Id;
                logs.UserName = newsData.UserName;
                logs.GroupNameTo = newsData.UserName;
                logs.OnCreated = DateTime.Now;
                _newLog.AddOrUpdate(logs);

                //ldtc
                var logs2 = new NewsLog();
                logs2.NewsId = newsData.Id;
                logs2.UserName = "ldtcmt";
                logs2.GroupNameTo = "ldtcmt";
                logs2.OnCreated = DateTime.Now;
                _newLog.AddOrUpdate(logs2);

                // tra loi nguoi dan

                //ldtc
                var logs3 = new NewsLog();
                logs3.NewsId = newsData.Id;
                logs3.UserName = "anonymous";
                logs3.GroupNameTo = "anonymous";
                logs3.OnCreated = DateTime.Now;
                _newLog.AddOrUpdate(logs3);
            }
            catch (System.Exception ex)
            {
                _logger.LogInformation(ex.ToString());
                return ToHttpBadRequest(AddErrors(new IdentityError
                {
                    Code = "Exceptions",
                    Description = ex.ToString(),
                }));
            }
            return ResponseInterceptor(message);
        }
    }
}