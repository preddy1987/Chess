using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChessAPI.Migrations
{
    public partial class InitialCreate9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Squares_Pieces_PieceId",
                table: "Squares");

            migrationBuilder.AlterColumn<int>(
                name: "PieceId",
                table: "Squares",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Squares_Pieces_PieceId",
                table: "Squares",
                column: "PieceId",
                principalTable: "Pieces",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Squares_Pieces_PieceId",
                table: "Squares");

            migrationBuilder.AlterColumn<int>(
                name: "PieceId",
                table: "Squares",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Squares_Pieces_PieceId",
                table: "Squares",
                column: "PieceId",
                principalTable: "Pieces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
