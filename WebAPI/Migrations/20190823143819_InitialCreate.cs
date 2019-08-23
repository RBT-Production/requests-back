using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RequestDetails",
                columns: table => new
                {
                    no = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    firm = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    fio = table.Column<string>(type: "varchar(255)", nullable: false),
                    position = table.Column<string>(type: "varchar(255)", nullable: false),
                    email = table.Column<string>(type: "varchar(255)", nullable: false),
                    date = table.Column<long>(type: "BIGINT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestDetails", x => x.no);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RequestDetails");
        }
    }
}
