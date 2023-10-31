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
        public DbSet<ChessBoard> ChessBoards { get; set; }
        public DbSet<Piece> Pieces { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Chess> ChessGames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Some database configuration
            //modelBuilder.Entity<ChessBoard>()
            //      .HasMany(e => e.Squares)
            //      .WithOne(e => e.ChessBoard)
        }
    }

}
