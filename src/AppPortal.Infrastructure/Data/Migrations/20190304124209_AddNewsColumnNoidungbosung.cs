using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPortal.Infrastructure.Data.Migrations
{
    public partial class AddNewsColumnNoidungbosung : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Noidungbosung",
                schema: "AppPortal",
                table: "News",
                type: "ntext",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Noidungbosung",
                schema: "AppPortal",
                table: "News");
        }
    }
}
