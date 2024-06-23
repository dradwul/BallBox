using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BallBox.Client.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Team")]
        public int TeamId { get; set; }
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
        public int Goalkeeping { get; set; }
        public int Physical { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }

        public MatchStats CurrentMatchStats { get; set; } = new();
    }
}
