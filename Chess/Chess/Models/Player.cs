namespace ChessAPI.Models
{
    public class Player
    {
        public int Id { get; set; }
        public DateTime TimeRemaining { get; set; }
        public int NumberOfTurns { get; set; }
        public Constants.Color Color { get; set; }
    }
}
