using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Data.Models
{
    public class Match
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public enum Round { final, half final, qualification }
        public bool IsTournamentMatch { get; set; }

        public Team team1 { get; set; }
        public Team team2 { get; set; }
    }

}
