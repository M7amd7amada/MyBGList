using Microsoft.AspNetCore.Mvc;
using MyBGList.Api.Models;

namespace MyBGList.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BoardGameController : ControllerBase
{
    private readonly ILogger<BoardGameController> _logger;
    public BoardGameController(ILogger<BoardGameController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetBoardGames")]
    [Route("GetBoardGames")]
    public IEnumerable<BoardGame> GetBoardGames()
    {
        return new[] {
            new BoardGame {
                Id = 1,
                Name = "Chess",
                Year = 2002
            },
            new BoardGame {
                Id = 2,
                Name = "Puzzle",
                Year = 2003
            },
            new BoardGame {
                Id = 3,
                Name = "Checkers",
                Year = 2004
            }
        };
    }
}