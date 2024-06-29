using System.ComponentModel.DataAnnotations;

namespace BallBox.Client.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public int Overall { get; set; }
        public int Attacking { get; set; }
        public int Defending { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsConceded { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }

        public List<Player> Players { get; set; } = new();

        public int CalculateTeamOverall()
        {
            if (Players.Count == 0) return 0;
            return Players.Sum(p => p.Overall) / Players.Count;
        }
    }
}
