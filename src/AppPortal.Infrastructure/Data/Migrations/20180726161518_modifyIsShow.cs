using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AppPortal.Infrastructure.Data.Migrations
{
    public partial class modifyIsShow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsShow",
                schema: "AppPortal",
                table: "News",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsShow",
                schema: "AppPortal",
                table: "News",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
