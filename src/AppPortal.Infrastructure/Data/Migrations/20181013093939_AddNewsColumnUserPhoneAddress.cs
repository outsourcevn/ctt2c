using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPortal.Infrastructure.Data.Migrations
{
    public partial class AddNewsColumnUserPhoneAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserAddress",
                schema: "AppPortal",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserPhone",
                schema: "AppPortal",
                table: "News",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserAddress",
                schema: "AppPortal",
                table: "News");

            migrationBuilder.DropColumn(
                name: "UserPhone",
                schema: "AppPortal",
                table: "News");
        }
    }
}
