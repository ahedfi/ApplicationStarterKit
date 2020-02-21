using Microsoft.EntityFrameworkCore.Migrations;

namespace Ahedfi.Server.Core.Infrastructure.Data.Migrations
{
    public partial class RenameTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Customers_CustomerId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Addresses_SecondAddressId",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditTrails",
                table: "AuditTrails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "APP_CUS_Customers");

            migrationBuilder.RenameTable(
                name: "AuditTrails",
                newName: "APP_AUD_Audits");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "APP_ADD_Adresses");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_SecondAddressId",
                table: "APP_CUS_Customers",
                newName: "IX_APP_CUS_Customers_SecondAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_CustomerId",
                table: "APP_ADD_Adresses",
                newName: "IX_APP_ADD_Adresses_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_APP_CUS_Customers",
                table: "APP_CUS_Customers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_APP_AUD_Audits",
                table: "APP_AUD_Audits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_APP_ADD_Adresses",
                table: "APP_ADD_Adresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_APP_ADD_Adresses_APP_CUS_Customers_CustomerId",
                table: "APP_ADD_Adresses",
                column: "CustomerId",
                principalTable: "APP_CUS_Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_APP_CUS_Customers_APP_ADD_Adresses_SecondAddressId",
                table: "APP_CUS_Customers",
                column: "SecondAddressId",
                principalTable: "APP_ADD_Adresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_APP_ADD_Adresses_APP_CUS_Customers_CustomerId",
                table: "APP_ADD_Adresses");

            migrationBuilder.DropForeignKey(
                name: "FK_APP_CUS_Customers_APP_ADD_Adresses_SecondAddressId",
                table: "APP_CUS_Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_APP_CUS_Customers",
                table: "APP_CUS_Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_APP_AUD_Audits",
                table: "APP_AUD_Audits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_APP_ADD_Adresses",
                table: "APP_ADD_Adresses");

            migrationBuilder.RenameTable(
                name: "APP_CUS_Customers",
                newName: "Customers");

            migrationBuilder.RenameTable(
                name: "APP_AUD_Audits",
                newName: "AuditTrails");

            migrationBuilder.RenameTable(
                name: "APP_ADD_Adresses",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_APP_CUS_Customers_SecondAddressId",
                table: "Customers",
                newName: "IX_Customers_SecondAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_APP_ADD_Adresses_CustomerId",
                table: "Addresses",
                newName: "IX_Addresses_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditTrails",
                table: "AuditTrails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Customers_CustomerId",
                table: "Addresses",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Addresses_SecondAddressId",
                table: "Customers",
                column: "SecondAddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
