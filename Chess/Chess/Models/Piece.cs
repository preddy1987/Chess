using ChessAPI;
using static ChessAPI.Constants;

namespace ChessAPI.Models
{
    public class Piece
    {
        public int Id { get; set; }
        public Player Player { get; set; }
        public Constants.Color Color { get; set; }
        public Constants.PieceType PieceType { get; set; }
        //public List<CoordinatePosition> PotentialMoves { get; set; }
    }
}
