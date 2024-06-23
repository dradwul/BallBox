using BallBox.Client.Models;

namespace BallBox.Data.Repositories
{
	public class PlayerRepository
	{
		private readonly BallBoxDbContext _context;
		public PlayerRepository(BallBoxDbContext context)
		{
			_context = context;
		}

		public async Task AddPlayerAsync(Player player)
		{
			await _context.Players.AddAsync(player);
			await _context.SaveChangesAsync();
		}
	}
}
