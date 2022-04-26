using Microsoft.EntityFrameworkCore.Migrations;

namespace SoapAB.Migrations
{
    public partial class Articleadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsInStock = table.Column<bool>(type: "bit", nullable: false),
                    DateArrivedToStock = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateSentFromStock = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArticleTypeId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Article_ArticleType_ArticleTypeId",
                        column: x => x.ArticleTypeId,
                        principalTable: "ArticleType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_ArticleTypeId",
                table: "Article",
                column: "ArticleTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");
        }
    }
}
