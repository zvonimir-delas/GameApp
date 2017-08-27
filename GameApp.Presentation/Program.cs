using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameApp.Domain;

namespace GameApp.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameAppRepository = new GameAppRepository();

            while (true)
            {
                Console.WriteLine("1) Add new player\n 2) Add new team\n 3) Add player to team\n 4) Remove player from team\n 5) Create a new match\n 6) Create a new tournament");

                int optionChosen = int.Parse(Console.ReadLine());

                if (optionChosen == 1)
                {
                    Console.WriteLine(WriteInputRequest("first name, last name, phone number, email"));

                    string firstName = Console.ReadLine();
                    string lastName = Console.ReadLine();
                    string phoneNumber = Console.ReadLine();
                    string email = Console.ReadLine();

                    Console.WriteLine(gameAppRepository.CreateNewPlayer(firstName, lastName, phoneNumber, email));
                }

                else if (optionChosen == 2)
                {
                    Console.WriteLine(WriteInputRequest("name, logo animal name"));

                    string name = Console.ReadLine();
                    string logoAnimalName = Console.ReadLine();

                    Console.WriteLine(gameAppRepository.AddNewTeam(name, logoAnimalName));
                }

                else if (optionChosen == 3)
                {
                    Console.WriteLine(WriteInputRequest("first name, last name, name of team"));

                    string firstName = Console.ReadLine();
                    string lastName = Console.ReadLine();
                    string nameOfTeam = Console.ReadLine();

                    Console.WriteLine(gameAppRepository.AddPlayerToTeam(firstName, lastName, nameOfTeam));
                }

                else if (optionChosen == 4)
                {
                    Console.WriteLine(WriteInputRequest("first name, last name"));

                    string firstName = Console.ReadLine();
                    string lastName = Console.ReadLine();

                    Console.WriteLine(gameAppRepository.RemovePlayerFromTeam(firstName, lastName));
                }

                else if (optionChosen == 5)
                {
                    Console.WriteLine(WriteInputRequest("name of team 1, name of team 2, name of match"));

                    string nameOfTeam1 = Console.ReadLine();
                    string nameOfTeam2 = Console.ReadLine();
                    string nameOfMatch = Console.ReadLine();

                    Console.WriteLine(gameAppRepository.CreateNewMatch(nameOfTeam1, nameOfTeam2, nameOfMatch));
                }

                else if (optionChosen == 6)
                {
                    Console.WriteLine(WriteInputRequest("name, name of team 1, name of team 2, name of team 3, name of team 4, name of match 1, name of match 2"));

                    string name = Console.ReadLine();
                    string nameOfTeam1 = Console.ReadLine();
                    string nameOfTeam2 = Console.ReadLine();
                    string nameOfTeam3 = Console.ReadLine();
                    string nameOfTeam4 = Console.ReadLine();
                    string nameOfMatch1 = Console.ReadLine();
                    string nameOfMatch2 = Console.ReadLine();

                    Console.WriteLine(gameAppRepository.CreateNewTournament(name, nameOfTeam1, nameOfTeam2, nameOfTeam3, nameOfTeam4, nameOfMatch1, nameOfMatch2));
                }
            }
        }

        public static string WriteInputRequest(string inputNeeded)
        {
            return $"Specify {inputNeeded} (each in a separate line)";
        }

    }
}
