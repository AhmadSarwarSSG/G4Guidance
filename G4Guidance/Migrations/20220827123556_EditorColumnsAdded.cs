using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace G4Guidance.Migrations
{
    public partial class EditorColumnsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "blogInfos",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedOn",
                table: "blogInfos",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "blogInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "blogInfos",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ModifitedOn",
                table: "blogInfos",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "blogInfos");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "blogInfos");

            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "blogInfos");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "blogInfos");

            migrationBuilder.DropColumn(
                name: "ModifitedOn",
                table: "blogInfos");
        }
    }
}
