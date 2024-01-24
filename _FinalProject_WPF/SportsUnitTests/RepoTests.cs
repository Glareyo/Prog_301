using SportsLibrary;
using SportsLibrary.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsUnitTests
{
    [TestClass]
    public class RepoTests
    {
        PlayersRepo playersRepo;
        TeamsRepo teamsRepo;

        public RepoTests()
        {
            playersRepo = new PlayersRepo();
            teamsRepo = new TeamsRepo();
        }



        [TestMethod]
        public void AddingToRepos()
        {
            Player Bob = new Player("Bob", 3);
            Player Sam = new Player("Sam", 2);
            Player Jack = new Player("Jack", 6);
            Player Jon = new Player("Jon", 1);
            Player Mark = new Player("Mark", 10);
            Player Nick = new Player("Nick", 14);

            List<IPlayer> playerList1 = new List<IPlayer> { Bob, Sam, Jack };
            List<IPlayer> playerList2 = new List<IPlayer> { Jon, Mark, Nick };

            Team team1 = new Team("Team 1", "Team 1", playerList1);
            Team team2 = new Team("Team 2", "Team 2", playerList2);

            playersRepo.PlayersList.Clear();
            teamsRepo.TeamsList.Clear();

            playersRepo.AddPlayer(Nick);
            playersRepo.AddPlayer(Bob);
            playersRepo.AddPlayer(Sam);
            playersRepo.AddPlayer(Mark);
            playersRepo.AddPlayer(Jon);
            playersRepo.AddPlayer(Jack);

            teamsRepo.AddTeam(team1);
            teamsRepo.AddTeam(team2);

            Assert.AreEqual(playersRepo.PlayersList.Count, 6);
            Assert.AreEqual(teamsRepo.TeamsList.Count, 2);
        }

        [TestMethod]
        public void RemoveFromRepos()
        {
            Player Bob = new Player("Bob", 3);
            Player Sam = new Player("Sam", 2);
            Player Jack = new Player("Jack", 6);
            Player Jon = new Player("Jon", 1);
            Player Mark = new Player("Mark", 10);
            Player Nick = new Player("Nick", 14);

            List<IPlayer> playerList1 = new List<IPlayer> { Bob, Sam, Jack };
            List<IPlayer> playerList2 = new List<IPlayer> { Jon, Mark, Nick };

            Team team1 = new Team("Team 1", "Team 1", playerList1);
            Team team2 = new Team("Team 2", "Team 2", playerList2);

            playersRepo.PlayersList.Clear();
            teamsRepo.TeamsList.Clear();

            playersRepo.AddPlayer(Nick);
            playersRepo.AddPlayer(Bob);
            playersRepo.AddPlayer(Sam);
            playersRepo.AddPlayer(Mark);
            playersRepo.AddPlayer(Jon);
            playersRepo.AddPlayer(Jack);

            teamsRepo.AddTeam(team1);
            teamsRepo.AddTeam(team2);

            playersRepo.RemovePlayer(Nick);
            playersRepo.RemovePlayer(Jack);

            teamsRepo.RemoveTeam(team2);

            Assert.AreEqual(playersRepo.PlayersList.Count, 4);
            Assert.AreEqual(teamsRepo.TeamsList.Count, 1);
        }

        [TestMethod]
        public void AreIRepos()
        {
            Assert.IsInstanceOfType(playersRepo, typeof(IRepo));
            Assert.IsInstanceOfType(teamsRepo, typeof(IRepo));
        }
    }
}
