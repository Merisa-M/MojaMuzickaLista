using Microsoft.EntityFrameworkCore.Migrations;

namespace MojaMuzickaLista.Migrations
{
    public partial class nova : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pjesme_Kategorije_KateogorijaID",
                table: "Pjesme");

            migrationBuilder.AlterColumn<int>(
                name: "KateogorijaID",
                table: "Pjesme",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "KategorijaID",
                table: "Pjesme",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Pjesme",
                keyColumn: "PjesmaID",
                keyValue: 1,
                columns: new[] { "KategorijaID", "KateogorijaID" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "Pjesme",
                keyColumn: "PjesmaID",
                keyValue: 2,
                columns: new[] { "KategorijaID", "KateogorijaID" },
                values: new object[] { 1, null });

            migrationBuilder.AddForeignKey(
                name: "FK_Pjesme_Kategorije_KateogorijaID",
                table: "Pjesme",
                column: "KateogorijaID",
                principalTable: "Kategorije",
                principalColumn: "KategorijaID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pjesme_Kategorije_KateogorijaID",
                table: "Pjesme");

            migrationBuilder.DropColumn(
                name: "KategorijaID",
                table: "Pjesme");

            migrationBuilder.AlterColumn<int>(
                name: "KateogorijaID",
                table: "Pjesme",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Pjesme",
                keyColumn: "PjesmaID",
                keyValue: 1,
                column: "KateogorijaID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Pjesme",
                keyColumn: "PjesmaID",
                keyValue: 2,
                column: "KateogorijaID",
                value: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_Pjesme_Kategorije_KateogorijaID",
                table: "Pjesme",
                column: "KateogorijaID",
                principalTable: "Kategorije",
                principalColumn: "KategorijaID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
