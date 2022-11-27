using ChessAPI.Models;
using static ChessAPI.Constants;

namespace ChessAPI.Services.Interfaces
{
    public interface IChessService
    {
        List<CoordinatePosition> GetPotentialMovesForPiece(int gameId, int pieceId);
        Chess CreateNewGame();
    }
}
