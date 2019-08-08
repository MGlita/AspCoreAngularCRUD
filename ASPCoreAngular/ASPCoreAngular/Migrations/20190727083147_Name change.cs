using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPCoreAngular.Migrations
{
    public partial class Namechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StreetAndNo",
                table: "UserAddress",
                newName: "Street");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Street",
                table: "UserAddress",
                newName: "StreetAndNo");
        }
    }
}
