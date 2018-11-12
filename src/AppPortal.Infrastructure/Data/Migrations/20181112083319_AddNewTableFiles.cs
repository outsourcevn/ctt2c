using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPortal.Infrastructure.Data.Migrations
{
    public partial class AddNewTableFiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Files",
                schema: "AppPortal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NewsLogId = table.Column<int>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    size = table.Column<long>(nullable: false),
                    thumbnailUrl = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true),
                    isDelete = table.Column<int>(nullable: false),
                    OnCreated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Files",
                schema: "AppPortal");
        }
    }
}
