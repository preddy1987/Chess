using ChessAPI;
namespace ChessAPI.Models
{
    public class Piece
    {
        public int Id { get; set; }
        public string CoordinatePosition { get; set; }
        public Constants.Color Color { get; set; }
        public Constants.PieceType PieceType { get; set; }
        public int SquareId { get; set; }
        public string StartingPosition { get; set; }
    }
}
