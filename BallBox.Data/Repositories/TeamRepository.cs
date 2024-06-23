using BallBox.Client.Models;

namespace BallBox.Data.Repositories
{
	public class TeamRepository
	{
		private readonly BallBoxDbContext _context;
		public TeamRepository(BallBoxDbContext context)
		{
			_context = context;
		}

		public async Task AddTeamAsync(Team team)
		{
			await _context.Teams.AddAsync(team);
			await _context.SaveChangesAsync();
		}
	}
}
