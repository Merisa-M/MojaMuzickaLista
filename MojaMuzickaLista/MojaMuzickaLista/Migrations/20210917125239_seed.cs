using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MojaMuzickaLista.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kategorije",
                columns: new[] { "KategorijaID", "nazivKategorije" },
                values: new object[] { 1, "Pop" });

            migrationBuilder.InsertData(
                table: "Pjesme",
                columns: new[] { "PjesmaID", "DatumEditovanja", "DatumUnos", "Favorit", "KateogorijaID", "NazivIzvodjaca", "NazivPjesme", "Ocjena", "Url" },
                values: new object[] { 1, new DateTime(2021, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, "naziv izvodjaca", "naziv pjesme", 4, "https://www.youtube.com/watch?v=RpyN9pFXUCg&list=RDRpyN9pFXUCg&start_radio=1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pjesme",
                keyColumn: "PjesmaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kategorije",
                keyColumn: "KategorijaID",
                keyValue: 1);
        }
    }
}
