using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChessAPI.Migrations
{
    public partial class InitialCreate7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Squares_ChessBoardId",
                table: "Squares",
                column: "ChessBoardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Squares_ChessBoards_ChessBoardId",
                table: "Squares",
                column: "ChessBoardId",
                principalTable: "ChessBoards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Squares_ChessBoards_ChessBoardId",
                table: "Squares");

            migrationBuilder.DropIndex(
                name: "IX_Squares_ChessBoardId",
                table: "Squares");
        }
    }
}
