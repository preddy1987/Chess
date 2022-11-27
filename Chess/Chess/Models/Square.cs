using static ChessAPI.Constants;

namespace ChessAPI.Models
{
    public class Square
    {
        public int Id { get; set; }
        public CoordinatePosition CoordinatePosition { get; set; }
        public Constants.Color Color { get; set; }
        public int PieceId { get; set; }
        public Piece? Piece { get; set; }
    }
}
