using BallBox.Client.Models;
using Microsoft.EntityFrameworkCore;

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

        public Task<List<Player>> GetPlayersAsync()
        {
            return _context.Players.ToListAsync();
        }

        public async Task<int> GetPlayerCountAsync()
        {
            return await _context.Players.CountAsync();
        }
    }
}
