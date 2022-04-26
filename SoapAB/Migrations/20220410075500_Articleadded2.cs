using Microsoft.EntityFrameworkCore.Migrations;

namespace SoapAB.Migrations
{
    public partial class Articleadded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ArticleType",
                newName: "ArticleTypeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Article",
                newName: "ArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ArticleTypeId",
                table: "ArticleType",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ArticleId",
                table: "Article",
                newName: "Id");
        }
    }
}
