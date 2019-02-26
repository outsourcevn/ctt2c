using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppPortal.AdminSite.Services.Interfaces;
using AppPortal.AdminSite.Services.Models;
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

namespace AppPortal.ApiHost.Controllers
{
    [Produces("application/json")]
    public class NewsController : ApiBaseController<NewsController>
    {
        private readonly INewsService _newsService;
        private readonly IEmailSender _emailSender;
        private readonly INewsLog _newLog;
        private readonly UserManager<ApplicationUser> _userManager;
        public NewsController(
            IConfiguration configuration, 
            IAppLogger<NewsController> logger,
             IEmailSender emailSender,
            UserManager<ApplicationUser> userManager,
            INewsService newsService,
            INewsLog newLog
            ) : base(configuration, logger)
        {
            _newsService = newsService;
            _newLog = newLog;
            _userManager = userManager;
            _emailSender = emailSender;
        }

        // list new
        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpGet("getNews")]
        public IActionResult ListNewsAsync(int? skip = 0, int? page = 1, int? take = 15000, string keyword = "",
            int? categoryId = -1, int? status = -1, int? type = -1 , string username = "" ,string GroupId = "",
            int? newlogStatus = -1, string mapakn = "")
        {
            var query = _newsService.GetLstNewsPaging(out int rows, skip, take, keyword, categoryId, status, type , username , GroupId, newlogStatus, mapakn);
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

        [AllowAnonymous]
        [HttpGet("getNewsAno")]
        public IActionResult ListNewsAno(string name = "" , string email= "" , string sdt = "" , int id = 0, string mapakn = "", int? is_type = null, string khuvuc = "")
        {
            var query = _newsService.GetLstNewsAno(name , email, sdt, id, mapakn, is_type, khuvuc);
            return Ok(query);
        }

        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpGet("getHomeNews")]
        public IActionResult ListHomeNewsAsync(int? skip = 0, int? page = 1, int? take = 15, string keyword = "",
            int? categoryId = -1, int? status = -1, int? type = -1, string username = "", string GroupId = "")
        {
            var query = _newsService.GetLstHomeNewsPaging(out int rows, skip, take, keyword, categoryId, status, type, username, GroupId);
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

        [AllowAnonymous]
        [HttpGet("getHomeNewsById")]
        public IActionResult ListHomeNewsAsyncById(int id)
        {
            var newsHome = _newsService.GetHomeNewsById(id);
            return ResponseInterceptor(newsHome);
        }

        [AllowAnonymous]
        [HttpGet("getNewsPreviewById")]
        public IActionResult getNewsPreviewById(int id)
        {
            var newsHome = _newsService.getNewsPreviewById(id);
            return ResponseInterceptor(newsHome);
        }

        [AllowAnonymous]
        [HttpGet("getHomeNewsByCate")]
        public IActionResult ListHomeNewsAsyncByCate(int? id = 0 , int? number = 0, int? xemnhieu=0)
        {
            var newsHome = _newsService.GetHomeNewsByCate(id , number,xemnhieu);
            return ResponseInterceptor(newsHome);
        }

        [AllowAnonymous]
        [HttpGet("getHomeNewsBySearch")]
        public IActionResult ListHomeNewsAsyncBySearch(string value = "")
        {
            var newsHome = _newsService.GetHomeNewsBySearch(value);
            return ResponseInterceptor(newsHome);
        }

        // get notifi
        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpGet("GetNotifi")]
        public List<Notifications> GetNotifi(string username = "")
        {
            var query = _newsService.GetNotifications(username);
            return query.ToList();
        }


        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpPost("gop-y")]
        // save all to Publishs
        public IActionResult GopY([FromBody] NewVew3 newView)
        {
            var ids = newView.ids;
            var note = newView.note;
            if (ids == null || ids.Count() == 0)
            {
                return ToHttpBadRequest("The ids is required.");
            }

            string message = "Update thành công";
            try
            {

                var entityModel = _newsService.GetHomeNewsById(Int32.Parse(ids));
                if(entityModel != null)
                {
                    entityModel.Note = note;
                    message = "Cập nhật tin tức thành công";
                    _newsService.AddOrUpdateHomeNews(entityModel);
                }
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

        //UpdateStatus
        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpGet("UpdateStatusNewHome")]
        public IActionResult UpdateStatusNewHome(int Id = 0, int Status = 0)
        {
            string message = "Update trạng thái thành công";
            try
            {
                if (Id > 0)
                {
                    var entityModel = _newsService.GetHomeNewsById(Id);
                    if (Status > 0)
                    {
                        IsStatus converStatus = IsStatus.pending;
                        if(Status == 1)
                        {
                            converStatus = IsStatus.publish;
                        }
                        entityModel.IsStatus = converStatus;
                    }
                    message = "Cập nhật tin tức thành công";
                    _newsService.AddOrUpdateHomeNews(entityModel);

                    // Update log file

                }

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
        

        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpGet("UpdateStatus")]
        public IActionResult UpdateStatus(int Id = 0, int Status = 0)
        {
            string message = "Thêm tin tức thành công";
            try
            {
                if (Id > 0)
                {
                    var entityModel = _newsService.GetNewsById(Id);
                    if(Status > 0)
                    {
                        entityModel.IsStatus = Status;
                    }
                    message = "Cập nhật tin tức thành công";
                    _newsService.AddOrUpdate(entityModel);

                    // Update log file

                }
               
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

        
        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpPost("HomeNewsCreateOrUpdate")]
        public IActionResult HomeNewsCreateOrUpdate(int? Id, [FromBody] HomeNewsViewModel model)
        {
            //if (!ModelState.IsValid)
            //{
            //    return ToHttpBadRequest(AddErrors(ModelState));
            //}
            string message = "Thêm tin tức thành công";
            try
            {
                var entityModel = Mapper.Map<HomeNewsViewModel, HomeNews>(model);
                if (Id.HasValue && Id > 0)
                {
                    entityModel.Id = Id.Value;
                    message = "Cập nhật tin tức thành công";
                }
                _newsService.AddOrUpdateHomeNews(entityModel);
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

        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpPost("NewsPreviewCreateOrUpdate")]
        public IActionResult NewsPreviewCreateOrUpdate(int? Id, [FromBody] HomeNewsViewModel model)
        {
            string message = "Thêm tin tức thành công";
            try
            {
                var entityModel = Mapper.Map<HomeNewsViewModel, NewsPreview>(model);
                if (Id.HasValue && Id > 0)
                {
                    entityModel.Id = Id.Value;
                    message = "Cập nhật tin tức thành công";
                }
                var data = _newsService.AddOrUpdateNewsPreview(entityModel);
                return ResponseInterceptor(data);
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
            string message = "Thêm tin tức thành công";
            try
            {
                var entityModel = Mapper.Map<NewsViewModel, NewsModel>(model);
                if (Id.HasValue && Id > 0)
                {
                    entityModel.Id = Id.Value;
                    message = "Cập nhật tin tức thành công";
                }
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

        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpPost("ShiftDeleteHome")]
        public IActionResult ShiftDeleteHome(int? Id)
        {
            if (!Id.HasValue)
            {
                return ToHttpBadRequest("The Id is request");
            }
            var entity = _newsService.GetHomeNewsById(Id.Value);
            if (entity == null)
            {
                return ToHttpBadRequest("Tin tức không tồn tại.");
            }
            string message = "";
            try
            {
                _newsService.ShiftDeleteHome(Id.Value);
                message = "Tin tức đã được xóa hoàn toàn.";
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

        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpPost("DeleteHome")]
        public IActionResult DeleteHome(int? Id)
        {
            if (!Id.HasValue)
            {
                return ToHttpBadRequest("The Id is request");
            }
            var entity = _newsService.GetHomeNewsById(Id.Value);
            if (entity == null)
            {
                return ToHttpBadRequest("Tin tức không tồn tại.");
            }
            string message = "";
            try
            {
                _newsService.DeleteHome(Id.Value);
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

        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpPost("Hoantac")]
        public IActionResult Hoactac(int? Id)
        {
            if (!Id.HasValue)
            {
                return ToHttpBadRequest("The Id is request");
            }
            var entity = _newsService.GetHomeNewsById(Id.Value);
            if (entity == null)
            {
                return ToHttpBadRequest("Tin tức không tồn tại.");
            }
            string message = "";
            try
            {
                _newsService.Hoactac(Id.Value);
                message = "Tin tức đã được hoàn tác.";
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
        public async Task<IActionResult> ProcessNews([FromBody] string[] ids)
        {
            if (ids == null || ids.Count() == 0)
            {
                return ToHttpBadRequest("The ids is required.");
            }
            string message = "";
            try
            {
                var count = _newsService.Process(ids);
                var id = ids.FirstOrDefault();
                if (!string.IsNullOrEmpty(id))
                {
                    var dataNews = _newsService.GetNewsById(int.Parse(id));
                    string subject = "Hệ thống tiếp nhận và trả lời góp ý, phản ánh về môi trường";
                    string body = "   <p><span style='font-size: 14.0pt; line-height: 115%;'>K&iacute;nh gửi &Ocirc;ng/B&agrave;: " + dataNews.UserFullName + "</span></p>  " +
 "   <p><span style='font-size: 14.0pt; line-height: 115%;'>Nội dung G&oacute;p &yacute;, phản &aacute;nh của &Ocirc;ng/B&agrave; đ&atilde; được xử l&yacute; v&agrave; Đăng tải tr&ecirc;n Hệ thống th&ocirc;ng tin. &Ocirc;ng/B&agrave; vui l&ograve;ng <a href='http://thongtinhaichieu.vea.gov.vn/home/tracuu'>Tra cứu kết quả</a> tr&ecirc;n Hệ thống.</span></p>  " +
 "   <p><span style='font-size: 14.0pt; line-height: 115%;'>&nbsp;</span></p>  " +
 "   <p><span style='font-size: 14.0pt; line-height: 115%;'>Tr&acirc;n trọng !</span></p>  " +
 "   <p><span style='font-size: 14.0pt; line-height: 115%;'>Hệ thống tiếp nhận v&agrave; trả lời g&oacute;p &yacute;, phản &aacute;nh về m&ocirc;i trường</span></p>  "+
 "  <p><span style='font-size: 14.0pt; line-height: 115%;'>Tổng cục M&ocirc;i trường</span></p>  ";
                    if (!string.IsNullOrEmpty(dataNews.UserEmail))
                    {
                        await _emailSender.SendEmailAsync(dataNews.UserEmail, subject, body, String.Empty,
                apiSettings.EmailConfig.Email,
                apiSettings.EmailConfig.Password);
                    }
                }
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
                message = $"Đã chuyển lên lãnh đạo tổng cục thành công!";
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
        [HttpPost("save-publish-new-username")]
        // save all to Publishs
        public async Task<IActionResult> PublishNewsUsernameAsync([FromBody] NewVew2 newView)
        {
            var ids = newView.ids;
            var queryUser = _userManager.Users;
            var username = newView.username;
            var note = newView.note;
            var userid = await  _userManager.GetUserAsync(User);
            if (ids == null || ids.Count() == 0)
            {
                return ToHttpBadRequest("The ids is required.");
            }
            string message = "";
            try
            {
                _newsService.UpdateStatus(ids , IsStatus.phancong);
                
                var item = _newsService.GetNewsById(Int32.Parse(ids));
                if (item != null)
                {
                    var newlogTTDL = _newLog.GetInfoNewLog(item.Id, "ttdl");
                    if (newlogTTDL != null)
                    {
                        newlogTTDL.Note = note;
                        _newLog.AddOrUpdate(newlogTTDL);
                    }

                    if (!string.IsNullOrEmpty(username))
                    {
                        var userFrom = queryUser.Where(x => x.UserName == username).FirstOrDefault();
                        if (userFrom != null)
                        {
                            var newlogEx = _newLog.GetNewLogPhanCong(item.Id);
                            if (newlogEx == null) {
                                var logs = new NewsLog();
                                logs.NewsId = item.Id;
                                logs.UserName = username;
                                if (newView.type == 3)
                                {
                                    logs.GroupNameFrom = "ttdl";
                                    logs.GroupNameTo = "dvct";
                                    logs.TypeStatus = IsTypeStatus.moitiepnhan;
                                }

                                //logs.Note = note;
                                logs.OnCreated = DateTime.Now;
                                logs.FullUserName = userFrom.FullName;
                                _newLog.AddOrUpdate(logs);
                            }
                            else
                            {
                                newlogEx.UserName = username;
                                newlogEx.OnCreated = DateTime.Now;
                                newlogEx.FullUserName = userFrom.FullName;
                                newlogEx.TypeStatus = IsTypeStatus.moitiepnhan;
                                _newLog.AddOrUpdate(newlogEx);
                            }
                            if (userFrom.FullName.ToLower().Contains("sở tài nguyên và môi trường") && !string.IsNullOrEmpty(item.UserEmail))
                            {
                                string subject = "Hệ thống tiếp nhận và trả lời góp ý, phản ánh về môi trường";
                                string body = "   <p><span style='font-size: 14.0pt; line-height: 115%;'>K&iacute;nh gửi &Ocirc;ng/B&agrave;: <span style='color: red;'>"+ item.UserFullName +"</span></span></p>  " +
 "   <p><span style='font-size: 14.0pt; line-height: 115%; color: red;'>Nội dung G&oacute;p &yacute;, phản &aacute;nh của &Ocirc;ng/B&agrave; đ&atilde; được chuyển tới Sở T&agrave;i nguy&ecirc;n v&agrave; M&ocirc;i trường để xử l&yacute; v&agrave; trả lời theo quy định. &Ocirc;ng/B&agrave; vui l&ograve;ng Tra cứu kết quả trả lời tr&ecirc;n Hệ thống.</span></p>  " +
 "   <p><span style='font-size: 14.0pt; line-height: 115%'>&nbsp;</span></p>  " +
 "   <p><span style='font-size: 14.0pt; line-height: 115%;'>Lưu &yacute;:</span></p>  " +
 "   <p><span style='font-size: 14.0pt; line-height: 115%;'>- Mọi th&ocirc;ng tin trong email n&agrave;y cần được bảo mật.</span></p>  " +
 "   <p><span style='font-size: 14.0pt; line-height: 115%;'>- Xin vui l&ograve;ng kh&ocirc;ng trả lời lại email n&agrave;y.</span></p>  " +
 "   <p><span style='font-size: 14.0pt; line-height: 115%;'>Tr&acirc;n trọng!</span></p>  " +
 "   <p><span style='font-size: 14.0pt; line-height: 115%;'>Hệ thống tiếp nhận v&agrave; trả lời g&oacute;p &yacute;, phản &aacute;nh về m&ocirc;i trường</span></p>  " +
 "  <p><span style='font-size: 14.0pt; line-height: 115%;'>Tổng cục M&ocirc;i trường</span></p>  ";
                                await _emailSender.SendEmailAsync(item.UserEmail, subject, body, String.Empty,
                                apiSettings.EmailConfig.Email,
                                apiSettings.EmailConfig.Password);
                            }
                        }
                        
                    }
                }
                message = $"Đã phân công!";
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
        [HttpPost("tuchoitiepnhan")]
        // save all to Publishs
        public async Task<IActionResult> tuchoitiepnhan([FromBody] NewVewTuchoi newView)
        {
            var news_id = newView.news_id;
            var note = newView.note;
          
            if (news_id == 0 || note == null)
            {
                return ToHttpBadRequest("The news_id is required.");
            }
            string message = "";
            try
            {
                var newsData = _newsService.GetNewsById(news_id);
                if (!string.IsNullOrEmpty(newsData.UserEmail)){
                    string subject = "Hệ thống thông tin tiếp nhận góp ý, phản ánh người dân";
                    string body = "   <p><span style='font-size: 14.0pt; line-height: 115%;'>K&iacute;nh gửi &Ocirc;ng/B&agrave;: <span style='color: red;'>"+ newsData.UserFullName + "</span></span></p>  "+
                                 "   <p><span style='font-size: 14.0pt; line-height: 115%; color: red;'>Nội dung G&oacute;p &yacute;, phản &aacute;nh của &Ocirc;ng/B&agrave; kh&ocirc;ng thuộc phạm vi xử l&yacute; của Hệ thống, Hệ thống từ chối tiếp nhận G&oacute;p &yacute;, phản &aacute;nh n&agrave;y. &Ocirc;ng/B&agrave; vui l&ograve;ng đọc kỹ phần <a href='http://thongtinhaichieu.vea.gov.vn/news/guideFeedback'>Hướng dẫn G&oacute;p &yacute;, phản &aacute;nh</a>.</span></p>  " +
                                 "   <p><span style='font-size: 14.0pt; line-height: 115%;'>&nbsp;</span></p>  " +
                                 "   <p>&nbsp;</p>  " +
                                 "   <p><span style='font-size: 14.0pt; line-height: 115%;'>Tr&acirc;n trọng !</span></p>  " +
                                 "   <p><span style='font-size: 14.0pt; line-height: 115%; color: red;'>Hệ thống tiếp nhận v&agrave; trả lời g&oacute;p &yacute;, phản &aacute;nh về m&ocirc;i trường</span></p>  " +
                                 "  <p><span style='font-size: 14pt;'>Tổng cục M&ocirc;i trường</span></p>  ";
                    await _emailSender.SendEmailAsync(newsData.UserEmail, subject, body, String.Empty,
                    apiSettings.EmailConfig.Email,
                    apiSettings.EmailConfig.Password);
                }

                //_newsService.Delete(newsData.Id);

                message = $"Đã từ chối tiếp nhận!";
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
        [HttpPost("save-publish-new-note")]
        // save all to Publishs
        public IActionResult PublishNewsNote([FromBody] NewVew3 newView)
        {
            var ids = newView.ids;
            var note = newView.note;
            if (ids == null || ids.Count() == 0)
            {
                return ToHttpBadRequest("The ids is required.");
            }
            string message = "";
            try
            {
                _newsService.ChuyenLenLanhDao(ids, note);

                // 
                var item = _newsService.GetNewsById(Int32.Parse(ids));
                if(item != null)
                {
                    var logs = new NewsLog();
                    logs.NewsId = item.Id;
                    logs.UserName = item.UserId;
                    logs.GroupNameFrom = "vptc";
                    logs.GroupNameTo = "ldtcmt";
                    logs.Note = note;
                    logs.OnCreated = DateTime.Now;
                    _newLog.AddOrUpdate(logs);
                }
                

                message = $"Đã chuyển lên lãnh đạo tổng cục thành công!";
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
        [HttpPost("save-publish-new-report")]
        // save all to Publishs
        public IActionResult AddOrUpdateNewReport([FromBody] NewViewReport reportData)
        {
            var ids = reportData.ids;
            var username = reportData.username;
            var data = new ReportNewsView();
            data.Id = reportData.Id;
            data.NewsId = reportData.NewsId;
            data.UserName = reportData.UserName;
            data.data = reportData.data;
            data.OnCreated = DateTime.Now;

            if (ids == null || ids.Count() == 0)
            {
                return ToHttpBadRequest("The ids is required.");
            }
            string message = "";
            try
            {
                var count = _newsService.Baocaos(ids, username);
                message = $"Đã báo cáo!";
                _newsService.AddOrUpdateNewReport(data);
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
        [HttpGet("GetReport")]
        // save all to Publishs
        public ReportNews GetReport(int id)
        {
            return _newsService.GetBaocaos(id);
        }

        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpGet("GetDataPhanCong")]
        // save all to Publishs
        public NewsLog GetDataPhanCong(int id , string username)
        {
            return _newLog.GetNewsLogByNewsIdUser(id, username);
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
        [HttpPost("add-related-new")]
        // AddNewRelated
        public IActionResult AddNewRelated(int? Id, [FromBody] NewsRelatedViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return ToHttpBadRequest(AddErrors(ModelState));
            }
            string message = "";
            try
            {
                var entityModel = Mapper.Map<NewsRelatedViewModel, NewsRelatedModel>(model);
                if (Id.HasValue && Id > 0)
                {
                    entityModel.Id = Id.Value;
                }
                _newsService.AddNewRelated(entityModel);
                message = "Tin tức liên quan đã được cập nhật.";

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

        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpGet("phanloai")]
        // AddNewRelated
        public IActionResult PhanLoai(int? Id ,int? istype)
        {
            string message = "";
            try
            {
                if ((int)Id > 0)
                {
                    var entityModel = _newsService.GetNewsById((int)Id);
                    if (Id.HasValue && Id > 0)
                    {
                        entityModel.IsType = istype;
                        entityModel.OnUpdated = DateTime.Now;
                    }
                    _newsService.AddOrUpdate(entityModel);
                    message = "Phân loại thành công.";
                }
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

        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpGet("doituong")]
        // AddNewRelated
        public IActionResult doituong(int? Id, int doituong)
        {
            string message = "";
            try
            {
                if ((int)Id > 0)
                {
                    var entityModel = _newsService.GetNewsById((int)Id);
                    if (Id.HasValue && Id > 0)
                    {
                        if(doituong >= 0)
                        {
                            entityModel.doituong = doituong;
                            entityModel.OnUpdated = DateTime.Now;
                        }
                        
                    }
                    _newsService.AddOrUpdate(entityModel);
                    message = "Phân loại đối tượng thành công.";
                }
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

        [Authorize(PolicyRole.EDIT_ONLY)]
        [HttpGet("xemchitiet")]
        public IActionResult xemchitiet(int? Id)
        {
            string message = "";
            try
            {
                if ((int)Id > 0)
                {
                    var ttdl = _newLog.GetInfoNewLogAndFile((int)Id, "ttdl");
                    var ldtcmt = _newLog.GetInfoNewLogAndFile((int)Id, "ldtcmt");
                    var info = _newsService.GetNewsById((int)Id);
                    return Ok(new { ttdl = ttdl, ldtcmt = ldtcmt, info = info });
                }
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