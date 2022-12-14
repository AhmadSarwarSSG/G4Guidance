using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace G4Guidance.Migrations
{
    public partial class UniTypeAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "uniInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "uniInfos");
        }
    }
}
