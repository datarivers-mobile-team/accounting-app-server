using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accounting.DAL.Migrations
{
    public partial class added_Account : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "UserAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartAmount = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<int>(type: "int", nullable: false),
                    Icon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAccounts_AccountId",
                table: "UserAccounts",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAccounts_Accounts_AccountId",
                table: "UserAccounts",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAccounts_Accounts_AccountId",
                table: "UserAccounts");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_UserAccounts_AccountId",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "UserAccounts");
        }
    }
}
