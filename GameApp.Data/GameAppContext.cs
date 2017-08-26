using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GameApp.Data.Models;

namespace GameApp.Data
{
    public class GameAppContext : DbContext
    {
        public GameAppContext() : base()
        {
            Database.SetInitializer(new GameAppInitializer());
        }

        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Tournament> Tournaments { get; set; }
    }
}
