using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPortal.Infrastructure.Data.Migrations
{
    public partial class AddNewTableMedia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Media",
                schema: "AppPortal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: true),
                    size = table.Column<long>(nullable: false),
                    type = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true),
                    description = table.Column<string>(maxLength: 2000, nullable: true),
                    OnCreated = table.Column<DateTime>(nullable: true),
                    OnDeleted = table.Column<DateTime>(nullable: true),
                    OnPublish = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Media",
                schema: "AppPortal");
        }
    }
}
