using static ChessAPI.Constants;

namespace ChessAPI.Models
{
    public class Square
    {
        public int Id { get; set; }
        public CoordinatePosition CoordinatePosition { get; set; }
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public Constants.Color Color { get; set; }
        public int PieceId { get; set; }
        public Piece? Piece { get; set; }

        public bool Occupied { get; set; }
        public bool LegalNextMove { get; set; }

        public Square(int x, int y)
        {
            RowNumber = x;
            ColumnNumber = y;
        }
    }
}
