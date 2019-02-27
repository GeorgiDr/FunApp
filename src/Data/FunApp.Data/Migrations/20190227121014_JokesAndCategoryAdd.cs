using Microsoft.EntityFrameworkCore.Migrations;

namespace FunApp.Data.Migrations
{
    public partial class JokesAndCategoryAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Joke_Category_CategoryId",
                table: "Joke");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Joke",
                table: "Joke");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Joke",
                newName: "Jokes");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Joke_CategoryId",
                table: "Jokes",
                newName: "IX_Jokes_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jokes",
                table: "Jokes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jokes_Categories_CategoryId",
                table: "Jokes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jokes_Categories_CategoryId",
                table: "Jokes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jokes",
                table: "Jokes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Jokes",
                newName: "Joke");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_Jokes_CategoryId",
                table: "Joke",
                newName: "IX_Joke_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Joke",
                table: "Joke",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Joke_Category_CategoryId",
                table: "Joke",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
