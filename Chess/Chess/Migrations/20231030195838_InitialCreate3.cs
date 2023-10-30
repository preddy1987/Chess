using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChessAPI.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChessGames_ChessBoard_ChessboardId",
                table: "ChessGames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChessBoard",
                table: "ChessBoard");

            migrationBuilder.RenameTable(
                name: "ChessBoard",
                newName: "ChessBoards");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChessBoards",
                table: "ChessBoards",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChessGames_ChessBoards_ChessboardId",
                table: "ChessGames",
                column: "ChessboardId",
                principalTable: "ChessBoards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChessGames_ChessBoards_ChessboardId",
                table: "ChessGames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChessBoards",
                table: "ChessBoards");

            migrationBuilder.RenameTable(
                name: "ChessBoards",
                newName: "ChessBoard");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChessBoard",
                table: "ChessBoard",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChessGames_ChessBoard_ChessboardId",
                table: "ChessGames",
                column: "ChessboardId",
                principalTable: "ChessBoard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
