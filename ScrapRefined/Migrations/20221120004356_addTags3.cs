using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScrapRefined.Migrations
{
    public partial class addTags3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tag_Products_ProductId",
                table: "Tag");

            migrationBuilder.DropIndex(
                name: "IX_Tag_ProductId",
                table: "Tag");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Tag");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Tag",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tag_ProductId",
                table: "Tag",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_Products_ProductId",
                table: "Tag",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
