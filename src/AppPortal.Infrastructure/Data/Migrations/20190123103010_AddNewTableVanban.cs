using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppPortal.Infrastructure.Data.Migrations
{
    public partial class AddNewTableVanban : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vanban",
                schema: "AppPortal",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    sovanban = table.Column<string>(nullable: true),
                    tenvanban = table.Column<string>(nullable: true),
                    ngaybanhanh = table.Column<DateTime>(nullable: false),
                    loaivanban = table.Column<string>(nullable: true),
                    coquanbanhanh = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true),
                    IsPublish = table.Column<bool>(nullable: false),
                    OnCreated = table.Column<DateTime>(nullable: true),
                    OnDeleted = table.Column<DateTime>(nullable: true),
                    OnPublish = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vanban", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vanban",
                schema: "AppPortal");
        }
    }
}
