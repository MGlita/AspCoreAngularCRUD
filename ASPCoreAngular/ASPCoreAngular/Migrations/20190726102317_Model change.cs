using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPCoreAngular.Migrations
{
    public partial class Modelchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HomeNumber",
                table: "UserAddress");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "UserAddress");

            migrationBuilder.AddColumn<string>(
                name: "StreetAndNo",
                table: "UserAddress",
                type: "nvarchar(60)",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StreetAndNo",
                table: "UserAddress");

            migrationBuilder.AddColumn<string>(
                name: "HomeNumber",
                table: "UserAddress",
                type: "nvarchar(10)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "UserAddress",
                type: "nvarchar(50)",
                nullable: false);
        }
    }
}
