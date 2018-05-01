using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Shundao.Migrations
{
    public partial class UpdateTree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Depth",
                table: "Areas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Areas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sorted",
                table: "Areas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Depth",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "Path",
                table: "Areas");

            migrationBuilder.DropColumn(
                name: "Sorted",
                table: "Areas");
        }
    }
}
