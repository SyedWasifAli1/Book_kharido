using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Book_kharido.Migrations
{
    /// <inheritdoc />
    public partial class _22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Townstreels");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Townstreels",
                columns: table => new
                {
                    Towns1Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    KoloMeter = table.Column<double>(type: "float", nullable: false),
                    TownName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Townstreels", x => x.Towns1Id);
                    table.ForeignKey(
                        name: "FK_Townstreels_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Townstreels_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Townstreels_CityId",
                table: "Townstreels",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Townstreels_CountryId",
                table: "Townstreels",
                column: "CountryId");
        }
    }
}
