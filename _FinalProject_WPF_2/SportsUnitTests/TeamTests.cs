using SportsLibrary;
using System.Numerics;

namespace SportsUnitTests
{
    [TestClass]
    public class TeamTests
    {
        Team team;

        Player Bob;
        Player Sam;
        Player Alex;


        public TeamTests()
        {
            team = new Team();

            Bob = new Player("Bob", 3);
            Sam = new Player("Sam", 5);
            Alex = new Player("Alex", 2);
        }

        [TestMethod]
        public void TeamIsAITeam()
        {
            Assert.IsInstanceOfType(team, typeof(ITeam));
        }

        [TestMethod]
        public void AddPlayer()
        {
            string addBob = team.AddPlayer(Bob);
            string addSam = team.AddPlayer(Sam);
            string addAlex = team.AddPlayer(Alex);

            Assert.AreEqual(team.Players.Count, 3);
            Assert.AreEqual(addBob, "Added Bob");
            Assert.AreEqual(addSam, "Added Sam");
            Assert.AreEqual(addAlex, "Added Alex");
        }

        [TestMethod]
        public void RemovePlayer()
        {
            team.AddPlayer(Bob);
            team.AddPlayer(Sam);
            team.AddPlayer(Alex);

            string removeBob = team.RemovePlayer(Bob);

            Assert.AreEqual(team.Players.Count, 2);
            Assert.AreEqual(removeBob, "Removing Bob");
        }

        [TestMethod]
        public void InstatiatingTeam_NoPlayers()
        {
            string name = "A-Team";
            string description = "This is the A-Team";

            team = new Team(name, description);

            Assert.AreEqual(team.Description, description);
            Assert.AreEqual(team.Name, name);
            Assert.AreEqual(team.Players.Count, 0);
        }

        [TestMethod]
        public void InstatiatingTeam_FullRoster()
        {
            string name = "A-Team";
            string description = "This is the A-Team";

            List<IPlayer> players = new List<IPlayer>();
            players.Add(Bob);
            players.Add(Sam);
            players.Add(Alex);

            team = new Team(name, description,players);

            Assert.AreEqual(team.Description, description);
            Assert.AreEqual(team.Name, name);
            Assert.AreEqual(team.Players.Count, 3);
        }
    }
}