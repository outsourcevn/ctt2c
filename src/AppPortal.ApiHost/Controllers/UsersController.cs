using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppPortal.ApiHost.Controllers.Base;
using AppPortal.ApiHost.ViewModels;
using AppPortal.ApiHost.ViewModels.Users;
using AppPortal.Core;
using AppPortal.Core.Interfaces;
using AppPortal.Infrastructure.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AppPortal.ApiHost.Controllers
{
    [Produces("application/json")]
    public class UsersController : ApiBaseController<UsersController>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public UsersController(
            IConfiguration configuration,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            IAppLogger<UsersController> logger) : base(configuration, logger)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [Authorize(PolicyRole.ADMINISTRATOR_ONLY)]
        [HttpGet("getUsersForType")]
        public IList<ApplicationUser> getUsersForType(string type = "")
        {
            if (string.IsNullOrEmpty(type)) type = "";
            var query = _userManager.Users;
            query = query.Where(z => z.GroupId == type);
            var data = query.ToList();
            return data;
        }
        #region ' FOR ADMINISTRATOR '
        [Authorize(PolicyRole.ADMINISTRATOR_ONLY)]
        [HttpGet("getUsers")]
        public async Task<IActionResult> ListUsersAsync(string keyword, int? take = 15, int? skip = 0, int? page = 1)
        {
            if (string.IsNullOrEmpty(keyword)) keyword = "";
            var query = _userManager.Users;
            if (!string.IsNullOrEmpty(keyword) && keyword != "") query = query.Where(x => x.Email.Contains(keyword) || x.UserName.Contains(keyword) || x.FullName.Contains(keyword));

            // paging
            if (page.HasValue && page.Value > 1) skip = (page - 1) * take;
            int rows = query.Count();
            if (skip > rows)
            {
                take = rows % take.Value;
                skip = 0;
                query = query.Skip(rows - take.Value).Take(take.Value);
            }
            else query = query.Skip(skip.Value).Take(take.Value);

            var source = await query
                .Select(x => new ListItemsViewModel<string, UserViewModel>
                {
                    Id = x.Id,
                    Name = x.UserName,
                    Field = new UserViewModel
                    {
                        Id = x.Id,
                        FullName = x.FullName,
                        Email = x.Email,
                        Phone = x.PhoneNumber,
                        TypeAccount = x.TypeUser
                    }
                }).ToListAsync();
            return ResponseInterceptor(source, rows, new Paging()
            {
                PageNumber = page.Value,
                PageSize = take.Value,
                Take = take.Value,
                Skip = skip.Value,
                Query = keyword
            });
        }
        #endregion ' FOR ADMINISTRATOR '

        #region ' FOR USER '
        [Authorize(PolicyRole.EMPLOYEE_ID)]
        [HttpPost("profile")]
        public async Task<IActionResult> Profile([FromBody] UserProfileViewModel model)
        {
            _logger.LogInformation($"{nameof(Profile)} update");
            if (!ModelState.IsValid)
            {
                return ToHttpBadRequest(AddErrors(ModelState));
            }
            var userLoginedId = User.FindFirst(c => c.Type == "userloginedId").Value;
            if (userLoginedId == null)
                return ToBadUserNotExist();
            if (userLoginedId != model.Id)
                return ToBadUserNotAcess();
            var user = await _userManager.FindByIdAsync(userLoginedId);
            if (user == null)
                return ToBadUserNotExist();
            // update user
            user.FullName = model.FullName ?? null;
            user.Email = model.Email ?? null;
            user.PhoneNumber = model.PhoneNumber ?? null;
            var indentityResult = await _userManager.UpdateAsync(user);
            if (!indentityResult.Succeeded)
            {
                _logger.LogInformation($"{nameof(Profile)} update fail.");
                return ToHttpBadRequest(AddErrors(indentityResult));
            }
            _logger.LogInformation($"{nameof(Profile)} updated success");
            return ResponseInterceptor("Thông tin tài khoản đã được cập nhật.");
        }

        [Authorize(PolicyRole.ADMINISTRATOR_ONLY)]
        [HttpPost("CreateOrUpdate")]
        public async Task<IActionResult> CreateOrUpdate([FromBody] AccountViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return ToHttpBadRequest(AddErrors(ModelState));
            }
            string message = "";
            if (string.IsNullOrWhiteSpace(model.Id))
            {
                var account = new ApplicationUser
                {
                    UserName = model.UserName,
                    EmailConfirmed = true,
                    Email = model.Email,
                    FullName = model.FullName,
                    TypeUser = model.TypeAccount,
                    GroupId = model.GroupId,
                    GroupName = model.GroupName
                };
                var identityResult = await _userManager.CreateAsync(account, model.Password);
                if (!identityResult.Succeeded)
                {
                    return ToHttpBadRequest(AddErrors(identityResult));
                }
                var roles = model.Roles.Where(t => t.Value == true).Select(t => t.Key);
                if (roles.Count() > 0)
                {
                    var result = await _userManager.AddToRolesAsync(account, roles);
                    if (!result.Succeeded)
                    {
                        return ToHttpBadRequest(AddErrors(result));
                    }
                }
                message = "Tài khoản đã được tạo.";
            }
            else
            {
                var user = await _userManager.FindByIdAsync(model.Id);
                if(user == null)
                {
                    return ToBadUserNotExist();
                }
                user.FullName = model.FullName;
                user.Email = model.Email;
                user.PhoneNumber = model.PhoneNumber;
                user.UserName = model.UserName;
                user.GroupId = model.GroupId;
                user.GroupName = model.GroupName;
                var updateResult = await _userManager.UpdateAsync(user);
                if(!updateResult.Succeeded)
                {
                    return ToHttpBadRequest(AddErrors(updateResult));
                }
                if(!string.IsNullOrEmpty(model.Password))
                {
                    var addPassResult = await _userManager.AddPasswordAsync(user, model.Password);
                    if(!addPassResult.Succeeded)
                    {
                        return ToHttpBadRequest(AddErrors(addPassResult));
                    }
                }
                var roles = model.Roles.Where(t => t.Value == true).Select(t => t.Key);
                if (roles.Count() > 0)
                {
                    var userRoles = await _userManager.GetRolesAsync(user);
                    var removeRoles = userRoles.Where(item => !roles.Contains(item)).ToArray();
                    var addRoles = roles.Where(item => !userRoles.Contains(item)).ToArray();
                    var removeRoleResult = await _userManager.RemoveFromRolesAsync(user, removeRoles);
                    if (!removeRoleResult.Succeeded)
                    {
                        return ToHttpBadRequest(AddErrors(removeRoleResult));
                    }
                    var addRoleResult = await _userManager.AddToRolesAsync(user, addRoles);
                    if (!addRoleResult.Succeeded)
                    {
                        return ToHttpBadRequest(AddErrors(addRoleResult));
                    }
                }
                message = "Tài khoản đã được cập nhật.";
            }

            return ResponseInterceptor(message);
        }

        [Authorize(PolicyRole.ADMINISTRATOR_ONLY)]
        [HttpPost("remove")]
        public async Task<IActionResult> Remove([FromBody] string id)
        {
            if(string.IsNullOrEmpty(id))
            {
                return ToBadUserNotAcess();
            }
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return ToBadUserNotExist();
            }
            var userLoginedId = User.FindFirst(c => c.Type == "userloginedId").Value;
            if(user.Id == userLoginedId)
            {
                return ToBadUserNotAcess();
            }
            var deleted = await _userManager.DeleteAsync(user);
            if (!deleted.Succeeded)
            {
                return ToHttpBadRequest(AddErrors(deleted));
            }
            return ResponseInterceptor("Tài khoản đã bị xóa");
        }

        [Authorize(PolicyRole.ADMINISTRATOR_ONLY)]
        [HttpPost("removeAll")]
        public async Task<IActionResult> RemoveAll([FromBody] string[] ids)
        {
            if(ids == null || ids.Count() == 0)
            {
                return ToBadUserNotAcess();
            }
            foreach (var item in ids)
            {
                var user = await _userManager.FindByIdAsync(item);
                if (user == null)
                {
                    continue;  
                }
                var userLoginedId = User.FindFirst(c => c.Type == "userloginedId").Value;
                if (user.Id == userLoginedId)
                {
                    continue;
                }
                var result = await _userManager.DeleteAsync(user);
                if(!result.Succeeded)
                {
                    continue;
                }
            }
            return ResponseInterceptor("Tài khoản đã bị xóa");
        }

        #endregion ' FOR USER '

        #region ' PRIVATE '

        #endregion ' PRIVATE '
    }
}