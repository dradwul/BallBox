using BallBox.Client.Models;
using BallBox.Data.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BallBox.API.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly PlayerRepository _playerRepository;
        public PlayerController(PlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Player>>> PostPlayers(IEnumerable<Player> players)
        {
            foreach(var player in players)
            {
                await _playerRepository.AddPlayerAsync(player);
            }

            return Ok(players);
        }

        [HttpGet]
        public async Task<ActionResult<List<Player>>> GetPlayersAsync()
        {
            var players = await _playerRepository.GetPlayersAsync();
            return Ok(players);
        }

        [HttpGet("count")]
        public async Task<ActionResult<int>> GetPlayerCountAsync()
        {
            var count = await _playerRepository.GetPlayerCountAsync();
            return Ok(count);
        }
    }
}
