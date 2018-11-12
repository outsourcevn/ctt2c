using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPortal.Infrastructure.Data.Migrations
{
    public partial class UpdateTinhThanhPhoNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "fileUpload",
                schema: "AppPortal",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "phuongxa",
                schema: "AppPortal",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "quanhuyen",
                schema: "AppPortal",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tinhthanhpho",
                schema: "AppPortal",
                table: "News",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fileUpload",
                schema: "AppPortal",
                table: "News");

            migrationBuilder.DropColumn(
                name: "phuongxa",
                schema: "AppPortal",
                table: "News");

            migrationBuilder.DropColumn(
                name: "quanhuyen",
                schema: "AppPortal",
                table: "News");

            migrationBuilder.DropColumn(
                name: "tinhthanhpho",
                schema: "AppPortal",
                table: "News");
        }
    }
}
