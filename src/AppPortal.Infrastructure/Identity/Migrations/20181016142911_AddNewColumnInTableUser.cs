using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPortal.Infrastructure.Identity.Migrations
{
    public partial class AddNewColumnInTableUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GroupId",
                schema: "AppPortal",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GroupName",
                schema: "AppPortal",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupId",
                schema: "AppPortal",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "GroupName",
                schema: "AppPortal",
                table: "Users");
        }
    }
}
