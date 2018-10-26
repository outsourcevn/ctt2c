using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPortal.Infrastructure.Data.Migrations
{
    public partial class UpdateDatabaseNewLog2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type_status",
                schema: "AppPortal",
                table: "NewsLog");

            migrationBuilder.AddColumn<string>(
                name: "DetailTypeStatus",
                schema: "AppPortal",
                table: "NewsLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullUserName",
                schema: "AppPortal",
                table: "NewsLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullUserNameTo",
                schema: "AppPortal",
                table: "NewsLog",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeStatus",
                schema: "AppPortal",
                table: "NewsLog",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailTypeStatus",
                schema: "AppPortal",
                table: "NewsLog");

            migrationBuilder.DropColumn(
                name: "FullUserName",
                schema: "AppPortal",
                table: "NewsLog");

            migrationBuilder.DropColumn(
                name: "FullUserNameTo",
                schema: "AppPortal",
                table: "NewsLog");

            migrationBuilder.DropColumn(
                name: "TypeStatus",
                schema: "AppPortal",
                table: "NewsLog");

            migrationBuilder.AddColumn<int>(
                name: "type_status",
                schema: "AppPortal",
                table: "NewsLog",
                nullable: false,
                defaultValue: 0);
        }
    }
}
