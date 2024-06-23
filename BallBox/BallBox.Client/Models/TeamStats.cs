using System.ComponentModel.DataAnnotations;

namespace BallBox.Client.Models
{
    public class TeamStats
    {
        [Key]
        public int Id { get; set; }
        public int Goals { get; set; }
        public int ShotsOnGoal { get; set; }
        public int RedCards { get; set; }
        public int YellowCards { get; set; }
    }
}
