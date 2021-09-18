using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MojaMuzickaLista.Migrations
{
    public partial class incijalna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategorije",
                columns: table => new
                {
                    KategorijaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazivKategorije = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorije", x => x.KategorijaID);
                });

            migrationBuilder.CreateTable(
                name: "Pjesme",
                columns: table => new
                {
                    PjesmaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivPjesme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NazivIzvodjaca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ocjena = table.Column<int>(type: "int", nullable: false),
                    Favorit = table.Column<bool>(type: "bit", nullable: true),
                    DatumUnos = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumEditovanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KateogorijaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pjesme", x => x.PjesmaID);
                    table.ForeignKey(
                        name: "FK_Pjesme_Kategorije_KateogorijaID",
                        column: x => x.KateogorijaID,
                        principalTable: "Kategorije",
                        principalColumn: "KategorijaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pjesme_KateogorijaID",
                table: "Pjesme",
                column: "KateogorijaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pjesme");

            migrationBuilder.DropTable(
                name: "Kategorije");
        }
    }
}
