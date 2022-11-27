namespace ChessAPI.Models
{
    public class Chess
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; } = DateTime.Now;
        public List<Square> Chessboard { get; set; }
        public List<Player> Players { get; set; }

        public Chess()
        {

        }
    }
}
