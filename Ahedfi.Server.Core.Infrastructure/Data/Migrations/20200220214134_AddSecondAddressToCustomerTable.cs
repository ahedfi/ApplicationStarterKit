using Microsoft.EntityFrameworkCore.Migrations;

namespace Ahedfi.Server.Core.Infrastructure.Data.Migrations
{
    public partial class AddSecondAddressToCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SecondAddressId",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_SecondAddressId",
                table: "Customers",
                column: "SecondAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Addresses_SecondAddressId",
                table: "Customers",
                column: "SecondAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Addresses_SecondAddressId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_SecondAddressId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SecondAddressId",
                table: "Customers");
        }
    }
}
