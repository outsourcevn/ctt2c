using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPortal.Infrastructure.Data.Migrations
{
    public partial class AddNewTableHomeNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HomeNewsId",
                schema: "AppPortal",
                table: "NewsCategories",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HomeNews",
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
                    table.PrimaryKey("PK_HomeNews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeNews_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalSchema: "AppPortal",
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HomeNews_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "AppPortal",
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NewsCategories_HomeNewsId",
                schema: "AppPortal",
                table: "NewsCategories",
                column: "HomeNewsId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeNews_AddressId",
                schema: "AppPortal",
                table: "HomeNews",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeNews_CategoryId",
                schema: "AppPortal",
                table: "HomeNews",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_NewsCategories_HomeNews_HomeNewsId",
                schema: "AppPortal",
                table: "NewsCategories",
                column: "HomeNewsId",
                principalSchema: "AppPortal",
                principalTable: "HomeNews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewsCategories_HomeNews_HomeNewsId",
                schema: "AppPortal",
                table: "NewsCategories");

            migrationBuilder.DropTable(
                name: "HomeNews",
                schema: "AppPortal");

            migrationBuilder.DropIndex(
                name: "IX_NewsCategories_HomeNewsId",
                schema: "AppPortal",
                table: "NewsCategories");

            migrationBuilder.DropColumn(
                name: "HomeNewsId",
                schema: "AppPortal",
                table: "NewsCategories");
        }
    }
}
