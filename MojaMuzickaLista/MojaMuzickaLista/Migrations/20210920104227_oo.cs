using Microsoft.EntityFrameworkCore.Migrations;

namespace MojaMuzickaLista.Migrations
{
    public partial class oo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pjesme_Kategorije_KateogorijaID",
                table: "Pjesme");

            migrationBuilder.DropIndex(
                name: "IX_Pjesme_KateogorijaID",
                table: "Pjesme");

            migrationBuilder.DropColumn(
                name: "KateogorijaID",
                table: "Pjesme");

            migrationBuilder.CreateIndex(
                name: "IX_Pjesme_KategorijaID",
                table: "Pjesme",
                column: "KategorijaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pjesme_Kategorije_KategorijaID",
                table: "Pjesme",
                column: "KategorijaID",
                principalTable: "Kategorije",
                principalColumn: "KategorijaID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pjesme_Kategorije_KategorijaID",
                table: "Pjesme");

            migrationBuilder.DropIndex(
                name: "IX_Pjesme_KategorijaID",
                table: "Pjesme");

            migrationBuilder.AddColumn<int>(
                name: "KateogorijaID",
                table: "Pjesme",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pjesme_KateogorijaID",
                table: "Pjesme",
                column: "KateogorijaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pjesme_Kategorije_KateogorijaID",
                table: "Pjesme",
                column: "KateogorijaID",
                principalTable: "Kategorije",
                principalColumn: "KategorijaID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
