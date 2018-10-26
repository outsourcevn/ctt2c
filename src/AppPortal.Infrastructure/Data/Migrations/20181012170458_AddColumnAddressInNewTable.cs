using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPortal.Infrastructure.Data.Migrations
{
    public partial class AddColumnAddressInNewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddressString",
                schema: "AppPortal",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lat",
                schema: "AppPortal",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lng",
                schema: "AppPortal",
                table: "News",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressString",
                schema: "AppPortal",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Lat",
                schema: "AppPortal",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Lng",
                schema: "AppPortal",
                table: "News");
        }
    }
}
