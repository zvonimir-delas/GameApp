using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameApp.Data;
using GameApp.Data.Models;
using System.Data.Entity;

namespace GameApp.Domain
{
    public class GameAppRepository
    {
        public Team GetTeamByName(string name, string logoAnimalName = null)
        {
            using (var context = new GameAppContext())
            {
                var GetAllTeamsQuery = context.Teams;

                //query depends on whether logoAnimalName was specified upon calling or not (used for creating new team)
                return (logoAnimalName == null) ? GetAllTeamsQuery.Where(x => x.Name == name).FirstOrDefault() : GetAllTeamsQuery.Where(x => x.Name == name || x.LogoAnimalName == logoAnimalName).FirstOrDefault();
            }
        }

        public Player GetPlayerByName(string firstName, string lastName)
        {
            using (var context = new GameAppContext())
            {
                return context.Players.Where(x => x.FirstName == firstName && x.LastName == lastName).FirstOrDefault();
            }
        }

        public string CreateNewPlayer(string firstName, string lastName, string phoneNumber, string email)
        {
            using (var context = new GameAppContext())
            {
                if (GetPlayerByName(firstName, lastName) == null)
		            return "Player already exists";

                context.Players.Add(new Player()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    PhoneNumber = phoneNumber,
                    Email = email
                });

                context.SaveChanges();

                return "Player added";
            }
        }

        public string AddNewTeam(string name, string logoAnimalName)
        {
            using (var context = new GameAppContext())
            {
                if (GetTeamByName(name, logoAnimalName) == null)
                    return "Team already exists";

                context.Teams.Add(new Team()
                {
                    Name = name,
                    LogoAnimalName = logoAnimalName,
                    TournamentsWon = 0,
                    LastTournamentWonDate = null
                });
                context.SaveChanges();

                return "Team added";
            }
        }

        public string AddPlayerToTeam(string firstName, string lastName, string nameOfTeam)
        {
            using (var context = new GameAppContext())
            {
                var player = GetPlayerByName(firstName, lastName);
                var team = GetTeamByName(nameOfTeam);

                if (player == null || team == null)
			        return "Player or team does not exist";

                if (team.Players.Count() >= 5)
                    return "Too many players in the team";
                if (player.Team != null)
                    return "Player already has a team";

                player.Team = context.Teams.Where(x => x.Name == nameOfTeam).FirstOrDefault();

                context.Entry(player).State = EntityState.Modified;
                context.SaveChanges();

                return "Player added";
            }
        }

        public string RemovePlayerFromTeam(string firstName, string lastName)
        {
            using (var context = new GameAppContext())
            {
                var player = GetPlayerByName(firstName, lastName);

                if (GetPlayerByName(firstName, lastName) == null)
			        return "Player does not exist";

                player.Team = null;

                context.Entry(player).State = EntityState.Modified;
                context.SaveChanges();

                return "Player removed from team";
            }
        }

        public string CreateNewMatch(string nameOfTeam1, string nameOfTeam2, string matchName)
        {
            using (var context = new GameAppContext())
            {

                var team1 = GetTeamByName(nameOfTeam1);
                var team2 = GetTeamByName(nameOfTeam2);

                if (team1 == null || team2 == null)
                    return "Team(s) do(es) not exist";

                context.Matches.Add(new Match()
                {
                    Name = matchName,
                    Team1 = team1,
                    Team2 = team2,
                    IsTournamentMatch = false
                });
                context.SaveChanges();

                return "Match created";
            }
        }



    }
}
