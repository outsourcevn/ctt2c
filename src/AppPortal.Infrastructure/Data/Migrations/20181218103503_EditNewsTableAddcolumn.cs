using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPortal.Infrastructure.Data.Migrations
{
    public partial class EditNewsTableAddcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TenCaNhanToChuc",
                schema: "AppPortal",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Thoigianxayra",
                schema: "AppPortal",
                table: "News",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenCaNhanToChuc",
                schema: "AppPortal",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Thoigianxayra",
                schema: "AppPortal",
                table: "News");
        }
    }
}
