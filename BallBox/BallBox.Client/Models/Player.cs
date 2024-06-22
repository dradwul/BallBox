namespace BallBox.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Team Team { get; set; }
        public int Number { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public int Overall { get; set; }
        public int Attacking { get; set; }
        public int Defending { get; set; }
        public int Speed { get; set; }
        public int Dribbling { get; set; }
        public int Passing { get; set; }
        public int Shooting { get; set; }
        public int Goalkeeping { get; set; } = 0;
        public int Physical { get; set; }
        public double ChanceToScoreModifyer { get; set; }   // TODO: Remove this and
                                                            // replace with other stats
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int GoalsCurrentMatch { get; set; }
    }
}
