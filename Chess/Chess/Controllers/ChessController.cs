using ChessAPI.Models;
using ChessAPI.Services;
using ChessAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChessAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChessController : Controller
    {
        private readonly IChessService _cs;

        public ChessController(IChessService chessService)
        {
            _cs = chessService;
        }

        //[HttpGet("{gameId}")]
        [HttpGet]
        public async Task<ActionResult<Chess>> GetGameState(int gameId)
        {      
            return await _cs.GetGameState(gameId);
        }
    }
}
