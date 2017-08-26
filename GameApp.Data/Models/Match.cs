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
        public enum Round { final, halffinal, qualification }
        public bool IsTournamentMatch { get; set; }

        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
    }

}
