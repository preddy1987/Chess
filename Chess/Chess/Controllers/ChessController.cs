using Microsoft.AspNetCore.Mvc;

namespace ChessAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChessController : Controller
    {
        [HttpGet(Name = "GetChess")]
        public string Get()
        {
            return "hello";
        }
    }
}
