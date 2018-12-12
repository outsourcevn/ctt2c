using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPortal.Infrastructure.Data.Migrations
{
    public partial class UpdateMediaIsPublish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeNews_Addresses_AddressId",
                schema: "AppPortal",
                table: "HomeNews");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeNews_Categories_CategoryId",
                schema: "AppPortal",
                table: "HomeNews");

            migrationBuilder.DropForeignKey(
                name: "FK_NewsCategories_HomeNews_HomeNewsId",
                schema: "AppPortal",
                table: "NewsCategories");

            migrationBuilder.DropIndex(
                name: "IX_NewsCategories_HomeNewsId",
                schema: "AppPortal",
                table: "NewsCategories");

            migrationBuilder.DropIndex(
                name: "IX_HomeNews_AddressId",
                schema: "AppPortal",
                table: "HomeNews");

            migrationBuilder.DropIndex(
                name: "IX_HomeNews_CategoryId",
                schema: "AppPortal",
                table: "HomeNews");

            migrationBuilder.DropColumn(
                name: "HomeNewsId",
                schema: "AppPortal",
                table: "NewsCategories");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublish",
                schema: "AppPortal",
                table: "Media",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPublish",
                schema: "AppPortal",
                table: "Media");

            migrationBuilder.AddColumn<int>(
                name: "HomeNewsId",
                schema: "AppPortal",
                table: "NewsCategories",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NewsCategories_HomeNewsId",
                schema: "AppPortal",
                table: "NewsCategories",
                column: "HomeNewsId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeNews_AddressId",
                schema: "AppPortal",
                table: "HomeNews",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeNews_CategoryId",
                schema: "AppPortal",
                table: "HomeNews",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeNews_Addresses_AddressId",
                schema: "AppPortal",
                table: "HomeNews",
                column: "AddressId",
                principalSchema: "AppPortal",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeNews_Categories_CategoryId",
                schema: "AppPortal",
                table: "HomeNews",
                column: "CategoryId",
                principalSchema: "AppPortal",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NewsCategories_HomeNews_HomeNewsId",
                schema: "AppPortal",
                table: "NewsCategories",
                column: "HomeNewsId",
                principalSchema: "AppPortal",
                principalTable: "HomeNews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
