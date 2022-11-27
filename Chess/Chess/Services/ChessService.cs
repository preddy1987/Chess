using ChessAPI.Models;
using ChessAPI.Services.Interfaces;
using static ChessAPI.Constants;

namespace ChessAPI.Services
{
    public class ChessService : IChessService
    {
        
        public Chess CreateNewGame()
        {
            Chess newgame = new Chess();
            return newgame;
        }

        private List<Square> SetupChessBoard()
        {
            var board = new List<Square>();

            return board;

        }
        public List<CoordinatePosition> GetPotentialMovesForPiece(int gameId, int pieceId)
        {
            return new List<CoordinatePosition>();
        }
    }
}
