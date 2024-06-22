namespace BallBox.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Overall { get; set; }
        public int Attacking { get; set; }
        public int Defending { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsConceded { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
        public List<Player> Players { get; set; }
    }
}
