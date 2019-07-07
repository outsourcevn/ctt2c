using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPortal.Infrastructure.Identity.Migrations
{
    public partial class AddEmailAuthColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailAuth",
                schema: "AppPortal",
                table: "Users",
                type: "ntext",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailAuth",
                schema: "AppPortal",
                table: "Users");
        }
    }
}
