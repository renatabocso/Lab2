using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bocso_Renata_Lab2.Migrations
{
    public partial class RenameId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Book",
                newName: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Book",
                newName: "Id");
        }
    }
}
