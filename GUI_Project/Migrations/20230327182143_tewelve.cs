using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GUI_Project.Migrations
{
    /// <inheritdoc />
    public partial class tewelve : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DOB",
                table: "StudentDetailsFor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DOB",
                table: "StudentDetailsFor",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }
    }
}
