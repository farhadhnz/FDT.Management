using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FDT.Management.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedItemsToProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Projects",
                nullable: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "Projects",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "ProjectType",
                table: "Projects",
                nullable: false);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectType",
                table: "Projects");

            migrationBuilder.DropColumn(
              name: "DateModified",
              table: "Projects");

            migrationBuilder.DropColumn(
              name: "DateCreated",
              table: "Projects");
        }
    }
}
