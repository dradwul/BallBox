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
	public class TeamController : ControllerBase
	{
		private readonly TeamRepository _teamRepository;
		public TeamController(TeamRepository teamRepository)
		{
			_teamRepository = teamRepository;
		}

        [HttpPost]
        public async Task<IActionResult> CreateTeamAsync([FromBody] Team team)
        {
            if (team == null)
            {
                return BadRequest("Team cannot be null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _teamRepository.AddTeamAsync(team);
                return Ok();
            }
            catch (Exception ex)
            {
                // Log the exception (consider using a logging framework)
                Console.WriteLine($"Error creating team: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet]
		public async Task<ActionResult<List<Team>>> GetTeamsAsync()
		{
			var teams = await _teamRepository.GetTeamsAsync();
			return Ok(teams);
		}

		[HttpGet("count")]
		public async Task<ActionResult<int>> GetTeamCountAsync()
		{
			var count = await _teamRepository.GetTeamCountAsync();
			return Ok(count);
		}
	}
}
