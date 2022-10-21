using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accounting.DAL.Migrations
{
    public partial class update_Icon_Currency_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Currencies_Icons_IconId",
                table: "Currencies");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyId",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "IconId",
                table: "Currencies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Currencies_Icons_IconId",
                table: "Currencies",
                column: "IconId",
                principalTable: "Icons",
                principalColumn: "IconId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Currencies_Icons_IconId",
                table: "Currencies");

            migrationBuilder.AlterColumn<int>(
                name: "IconId",
                table: "Currencies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "CurrencyId", "IconId", "Symbol", "Title" },
                values: new object[] { 1, null, "$", "Dollar" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "CurrencyId", "IconId", "Symbol", "Title" },
                values: new object[] { 2, null, "€", "Euro" });

            migrationBuilder.AddForeignKey(
                name: "FK_Currencies_Icons_IconId",
                table: "Currencies",
                column: "IconId",
                principalTable: "Icons",
                principalColumn: "IconId");
        }
    }
}
