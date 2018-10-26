using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPortal.Infrastructure.Data.Migrations
{
    public partial class UpdateDatabaseNewLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserNameTo",
                schema: "AppPortal",
                table: "NewsLog",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "type_status",
                schema: "AppPortal",
                table: "NewsLog",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserNameTo",
                schema: "AppPortal",
                table: "NewsLog");

            migrationBuilder.DropColumn(
                name: "type_status",
                schema: "AppPortal",
                table: "NewsLog");
        }
    }
}
