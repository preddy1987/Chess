using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChessAPI.Models
{
    public class ChessBoard
    {
        [Key]
        public int Id { get; set; }
        public int Size { get; set; }
        //[NotMapped]
        //public Square[,]? Grid { get; set; }

        public List<Square> Squares { get; set; }

        public ChessBoard(int size) 
        {
            Size = size;

            //Grid = new Square[Size,Size];
            Squares = new List<Square>();

            for (int x = 0; x < Size; x++)
            {
                for(int y = 0; y < Size; y++)
                {
                    Square square = new Square(x, y);
                    //Grid[x, y] = square;
                    Squares.Add(square);
                }
            }
        }

        public Square[,] GenerateBoardGrid()
        {
            var grid = new Square[Size, Size];

            foreach (Square square in Squares)
            {
                grid[square.RowNumber, square.ColumnNumber] = square;
            }

            return grid;
            //var Grid = new Square[Size, Size];

            //for (int x = 1; x == Size; x++)
            //{
            //    for (int y = 1; y == Size; y++)
            //    {
            //        Square square = new Square(x, y);
            //        grid[x, y] = square;
            //    }
            //}

            //return grid;
        }
    }
}
