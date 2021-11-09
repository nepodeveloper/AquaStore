using Microsoft.EntityFrameworkCore.Migrations;

namespace AquaStoreAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fish",
                columns: table => new
                {
                    FishID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Species = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Fins = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fish", x => x.FishID);
                });

            migrationBuilder.CreateTable(
                name: "Aquaria",
                columns: table => new
                {
                    AquariumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GlassType = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Size = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Shape = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    FishID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aquaria", x => x.AquariumID);
                    table.ForeignKey(
                        name: "FK_Aquaria_Fish_FishID",
                        column: x => x.FishID,
                        principalTable: "Fish",
                        principalColumn: "FishID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aquaria_FishID",
                table: "Aquaria",
                column: "FishID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aquaria");

            migrationBuilder.DropTable(
                name: "Fish");
        }
    }
}
