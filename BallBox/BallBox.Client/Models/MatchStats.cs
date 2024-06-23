using System.ComponentModel.DataAnnotations;

namespace BallBox.Client.Models
{
    public class MatchStats
    {
        [Key]
        public int Id { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int YellowCards { get; set; }
        public int RedCard {  get; set; }
    }
}
