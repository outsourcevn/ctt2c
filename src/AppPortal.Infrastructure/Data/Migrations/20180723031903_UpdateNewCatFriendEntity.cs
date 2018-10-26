using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AppPortal.Infrastructure.Data.Migrations
{
    public partial class UpdateNewCatFriendEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OrderSort",
                schema: "AppPortal",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "LinkHeader",
                schema: "AppPortal",
                table: "Categories",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LinkFooter",
                schema: "AppPortal",
                table: "Categories",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Position",
                schema: "AppPortal",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FriendShips",
                schema: "AppPortal",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    FriendId = table.Column<string>(maxLength: 500, nullable: true),
                    FriendShipStatus = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendShips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                schema: "AppPortal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Abstract = table.Column<string>(maxLength: 2000, nullable: true),
                    AddressId = table.Column<int>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true),
                    Content = table.Column<string>(type: "ntext", nullable: true),
                    CountLike = table.Column<int>(nullable: true),
                    CountView = table.Column<int>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    IsNew = table.Column<int>(type: "int", nullable: false),
                    IsPosition = table.Column<int>(type: "int", nullable: false),
                    IsShow = table.Column<bool>(type: "int", nullable: false),
                    IsStatus = table.Column<int>(type: "int", nullable: false),
                    IsType = table.Column<int>(type: "int", nullable: false),
                    IsView = table.Column<int>(type: "int", nullable: false),
                    Link = table.Column<string>(maxLength: 500, nullable: true),
                    MetaDescription = table.Column<string>(maxLength: 1000, nullable: true),
                    MetaKeywords = table.Column<string>(maxLength: 1000, nullable: true),
                    MetaTitle = table.Column<string>(maxLength: 1000, nullable: true),
                    Name = table.Column<string>(maxLength: 2000, nullable: true),
                    Note = table.Column<string>(maxLength: 1000, nullable: true),
                    OnCreated = table.Column<DateTime>(nullable: true),
                    OnDeleted = table.Column<DateTime>(nullable: true),
                    OnPublished = table.Column<DateTime>(nullable: true),
                    OnUpdated = table.Column<DateTime>(nullable: true),
                    Sename = table.Column<string>(maxLength: 500, nullable: true),
                    SourceNews = table.Column<string>(maxLength: 255, nullable: true),
                    UserEmail = table.Column<string>(maxLength: 255, nullable: true),
                    UserFullName = table.Column<string>(maxLength: 255, nullable: true),
                    UserId = table.Column<string>(maxLength: 500, nullable: true),
                    UserName = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalSchema: "AppPortal",
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_News_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "AppPortal",
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewsRelateds",
                schema: "AppPortal",
                columns: table => new
                {
                    NewsId1 = table.Column<int>(nullable: false),
                    NewsId2 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsRelateds", x => new { x.NewsId1, x.NewsId2 });
                });

            migrationBuilder.CreateTable(
                name: "NewsCategories",
                schema: "AppPortal",
                columns: table => new
                {
                    NewsId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsCategories", x => new { x.NewsId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_NewsCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "AppPortal",
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NewsCategories_News_NewsId",
                        column: x => x.NewsId,
                        principalSchema: "AppPortal",
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_News_AddressId",
                schema: "AppPortal",
                table: "News",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_News_CategoryId",
                schema: "AppPortal",
                table: "News",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsCategories_CategoryId",
                schema: "AppPortal",
                table: "NewsCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsRelateds_NewsId1_NewsId2",
                schema: "AppPortal",
                table: "NewsRelateds",
                columns: new[] { "NewsId1", "NewsId2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FriendShips",
                schema: "AppPortal");

            migrationBuilder.DropTable(
                name: "NewsCategories",
                schema: "AppPortal");

            migrationBuilder.DropTable(
                name: "NewsRelateds",
                schema: "AppPortal");

            migrationBuilder.DropTable(
                name: "News",
                schema: "AppPortal");

            migrationBuilder.DropColumn(
                name: "Position",
                schema: "AppPortal",
                table: "Categories");

            migrationBuilder.AlterColumn<int>(
                name: "OrderSort",
                schema: "AppPortal",
                table: "Categories",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LinkHeader",
                schema: "AppPortal",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LinkFooter",
                schema: "AppPortal",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);
        }
    }
}
