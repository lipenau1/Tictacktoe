using Microsoft.EntityFrameworkCore.Migrations;

namespace TestArquive.Migrations
{
    public partial class PrimeiraMigracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<string>(type: "CHAR(36)", nullable: false),
                    NameUser = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    SubName = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    Phone = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    Date = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    Password = table.Column<string>(type: "VARCHAR(40)", nullable: false),
                    Photo = table.Column<string>(type: "VARCHAR(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
