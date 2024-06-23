using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BallBox.Client.Models
{
    public class Match
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("HomeTeam")]
        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }
        public TeamStats HomeTeamStats { get; set; }

        [ForeignKey("AwayTeam")]
        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }
        public TeamStats AwayTeamStats { get; set; }

        public int CurrentMatchMinute { get; set; }
        public int TotalMatchMinutes { get; set; }
    }
}
