using BallBox.Client.Models;
using Microsoft.EntityFrameworkCore;

namespace BallBox.Data
{
	public class BallBoxDbContext : DbContext
	{
		public BallBoxDbContext(DbContextOptions<BallBoxDbContext> options)
			: base(options) { }

		public DbSet<Player> Players { get; set; }
		public DbSet<Team> Teams { get; set; }
		public DbSet<TeamStats> TeamStats { get; set; }
		public DbSet<Match> Matches { get; set; }
		public DbSet<MatchStats> MatchStats { get; set; }
		public DbSet<Tournament> Tournaments { get; set; }
		public DbSet<League> Leagues { get; set; }
	}
}
