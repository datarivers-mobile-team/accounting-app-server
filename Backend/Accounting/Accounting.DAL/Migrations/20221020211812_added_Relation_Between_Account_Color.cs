using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accounting.DAL.Migrations
{
    public partial class added_Relation_Between_Account_Color : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Accounts");

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "Accounts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ColorId",
                table: "Accounts",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Colors_ColorId",
                table: "Accounts",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "ColorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Colors_ColorId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_ColorId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Accounts");

            migrationBuilder.AddColumn<int>(
                name: "Color",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
