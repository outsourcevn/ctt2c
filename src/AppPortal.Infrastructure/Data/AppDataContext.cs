using AppPortal.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppPortal.Infrastructure.App
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>(ConfigureCategory);
            modelBuilder.Entity<Address>(ConfigureAddress);
            modelBuilder.Entity<News>(ConfigureNews);
            modelBuilder.Entity<NewsRelated>(ConfigureNewsRelated);
            modelBuilder.Entity<NewsCategory>(ConfigureNewsCategory);
            modelBuilder.Entity<FriendShip>(ConfigureFriendShip);
            modelBuilder.Entity<ReportNews>(ConfigureReportNews);
            modelBuilder.Entity<Notifications>(ConfigureNotifications);
            modelBuilder.Entity<NewsLog>(ConfigureNewsLog);
            modelBuilder.Entity<Files>(ConfigureFiles);
            modelBuilder.Entity<HomeNews>(ConfigureHomeNews);
            modelBuilder.Entity<NewsPreview>(ConfigureNewsPreview);
            modelBuilder.Entity<Media>(ConfigureMedia);
            modelBuilder.Entity<Config>(ConfigureConfig);
        }

        #region Mapping
        private void ConfigureCategory(EntityTypeBuilder<Category> b)
        {
            b.ToTable("Categories", "AppPortal");
            b.Property(c => c.Id).UseSqlServerIdentityColumn().IsRequired();
            b.Property(c => c.Name).HasMaxLength(255);
            b.Property(c => c.Sename).HasMaxLength(500);
            b.Property(c => c.ShowType).HasColumnType("int");
            b.Property(c => c.Position).HasColumnType("int");
            b.Property(c => c.TargetUrl).HasMaxLength(500);
            b.Property(c => c.LinkHeader).HasMaxLength(255);
            b.Property(c => c.LinkFooter).HasMaxLength(255);
            b.Property(c => c.MetaTitle).HasMaxLength(1000);
            b.Property(c => c.MetaKeywords).HasMaxLength(1000);
            b.Property(c => c.MetaDescription).HasMaxLength(1000);
        }

        private void ConfigureAddress(EntityTypeBuilder<Address> b)
        {
            b.ToTable("Addresses", "AppPortal");
            b.Property(c => c.Id).UseSqlServerIdentityColumn().IsRequired();
            b.Property(c => c.Name).HasMaxLength(255);
            b.Property(c => c.LatLong).HasMaxLength(100);
            b.Property(c => c.ProvinceType).HasMaxLength(11);
        }

        private void ConfigureFriendShip(EntityTypeBuilder<FriendShip> b)
        {
            b.ToTable("FriendShips", "AppPortal");
            b.Property(c => c.Id).IsRequired();
            b.Property(c => c.UserId).HasMaxLength(500);
            b.Property(c => c.FriendId).HasMaxLength(500);
            b.Property(c => c.FriendShipStatus).HasColumnType("int");
        }

        private void ConfigureNewsCategory(EntityTypeBuilder<NewsCategory> b)
        {
            b.ToTable("NewsCategories", "AppPortal");
            b.HasKey(p => new { p.NewsId, p.CategoryId });
            b.HasOne(pt => pt.News)
            .WithMany(p => p.NewsCategories)
            .HasForeignKey(pt => pt.NewsId).OnDelete(DeleteBehavior.Restrict);
            b.HasOne(pt => pt.Categories)
             .WithMany(p => p.NewsCategories)
             .HasForeignKey(pt => pt.CategoryId).OnDelete(DeleteBehavior.Restrict);
            b.Ignore(p => p.Id);
        }

        private void ConfigureNewsRelated(EntityTypeBuilder<NewsRelated> b)
        {
            b.ToTable("NewsRelateds", "AppPortal");
            b.HasKey(p => new { p.NewsId1, p.NewsId2 });
            b.HasIndex(p => new { p.NewsId1, p.NewsId2 });
            b.Ignore(p => p.Id);
        }

        private void ConfigureNews(EntityTypeBuilder<News> b)
        {
            b.ToTable("News", "AppPortal");
            b.Property(c => c.Id).UseSqlServerIdentityColumn().IsRequired();
            b.Property(c => c.Name).HasMaxLength(2000);
            b.Property(c => c.Abstract).HasMaxLength(2000);
            b.Property(c => c.Content).HasColumnType("ntext");
            b.Property(c => c.Link).HasMaxLength(500);
            b.Property(c => c.Sename).HasMaxLength(500);

            b.Property(c => c.MetaTitle).HasMaxLength(1000);
            b.Property(c => c.MetaKeywords).HasMaxLength(1000);
            b.Property(c => c.MetaDescription).HasMaxLength(1000);

            b.Property(c => c.UserName).HasMaxLength(255);
            b.Property(c => c.UserEmail).HasMaxLength(255);
            b.Property(c => c.UserFullName).HasMaxLength(255);
            b.Property(c => c.UserId).HasMaxLength(500);

            b.Property(c => c.SourceNews).HasMaxLength(255);
            b.Property(c => c.Note).HasMaxLength(1000);

            b.Property(c => c.IsNew).HasColumnType("int");
            b.Property(c => c.IsPosition).HasColumnType("int");
            b.Property(c => c.IsShow).HasColumnType("bit");
            b.Property(c => c.IsStatus).HasColumnType("int");
            b.Property(c => c.IsType).HasColumnType("int");
            b.Property(c => c.IsView).HasColumnType("int");

            b.HasOne(c => c.Category)
             .WithMany(c => c.News)
             .HasForeignKey(c => c.CategoryId)
             .OnDelete(DeleteBehavior.Cascade);

            b.HasOne(c => c.Address)
             .WithMany(c => c.News)
             .HasForeignKey(c => c.AddressId)
             .OnDelete(DeleteBehavior.Cascade);
        }

        private void ConfigureReportNews(EntityTypeBuilder<ReportNews> b)
        {
            b.ToTable("ReportNews", "AppPortal");
        }

        private void ConfigureNotifications(EntityTypeBuilder<Notifications> b)
        {
            b.ToTable("Notifications", "AppPortal");
        }

        private void ConfigureNewsLog(EntityTypeBuilder<NewsLog> b)
        {
            b.ToTable("NewsLog", "AppPortal");
            b.Property(c => c.Note).HasColumnType("ntext");
            b.Property(c => c.Data).HasColumnType("ntext");
        }

        private void ConfigureFiles(EntityTypeBuilder<Files> b)
        {
            b.ToTable("Files", "AppPortal");
        }

        private void ConfigureHomeNews(EntityTypeBuilder<HomeNews> b)
        {
            b.ToTable("HomeNews", "AppPortal");
            b.Property(c => c.Id).UseSqlServerIdentityColumn().IsRequired();
            b.Property(c => c.Name).HasMaxLength(2000);
            b.Property(c => c.Abstract).HasMaxLength(2000);
            b.Property(c => c.Content).HasColumnType("ntext");
            b.Property(c => c.Link).HasMaxLength(500);
            b.Property(c => c.Sename).HasMaxLength(500);

            b.Property(c => c.MetaTitle).HasMaxLength(1000);
            b.Property(c => c.MetaKeywords).HasMaxLength(1000);
            b.Property(c => c.MetaDescription).HasMaxLength(1000);

            b.Property(c => c.UserName).HasMaxLength(255);
            b.Property(c => c.UserEmail).HasMaxLength(255);
            b.Property(c => c.UserFullName).HasMaxLength(255);
            b.Property(c => c.UserId).HasMaxLength(500);

            b.Property(c => c.SourceNews).HasMaxLength(255);
            b.Property(c => c.Note).HasMaxLength(1000);

            b.Property(c => c.IsNew).HasColumnType("int");
            b.Property(c => c.IsPosition).HasColumnType("int");
            b.Property(c => c.IsShow).HasColumnType("bit");
            b.Property(c => c.IsStatus).HasColumnType("int");
            b.Property(c => c.IsType).HasColumnType("int");
            b.Property(c => c.IsView).HasColumnType("int");
        }

        private void ConfigureMedia(EntityTypeBuilder<Media> b)
        {
            b.ToTable("Media", "AppPortal");
            b.Property(c => c.description).HasMaxLength(2000);
        }

        private void ConfigureConfig(EntityTypeBuilder<Config> b)
        {
            b.ToTable("Config", "AppPortal");
            b.Property(c => c.url).HasMaxLength(2000);
        }

        private void ConfigureNewsPreview(EntityTypeBuilder<NewsPreview> b)
        {
            b.ToTable("NewsPreview", "AppPortal");
            b.Property(c => c.Id).UseSqlServerIdentityColumn().IsRequired();
            b.Property(c => c.Name).HasMaxLength(2000);
            b.Property(c => c.Abstract).HasMaxLength(2000);
            b.Property(c => c.Content).HasColumnType("ntext");
            b.Property(c => c.Link).HasMaxLength(500);
            b.Property(c => c.Sename).HasMaxLength(500);

            b.Property(c => c.MetaTitle).HasMaxLength(1000);
            b.Property(c => c.MetaKeywords).HasMaxLength(1000);
            b.Property(c => c.MetaDescription).HasMaxLength(1000);

            b.Property(c => c.UserName).HasMaxLength(255);
            b.Property(c => c.UserEmail).HasMaxLength(255);
            b.Property(c => c.UserFullName).HasMaxLength(255);
            b.Property(c => c.UserId).HasMaxLength(500);

            b.Property(c => c.SourceNews).HasMaxLength(255);
            b.Property(c => c.Note).HasMaxLength(1000);

            b.Property(c => c.IsNew).HasColumnType("int");
            b.Property(c => c.IsPosition).HasColumnType("int");
            b.Property(c => c.IsShow).HasColumnType("bit");
            b.Property(c => c.IsStatus).HasColumnType("int");
            b.Property(c => c.IsType).HasColumnType("int");
            b.Property(c => c.IsView).HasColumnType("int");
        }

        #endregion
    }
}
