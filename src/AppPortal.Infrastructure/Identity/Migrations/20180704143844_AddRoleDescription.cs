using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AppPortal.Infrastructure.Identity.Migrations
{
    public partial class AddRoleDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RoleDescription",
                schema: "Security",
                table: "Roles",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleDescription",
                schema: "Security",
                table: "Roles");
        }
    }
}
