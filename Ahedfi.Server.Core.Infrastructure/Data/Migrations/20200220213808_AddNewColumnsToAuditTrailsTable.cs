using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ahedfi.Server.Core.Infrastructure.Data.Migrations
{
    public partial class AddNewColumnsToAuditTrailsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Column",
                table: "AuditTrails");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AuditTrails");

            migrationBuilder.DropColumn(
                name: "Table",
                table: "AuditTrails");

            migrationBuilder.AddColumn<Guid>(
                name: "BatchId",
                table: "AuditTrails",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "ChangeType",
                table: "AuditTrails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ObjectId",
                table: "AuditTrails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ObjectName",
                table: "AuditTrails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PropertyName",
                table: "AuditTrails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PropertyType",
                table: "AuditTrails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BatchId",
                table: "AuditTrails");

            migrationBuilder.DropColumn(
                name: "ChangeType",
                table: "AuditTrails");

            migrationBuilder.DropColumn(
                name: "ObjectId",
                table: "AuditTrails");

            migrationBuilder.DropColumn(
                name: "ObjectName",
                table: "AuditTrails");

            migrationBuilder.DropColumn(
                name: "PropertyName",
                table: "AuditTrails");

            migrationBuilder.DropColumn(
                name: "PropertyType",
                table: "AuditTrails");

            migrationBuilder.AddColumn<string>(
                name: "Column",
                table: "AuditTrails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AuditTrails",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Table",
                table: "AuditTrails",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
