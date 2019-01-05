using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPortal.Infrastructure.Data.Migrations
{
    public partial class AddNewTableNewsPreview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewsPreview",
                schema: "AppPortal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 2000, nullable: true),
                    Sename = table.Column<string>(maxLength: 500, nullable: true),
                    Abstract = table.Column<string>(maxLength: 2000, nullable: true),
                    Content = table.Column<string>(type: "ntext", nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Link = table.Column<string>(maxLength: 500, nullable: true),
                    IsShow = table.Column<bool>(type: "bit", nullable: false),
                    IsStatus = table.Column<int>(type: "int", nullable: false),
                    IsNew = table.Column<int>(type: "int", nullable: false),
                    IsView = table.Column<int>(type: "int", nullable: false),
                    IsType = table.Column<int>(type: "int", nullable: false),
                    IsPosition = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(maxLength: 500, nullable: true),
                    UserName = table.Column<string>(maxLength: 255, nullable: true),
                    UserFullName = table.Column<string>(maxLength: 255, nullable: true),
                    UserEmail = table.Column<string>(maxLength: 255, nullable: true),
                    UserPhone = table.Column<string>(nullable: true),
                    UserAddress = table.Column<string>(nullable: true),
                    CountView = table.Column<int>(nullable: true),
                    CountLike = table.Column<int>(nullable: true),
                    SourceNews = table.Column<string>(maxLength: 255, nullable: true),
                    Note = table.Column<string>(maxLength: 1000, nullable: true),
                    CategoryId = table.Column<int>(nullable: true),
                    AddressId = table.Column<int>(nullable: true),
                    AddressString = table.Column<string>(nullable: true),
                    Lat = table.Column<string>(nullable: true),
                    Lng = table.Column<string>(nullable: true),
                    tinhthanhpho = table.Column<string>(nullable: true),
                    quanhuyen = table.Column<string>(nullable: true),
                    phuongxa = table.Column<string>(nullable: true),
                    fileUpload = table.Column<string>(nullable: true),
                    sovanban = table.Column<string>(nullable: true),
                    tenvanban = table.Column<string>(nullable: true),
                    ngaybanhanh = table.Column<DateTime>(nullable: true),
                    loaivanban = table.Column<string>(nullable: true),
                    cqbanhanh = table.Column<string>(nullable: true),
                    ngayhieuluc = table.Column<string>(nullable: true),
                    tinhtranghieuluc = table.Column<string>(nullable: true),
                    nguoiky = table.Column<string>(nullable: true),
                    chucdanh = table.Column<string>(nullable: true),
                    MetaTitle = table.Column<string>(maxLength: 1000, nullable: true),
                    MetaKeywords = table.Column<string>(maxLength: 1000, nullable: true),
                    MetaDescription = table.Column<string>(maxLength: 1000, nullable: true),
                    OnCreated = table.Column<DateTime>(nullable: true),
                    OnUpdated = table.Column<DateTime>(nullable: true),
                    OnDeleted = table.Column<DateTime>(nullable: true),
                    OnPublished = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsPreview", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewsPreview",
                schema: "AppPortal");
        }
    }
}
