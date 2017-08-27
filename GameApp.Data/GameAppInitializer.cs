using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GameApp.Data.Models;

namespace GameApp.Data
{
    public class GameAppInitializer : DropCreateDatabaseIfModelChanges<GameAppContext>
    {
        protected override void Seed(GameAppContext context)
        {
            // creating new teams
            var team1 = new Team()
            {
                Name = "Prvi tim",
                LogoAnimalName = "Macka",
                TournamentsWon = 0,
                LastTournamentWonDate = null
            };

            var team2 = new Team()
            {
                Name = "Drugi tim",
                LogoAnimalName = "Vjeverica",
                TournamentsWon = 0,
                LastTournamentWonDate = null
            };

            var team3 = new Team()
            {
                Name = "Treci tim",
                LogoAnimalName = "Medvjed",
                TournamentsWon = 0,
                LastTournamentWonDate = null
            };

            var team4 = new Team()
            {
                Name = "Cetvrti tim",
                LogoAnimalName = "Kornjača",
                TournamentsWon = 0,
                LastTournamentWonDate = null
            };

            // creating new players
            var player1 = new Player()
            {
                FirstName = "Mate",
                LastName = "Matic",
                PhoneNumber = "097856413222",
                Email = "mate.matic@yahoo.com",
                Team = team1
            };

            var player2 = new Player()
            {
                FirstName = "Ante",
                LastName = "Antic",
                PhoneNumber = "0965874239",
                Email = "ante.antic@gmail.com",
                Team = team2
            };

            var player3 = new Player()
            {
                FirstName = "Goran",
                LastName = "Jurić",
                PhoneNumber = "09248924537",
                Email = "5zroh@10-minute-mail.com",
                Team = team3
            };

            var player4 = new Player()
            {
                FirstName = "Jure",
                LastName = "Jurić",
                PhoneNumber = "0924892842",
                Email = "jure250@gmail.com",
                Team = team4
            };

            // creating new matches
            var match1 = new Match()
            {
                Name = "Prvi match",
                Team1 = team1,
                Team2 = team2,
                IsTournamentMatch = false
            };

            var match2 = new Match()
            {
                Name = "Drugi match",
                Team1 = team1,
                Team2 = team2,
                IsTournamentMatch = true,
                Round = Round.halffinal
            };

            var match3 = new Match()
            {
                Name = "Treci match",
                Team1 = team3,
                Team2 = team4,
                IsTournamentMatch = true,
                Round = Round.halffinal
            };

            var match4 = new Match()
            {
                Name = "Cetvrti match",
                Team1 = team1,
                Team2 = team2,
                IsTournamentMatch = true,
                Round = Round.final
            };

            // creating a tournament
            var tournament1 = new Tournament()
            {
                StartDate = DateTime.Now,
                Name = "World Cup",
                Matches = new List<Match>() { match2, match3, match4 }
            };
            
            context.Teams.Add(team1);
            context.Teams.Add(team2);
            context.Teams.Add(team3);
            context.Teams.Add(team4);

            context.Players.Add(player1);
            context.Players.Add(player2);
            context.Players.Add(player3);
            context.Players.Add(player4);

            context.Matches.Add(match1);
            context.Matches.Add(match2);
            context.Matches.Add(match3);
            context.Matches.Add(match4);

            context.Tournaments.Add(tournament1);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
