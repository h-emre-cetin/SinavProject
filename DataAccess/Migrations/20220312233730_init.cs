using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SinavKategoris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinavKategoris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoruKategoris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoruKategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoruKategoris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sinavs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinavKategoriId = table.Column<int>(type: "int", nullable: false),
                    SinavAdı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SinavSüresi = table.Column<int>(type: "int", nullable: false),
                    SınavAciklamasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasariPuani = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinavs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sinavs_SinavKategoris_SinavKategoriId",
                        column: x => x.SinavKategoriId,
                        principalTable: "SinavKategoris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sorus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sorular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoruKategoriId = table.Column<int>(type: "int", nullable: false),
                    SoruTipi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sorus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sorus_SoruKategoris_SoruKategoriId",
                        column: x => x.SoruKategoriId,
                        principalTable: "SoruKategoris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Siks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SikText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoruId = table.Column<int>(type: "int", nullable: false),
                    DogruMu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Siks_Sorus_SoruId",
                        column: x => x.SoruId,
                        principalTable: "Sorus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Siks_SoruId",
                table: "Siks",
                column: "SoruId");

            migrationBuilder.CreateIndex(
                name: "IX_Sinavs_SinavKategoriId",
                table: "Sinavs",
                column: "SinavKategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Sorus_SoruKategoriId",
                table: "Sorus",
                column: "SoruKategoriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Siks");

            migrationBuilder.DropTable(
                name: "Sinavs");

            migrationBuilder.DropTable(
                name: "Sorus");

            migrationBuilder.DropTable(
                name: "SinavKategoris");

            migrationBuilder.DropTable(
                name: "SoruKategoris");
        }
    }
}
