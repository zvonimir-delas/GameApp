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
        public List<Tournament> TournamentsWon { get; set; }
        public DateTime LastTournamentWonDate { get; set; }
    }
}
