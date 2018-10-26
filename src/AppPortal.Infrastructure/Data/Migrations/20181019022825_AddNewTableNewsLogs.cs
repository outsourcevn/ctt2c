using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPortal.Infrastructure.Data.Migrations
{
    public partial class AddNewTableNewsLogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewsLog",
                schema: "AppPortal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NewsId = table.Column<int>(nullable: true),
                    GroupNameFrom = table.Column<string>(nullable: true),
                    GroupNameTo = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Note = table.Column<string>(type: "ntext", nullable: true),
                    AttachFile = table.Column<string>(nullable: true),
                    OnCreated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsLog", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewsLog",
                schema: "AppPortal");
        }
    }
}
