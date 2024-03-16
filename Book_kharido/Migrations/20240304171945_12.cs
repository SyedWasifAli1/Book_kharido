using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Book_kharido.Migrations
{
    /// <inheritdoc />
    public partial class _12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FAQsId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_FAQsId",
                table: "Contacts",
                column: "FAQsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_FAQs_FAQsId",
                table: "Contacts",
                column: "FAQsId",
                principalTable: "FAQs",
                principalColumn: "FAQsId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_FAQs_FAQsId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_FAQsId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "FAQsId",
                table: "Contacts");
        }
    }
}
