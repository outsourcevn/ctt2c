using System;
using System.Linq;
using System.Threading.Tasks;
using AppPortal.Core;
using AppPortal.Core.Entities;
using AppPortal.Core.Interfaces;
using AppPortal.Infrastructure.App;
using AppPortal.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AppPortal.AdminSite
{
    public static class DbInitializer
    {
        public static async Task InitializeAsync(IServiceProvider services)
        {
            var indentityDbContext = services.GetRequiredService<AppIdentityDbContext>();
            var dataDbContext = services.GetRequiredService<AppDataContext>();

            var category = services.GetRequiredService<IRepository<Category, int>>();
            var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = services.GetRequiredService<RoleManager<ApplicationRole>>();

            // TODO: Only run this if using a real database
            await indentityDbContext.Database.MigrateAsync();
            await dataDbContext.Database.MigrateAsync();

            if (!category.Table.Any())
            {
                category.Add(new Category { ParentId = null, OrderSort = 1, Name = "Công bố bản đồ lớp môi trường tổng hợp", Sename = CommonHelper.UltilityHelper.unicodeToNoMark("Công bố bản đồ lớp môi trường tổng hợp"), IsShow = true, OnCreated = DateTime.Now, ShowType = ShowType.IsNormal, TargetUrl = "_self" });
                category.Add(new Category { ParentId = null, OrderSort = 2, Name = "Công bố Thông tin quan trắc tổng hợp", Sename = CommonHelper.UltilityHelper.unicodeToNoMark("Công bố Thông tin quan trắc tổng hợp"), IsShow = true, OnCreated = DateTime.Now, ShowType = ShowType.IsNormal, TargetUrl = "_self" });
                category.Add(new Category { ParentId = null, OrderSort = 3, Name = "Công bố Văn bản pháp quy về môi trường", Sename = CommonHelper.UltilityHelper.unicodeToNoMark("Công bố Văn bản pháp quy về môi trường"), IsShow = true, OnCreated = DateTime.Now, ShowType = ShowType.IsNormal, TargetUrl = "_self" });
                category.Add(new Category { ParentId = null, OrderSort = 4, Name = "Công bố Câu hỏi và câu trả lời mẫu về các chủ đề quan tâm (Q&A)", Sename = CommonHelper.UltilityHelper.unicodeToNoMark("Công bố Câu hỏi và câu trả lời mẫu về các chủ đề quan tâm (Q&A)"), IsShow = true, OnCreated = DateTime.Now, ShowType = ShowType.IsNormal, TargetUrl = "_self" });
                category.Add(new Category { ParentId = null, OrderSort = 5, Name = "Công bố Tin tức môi trường", Sename = CommonHelper.UltilityHelper.unicodeToNoMark("Công bố Tin tức môi trường"), IsShow = true, OnCreated = DateTime.Now, ShowType = ShowType.IsNormal, TargetUrl = "_self" });
                category.Add(new Category { ParentId = null, OrderSort = 1, Name = "Ô nhiễm nước", Sename = CommonHelper.UltilityHelper.unicodeToNoMark("Ô nhiễm nước"), IsShow = true, OnCreated = DateTime.Now, ShowType = ShowType.IsTopic, TargetUrl = "_self" });
                category.Add(new Category { ParentId = null, OrderSort = 2, Name = "Ô nhiễm biển và hải đảo", Sename = CommonHelper.UltilityHelper.unicodeToNoMark("Ô nhiễm biển và hải đảo"), IsShow = true, OnCreated = DateTime.Now, ShowType = ShowType.IsTopic, TargetUrl = "_self" });
                category.Add(new Category { ParentId = null, OrderSort = 3, Name = "Ô nhiễm đất", Sename = CommonHelper.UltilityHelper.unicodeToNoMark("Ô nhiễm đất"), IsShow = true, OnCreated = DateTime.Now, ShowType = ShowType.IsTopic, TargetUrl = "_self" });
                category.Add(new Category { ParentId = null, OrderSort = 4, Name = "Ô nhiễm không khí", Sename = CommonHelper.UltilityHelper.unicodeToNoMark("Ô nhiễm không khí"), IsShow = true, OnCreated = DateTime.Now, ShowType = ShowType.IsTopic, TargetUrl = "_self" });
                category.Add(new Category { ParentId = null, OrderSort = 5, Name = "Ô nhiễm chất thải", Sename = CommonHelper.UltilityHelper.unicodeToNoMark("Ô nhiễm chất thải"), IsShow = true, OnCreated = DateTime.Now, ShowType = ShowType.IsTopic, TargetUrl = "_self" });
                category.Add(new Category { ParentId = null, OrderSort = 6, Name = "Bảo vệ rừng", Sename = CommonHelper.UltilityHelper.unicodeToNoMark("Bảo vệ rừng"), IsShow = true, OnCreated = DateTime.Now, ShowType = ShowType.IsTopic, TargetUrl = "_self" });
            }

            if (!roleManager.Roles.Any())
            {
                await roleManager.CreateAsync(new ApplicationRole { Name = AppConst.ROLE_SYSADMIN, RoleDescription = "System Administrator" });
                await roleManager.CreateAsync(new ApplicationRole { Name = AppConst.ROLE_Mode, RoleDescription = "Ban lãnh đạo" });
                await roleManager.CreateAsync(new ApplicationRole { Name = AppConst.ROLE_Department, RoleDescription = "Phòng ban" });
                await roleManager.CreateAsync(new ApplicationRole { Name = AppConst.ROLE_Editor, RoleDescription = "Đăng bài" });
                await roleManager.CreateAsync(new ApplicationRole { Name = AppConst.ROLE_User, RoleDescription = "User thường trực" });
                await roleManager.CreateAsync(new ApplicationRole { Name = AppConst.ROLE_Member, RoleDescription = "User thường" });
                await roleManager.CreateAsync(new ApplicationRole { Name = AppConst.ROLE_Guest, RoleDescription = "Khách" });
            }

            if (!userManager.Users.Any())
            {
                var sysAdmin = new ApplicationUser { UserName = "SysAdmin", EmailConfirmed = true, Email = "nguyenvannam0411@gmail.com", FullName = "SysAdmin <Supper Admin>", TypeUser = AppConst.GROUP_ADMIN };
                var huynv = new ApplicationUser { UserName = "huynv", EmailConfirmed = true, Email = "vnnvh80@gmail.com", FullName = "Huy Nguyen <Admin>", TypeUser = AppConst.GROUP_ADMIN };
                                               
                await userManager.CreateAsync(sysAdmin, "123456@qA");
                await userManager.AddToRoleAsync(sysAdmin, AppConst.ROLE_SYSADMIN);

                await userManager.CreateAsync(huynv, "123456@qA");
                await userManager.AddToRoleAsync(huynv, AppConst.ROLE_SYSADMIN);

                var userOne = new ApplicationUser { UserName = "usertest1", EmailConfirmed = true, Email = "usertest1@gmail.com", FullName = "User test 1", TypeUser = AppConst.GROUP_USER };
                await userManager.CreateAsync(userOne, "123456@qA");
                await userManager.AddToRoleAsync(userOne, AppConst.ROLE_User);
            }

            if(userManager.Users.Count() == 2)
            {

                // TỔNG CỤC QUẢN LÝ ĐẤT ĐAI
                // TỔNG CỤC QUẢN LÝ ĐẤT ĐAI
                // TỔNG CỤC MÔI TRƯỜNG

                var quanlydd = new ApplicationUser { UserName = "quanlydd", EmailConfirmed = true, Email = "vnnvh80@gmail.com", FullName = "TỔNG CỤC QUẢN LÝ ĐẤT ĐAI <Admin>", TypeUser = AppConst.GROUP_ADMIN };
                var quanlymt = new ApplicationUser { UserName = "quanlymt", EmailConfirmed = true, Email = "vnnvh80@gmail.com", FullName = "TỔNG CỤC MÔI TRƯỜNG <Admin>", TypeUser = AppConst.GROUP_ADMIN };
                var quanlytnn = new ApplicationUser { UserName = "quanlytnn", EmailConfirmed = true, Email = "vnnvh80@gmail.com", FullName = "CỤC QUẢN LÝ TÀI NGUYÊN NƯỚC <Admin>", TypeUser = AppConst.GROUP_ADMIN };

                await userManager.CreateAsync(quanlydd, "123456@qA");
                await userManager.AddToRoleAsync(quanlydd, AppConst.ROLE_SYSADMIN);

                await userManager.CreateAsync(quanlymt, "123456@qA");
                await userManager.AddToRoleAsync(quanlymt, AppConst.ROLE_SYSADMIN);

                await userManager.CreateAsync(quanlytnn, "123456@qA");
                await userManager.AddToRoleAsync(quanlytnn, AppConst.ROLE_SYSADMIN);
            }
        }
    }
}
