using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accounting.DAL.Migrations
{
    public partial class seeding_Icon_Currency_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Icons",
                columns: new[] { "IconId", "FileName", "IconType", "Oeder", "Title" },
                values: new object[] { 1, "", (byte)3, 0, "Dollar" });

            migrationBuilder.InsertData(
                table: "Icons",
                columns: new[] { "IconId", "FileName", "IconType", "Oeder", "Title" },
                values: new object[] { 2, "", (byte)3, 0, "Euro" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "CurrencyId", "IconId", "Symbol", "Title" },
                values: new object[] { 1, 1, "$", "Dollar" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "CurrencyId", "IconId", "Symbol", "Title" },
                values: new object[] { 2, 2, "€", "Euro" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "CurrencyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Icons",
                keyColumn: "IconId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Icons",
                keyColumn: "IconId",
                keyValue: 2);
        }
    }
}
