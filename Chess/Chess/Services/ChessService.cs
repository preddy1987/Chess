using ChessAPI.Models;
using ChessAPI.Services.Interfaces;
using static ChessAPI.Constants;

namespace ChessAPI.Services
{
    public class ChessService : IChessService
    {
        private readonly ChessContext _ctx;
        public ChessService(ChessContext chessContext) 
        {
            _ctx = chessContext;
        }


        public async Task<Chess> CreateNewGame()
        {
            Chess newgame = new Chess();
            newgame.StartTime = DateTime.Now;
            newgame.Players = new List<Player>();
            Player player1 = new Player();
            player1.Color = Color.White;
            Player player2 = new Player();
            player2.Color = Color.Black;
            newgame.Players.Add(player1);
            newgame.Players.Add(player2);
            newgame.Chessboard = SetupChessBoard(player1, player2);
            _ctx.ChessGames.Add(newgame);
            _ctx.SaveChanges();
            return newgame;
        }

        public async Task<Chess> GetGameState(int gameId)
        {
            var game = _ctx.ChessGames.Where(cs => cs.Id == gameId).FirstOrDefault();
            if (game == null)
            {
                game = await CreateNewGame();
            }
            
            return game;
        }

        private List<Square> SetupChessBoard(Player player1, Player player2)
        {
            var board = new List<Square>();

            foreach (CoordinatePosition coordinatePosition in (CoordinatePosition[])Enum.GetValues(typeof(CoordinatePosition)))
            {
                var square = new Square();
                switch (coordinatePosition)
                {
                    case CoordinatePosition.A8:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        square.Piece = new Piece();
                        square.Piece.Player = player2;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Rook;
                        break;
                    case CoordinatePosition.B8:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        square.Piece = new Piece();
                        square.Piece.Player = player2;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Knight;
                        break;
                    case CoordinatePosition.C8:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        square.Piece = new Piece();
                        square.Piece.Player = player2;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Bishop;
                        break;
                    case CoordinatePosition.D8:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        square.Piece = new Piece();
                        square.Piece.Player = player2;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Queen;
                        break;
                    case CoordinatePosition.E8:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        square.Piece = new Piece();
                        square.Piece.Player = player2;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.King;
                        break;
                    case CoordinatePosition.F8:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        square.Piece = new Piece();
                        square.Piece.Player = player2;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Bishop;
                        break;
                    case CoordinatePosition.G8:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        square.Piece = new Piece();
                        square.Piece.Player = player2;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Knight;
                        break;
                    case CoordinatePosition.H8:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        square.Piece = new Piece();
                        square.Piece.Player = player2;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Rook;
                        break;
                    case CoordinatePosition.A7:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        square.Piece = new Piece();
                        square.Piece.Player = player2;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Pawn;
                        break;
                    case CoordinatePosition.B7:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        square.Piece = new Piece();
                        square.Piece.Player = player2;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Pawn;
                        break;
                    case CoordinatePosition.C7:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        square.Piece = new Piece();
                        square.Piece.Player = player2;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Pawn;
                        break;
                    case CoordinatePosition.D7:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        square.Piece = new Piece();
                        square.Piece.Player = player2;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Pawn;
                        break;
                    case CoordinatePosition.E7:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        square.Piece = new Piece();
                        square.Piece.Player = player2;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Pawn;
                        break;
                    case CoordinatePosition.F7:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        square.Piece = new Piece();
                        square.Piece.Player = player2;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Pawn;
                        break;
                    case CoordinatePosition.G7:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        square.Piece = new Piece();
                        square.Piece.Player = player2;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Pawn;
                        break;
                    case CoordinatePosition.H7:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        square.Piece = new Piece();
                        square.Piece.Player = player2;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Pawn;
                        break;
                    case CoordinatePosition.A6:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        break;
                    case CoordinatePosition.B6:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        break;
                    case CoordinatePosition.C6:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        break;
                    case CoordinatePosition.D6:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        break;
                    case CoordinatePosition.E6:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        break;
                    case CoordinatePosition.F6:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        break;
                    case CoordinatePosition.G6:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        break;
                    case CoordinatePosition.H6:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        break;
                    case CoordinatePosition.A5:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        break;
                    case CoordinatePosition.B5:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        break;
                    case CoordinatePosition.C5:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        break;
                    case CoordinatePosition.D5:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        break;
                    case CoordinatePosition.E5:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        break;
                    case CoordinatePosition.F5:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        break;
                    case CoordinatePosition.G5:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        break;
                    case CoordinatePosition.H5:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        break;
                    case CoordinatePosition.A4:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        break;
                    case CoordinatePosition.B4:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        break;
                    case CoordinatePosition.C4:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        break;
                    case CoordinatePosition.D4:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        break;
                    case CoordinatePosition.E4:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        break;
                    case CoordinatePosition.F4:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        break;
                    case CoordinatePosition.G4:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        break;
                    case CoordinatePosition.H4:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        break;
                    case CoordinatePosition.A3:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        break;
                    case CoordinatePosition.B3:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        break;
                    case CoordinatePosition.C3:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        break;
                    case CoordinatePosition.D3:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        break;
                    case CoordinatePosition.E3:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        break;
                    case CoordinatePosition.F3:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        break;
                    case CoordinatePosition.G3:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        break;
                    case CoordinatePosition.H3:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        break;
                    case CoordinatePosition.A2:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        square.Piece = new Piece();
                        square.Piece.Player = player1;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Pawn;
                        break;
                    case CoordinatePosition.B2:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        square.Piece = new Piece();
                        square.Piece.Player = player1;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Pawn;
                        break;
                    case CoordinatePosition.C2:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        square.Piece = new Piece();
                        square.Piece.Player = player1;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Pawn;
                        break;
                    case CoordinatePosition.D2:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        square.Piece = new Piece();
                        square.Piece.Player = player1;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Pawn;
                        break;
                    case CoordinatePosition.E2:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        square.Piece = new Piece();
                        square.Piece.Player = player1;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Pawn;
                        break;
                    case CoordinatePosition.F2:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        square.Piece = new Piece();
                        square.Piece.Player = player1;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Pawn;
                        break;
                    case CoordinatePosition.G2:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        square.Piece = new Piece();
                        square.Piece.Player = player1;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Pawn;
                        break;
                    case CoordinatePosition.H2:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        square.Piece = new Piece();
                        square.Piece.Player = player1;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Pawn;
                        break;
                    case CoordinatePosition.A1:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        square.Piece = new Piece();
                        square.Piece.Player = player1;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Rook;
                        break;
                    case CoordinatePosition.B1:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        square.Piece = new Piece();
                        square.Piece.Player = player1;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Knight;
                        break;
                    case CoordinatePosition.C1:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        square.Piece = new Piece();
                        square.Piece.Player = player1;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Bishop;
                        break;
                    case CoordinatePosition.D1:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        square.Piece = new Piece();
                        square.Piece.Player = player1;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Queen;
                        break;
                    case CoordinatePosition.E1:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        square.Piece = new Piece();
                        square.Piece.Player = player1;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.King;
                        break;
                    case CoordinatePosition.F1:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        square.Piece = new Piece();
                        square.Piece.Player = player1;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Bishop;
                        break;
                    case CoordinatePosition.G1:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.Black;
                        square.Piece = new Piece();
                        square.Piece.Player = player1;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Knight;
                        break;
                    case CoordinatePosition.H1:
                        square.CoordinatePosition = coordinatePosition;
                        square.Color = Color.White;
                        square.Piece = new Piece();
                        square.Piece.Player = player1;
                        square.Piece.Color = square.Piece.Player.Color;
                        square.Piece.PieceType = PieceType.Rook;
                        break;
                    default:
                        break;
                }
                board.Add(square);
            }

            return board;

        }
        public List<CoordinatePosition> GetPotentialMovesForPiece(int gameId, int pieceId)
        {
            return new List<CoordinatePosition>();
        }
    }
}
