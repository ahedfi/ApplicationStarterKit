using Microsoft.EntityFrameworkCore.Migrations;

namespace Ahedfi.Server.Core.Infrastructure.Data.Migrations
{
    public partial class RemoveUnusedColumnInAuditTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PropertyType",
                table: "APP_AUD_Audits");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PropertyType",
                table: "APP_AUD_Audits",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
