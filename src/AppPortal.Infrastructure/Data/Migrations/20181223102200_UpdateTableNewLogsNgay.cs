using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPortal.Infrastructure.Data.Migrations
{
    public partial class UpdateTableNewLogsNgay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "OnChuyenTraLai",
                schema: "AppPortal",
                table: "NewsLog",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OnXuly",
                schema: "AppPortal",
                table: "NewsLog",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OnChuyenTraLai",
                schema: "AppPortal",
                table: "NewsLog");

            migrationBuilder.DropColumn(
                name: "OnXuly",
                schema: "AppPortal",
                table: "NewsLog");
        }
    }
}
