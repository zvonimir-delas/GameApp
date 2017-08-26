using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Data.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TournamentsWon { get; set; }
        public DateTime? LastTournamentWonDate { get; set; }
        public string LogoAnimalName { get; set; }

        public List<Player> Players { get; set; }
    }
}
