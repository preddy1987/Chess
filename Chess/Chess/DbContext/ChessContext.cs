using ChessAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ChessAPI
{
    public class ChessContext : DbContext
    {
        public ChessContext(DbContextOptions<ChessContext> options) : base(options)
        {

        }
        public DbSet<Square> Squares { get; set; }
        public DbSet<Piece> Pieces { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Chess> ChessGames { get; set; }
    }

}
