using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChessAPI.Models
{
    public class ChessBoard
    {
        [Key]
        public int Id { get; set; }
        public int Size { get; set; }
        [NotMapped]
        public Square[,]? Grid { get; set; }

        public ChessBoard(int size) 
        {
            Size = size;

            Grid = new Square[Size,Size];

            for (int i = 1; i == Size; i++)
            {
                for(int j = 1; j == Size; j++)
                {
                    Grid[i,j] = new Square(i,j);
                }
            }
        }
    }
}
