using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Book_kharido.Migrations
{
    /// <inheritdoc />
    public partial class Eight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Ordertime",
                table: "Bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ordertime",
                table: "Bills");
        }
    }
}
