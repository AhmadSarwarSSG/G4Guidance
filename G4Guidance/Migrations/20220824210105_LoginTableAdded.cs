using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace G4Guidance.Migrations
{
    public partial class LoginTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "LoginInfo",
            //    columns: table => new
            //    {
            //        Username = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: false),
            //        Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        Password = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__LoginInf__536C85E5A87CF017", x => x.Username);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Table",
            //    columns: table => new
            //    {
            //        username = table.Column<string>(type: "varchar(70)", unicode: false, maxLength: 70, nullable: false),
            //        email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
            //        password = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Table__F3DBC57353F4E357", x => x.username);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "LoginInfo");

            //migrationBuilder.DropTable(
            //    name: "Table");
        }
    }
}
