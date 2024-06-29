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
			await _teamRepository.AddTeamAsync(team);
			return Ok();
		}

		[HttpGet]
		public IActionResult Get()
		{
			return Ok("API is working");
		}

		[HttpGet("count")]
		public async Task<IActionResult> GetTeamCountAsync()
		{
			var count = await _teamRepository.GetTeamCountAsync();
			return Ok(count);
		}
	}
}
