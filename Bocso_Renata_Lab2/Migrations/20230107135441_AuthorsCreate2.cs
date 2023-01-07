using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bocso_Renata_Lab2.Migrations
{
    public partial class AuthorsCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Authors_AuthorId",
                table: "Book");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Book",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Authors_AuthorId",
                table: "Book",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Authors_AuthorId",
                table: "Book");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Authors_AuthorId",
                table: "Book",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
