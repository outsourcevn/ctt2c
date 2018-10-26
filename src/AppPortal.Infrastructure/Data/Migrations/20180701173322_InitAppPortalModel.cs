using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AppPortal.Infrastructure.Data.Migrations
{
    public partial class InitAppPortalModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "AppPortal");

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "AppPortal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsShow = table.Column<bool>(nullable: false),
                    LinkFooter = table.Column<string>(nullable: true),
                    LinkHeader = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(maxLength: 1000, nullable: true),
                    MetaKeywords = table.Column<string>(maxLength: 1000, nullable: true),
                    MetaTitle = table.Column<string>(maxLength: 1000, nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    OnCreated = table.Column<DateTime>(nullable: true),
                    OnDeleted = table.Column<DateTime>(nullable: true),
                    OnPublished = table.Column<DateTime>(nullable: true),
                    OnUpdated = table.Column<DateTime>(nullable: true),
                    OrderSort = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: true),
                    Sename = table.Column<string>(maxLength: 500, nullable: true),
                    ShowChild = table.Column<bool>(nullable: false),
                    ShowType = table.Column<int>(type: "int", nullable: false),
                    TargetUrl = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories",
                schema: "AppPortal");
        }
    }
}
