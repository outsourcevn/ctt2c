using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPortal.Infrastructure.Data.Migrations
{
    public partial class EditNewTableMapakn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MaPakn",
                schema: "AppPortal",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ngayxuly",
                schema: "AppPortal",
                table: "News",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "thamquyenxuly",
                schema: "AppPortal",
                table: "News",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaPakn",
                schema: "AppPortal",
                table: "News");

            migrationBuilder.DropColumn(
                name: "ngayxuly",
                schema: "AppPortal",
                table: "News");

            migrationBuilder.DropColumn(
                name: "thamquyenxuly",
                schema: "AppPortal",
                table: "News");
        }
    }
}
