using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace G4Guidance.Migrations
{
    public partial class ColumnsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "LoginInfo",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedOn",
                table: "LoginInfo",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "LoginInfo",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifitedOn",
                table: "LoginInfo",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "LoginInfo");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "LoginInfo");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "LoginInfo");

            migrationBuilder.DropColumn(
                name: "ModifitedOn",
                table: "LoginInfo");
        }
    }
}
