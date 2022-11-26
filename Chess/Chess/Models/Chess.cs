namespace ChessAPI.Models
{
    public class Chess
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public List<Square> Squares { get; set; }
        public List<Player> Players { get; set; }

        public Chess()
        {

        }
    }
}
