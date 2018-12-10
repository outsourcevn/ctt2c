using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPortal.Infrastructure.Data.Migrations
{
    public partial class EditTableVanBanPhapQuy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "chucdanh",
                schema: "AppPortal",
                table: "HomeNews",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cqbanhanh",
                schema: "AppPortal",
                table: "HomeNews",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "loaivanban",
                schema: "AppPortal",
                table: "HomeNews",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ngaybanhanh",
                schema: "AppPortal",
                table: "HomeNews",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ngayhieuluc",
                schema: "AppPortal",
                table: "HomeNews",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nguoiky",
                schema: "AppPortal",
                table: "HomeNews",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sovanban",
                schema: "AppPortal",
                table: "HomeNews",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tenvanban",
                schema: "AppPortal",
                table: "HomeNews",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tinhtranghieuluc",
                schema: "AppPortal",
                table: "HomeNews",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "chucdanh",
                schema: "AppPortal",
                table: "HomeNews");

            migrationBuilder.DropColumn(
                name: "cqbanhanh",
                schema: "AppPortal",
                table: "HomeNews");

            migrationBuilder.DropColumn(
                name: "loaivanban",
                schema: "AppPortal",
                table: "HomeNews");

            migrationBuilder.DropColumn(
                name: "ngaybanhanh",
                schema: "AppPortal",
                table: "HomeNews");

            migrationBuilder.DropColumn(
                name: "ngayhieuluc",
                schema: "AppPortal",
                table: "HomeNews");

            migrationBuilder.DropColumn(
                name: "nguoiky",
                schema: "AppPortal",
                table: "HomeNews");

            migrationBuilder.DropColumn(
                name: "sovanban",
                schema: "AppPortal",
                table: "HomeNews");

            migrationBuilder.DropColumn(
                name: "tenvanban",
                schema: "AppPortal",
                table: "HomeNews");

            migrationBuilder.DropColumn(
                name: "tinhtranghieuluc",
                schema: "AppPortal",
                table: "HomeNews");
        }
    }
}
