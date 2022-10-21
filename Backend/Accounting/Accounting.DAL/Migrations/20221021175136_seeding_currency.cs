using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accounting.DAL.Migrations
{
    public partial class seeding_currency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "CurrencyId", "IconId", "Symbol", "Title" },
                values: new object[] { 1, null, "$", "Dollar" });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "CurrencyId", "IconId", "Symbol", "Title" },
                values: new object[] { 2, null, "€", "Euro" });
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
        }
    }
}
