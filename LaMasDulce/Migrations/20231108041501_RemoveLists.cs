using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaMasDulce.Migrations
{
    public partial class RemoveLists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlavorTreat");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlavorTreat",
                columns: table => new
                {
                    FlavorsFlavorId = table.Column<int>(type: "int", nullable: false),
                    TreatsTreatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlavorTreat", x => new { x.FlavorsFlavorId, x.TreatsTreatId });
                    table.ForeignKey(
                        name: "FK_FlavorTreat_Flavors_FlavorsFlavorId",
                        column: x => x.FlavorsFlavorId,
                        principalTable: "Flavors",
                        principalColumn: "FlavorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlavorTreat_Treats_TreatsTreatId",
                        column: x => x.TreatsTreatId,
                        principalTable: "Treats",
                        principalColumn: "TreatId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_FlavorTreat_TreatsTreatId",
                table: "FlavorTreat",
                column: "TreatsTreatId");
        }
    }
}
