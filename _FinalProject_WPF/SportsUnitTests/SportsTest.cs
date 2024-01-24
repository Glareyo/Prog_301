using SportsLibrary;
using SportsLibrary.Sports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsUnitTests
{
    [TestClass]
    public class SportsTest
    {
        Baseball baseball;
        MMA mma;

        ITeam team1;
        ITeam team2;
        ITeam team3;

        IPlayer Bob;
        IPlayer Jacob;
        IPlayer Sam;

        public SportsTest()
        {
            baseball = new Baseball();
            mma = new MMA();

            Bob = new Player("Bob",5);
            Jacob = new Player("Jacob",7);
            Sam = new Player("Sam",1);
        }

        [TestMethod]
        public void IsAISport()
        {
            Assert.IsInstanceOfType(baseball, typeof(ISport));
            Assert.IsInstanceOfType(mma, typeof(ISport));
        }

        [TestMethod]
        public void AddTeamToSport()
        {
            List<ITeam> temps = new List<ITeam>();
            temps.Add(new Team("Team A","Team A"));
            temps.Add(new Team("Team B","Team B"));

            temps[0].AddPlayer(Bob);
            temps[0].AddPlayer(Sam);
            temps[1].AddPlayer(Jacob);

            string result1 = baseball.AddTeam(temps[0]);
            string result2 = baseball.AddTeam(temps[1]);

            Assert.AreEqual(baseball.Teams.Count, 2);
            Assert.AreEqual(baseball.MaxTeams, 2);

            Assert.AreEqual(result1, "Team A Added");
            Assert.AreEqual(result2, "Team B Added");
        }
        [TestMethod]
        public void RemoveTeamFromSport()
        {
            List<ITeam> temps = new List<ITeam>();
            temps.Add(new Team("Team A", "Team A"));
            temps.Add(new Team("Team B", "Team B"));

            temps[0].AddPlayer(Bob);
            temps[0].AddPlayer(Sam);
            temps[1].AddPlayer(Jacob);

            baseball.AddTeam(temps[0]);
            baseball.AddTeam(temps[1]);

            string result = baseball.RemoveTeam(temps[0]);

            Assert.AreEqual(baseball.Teams.Count, 1);
            Assert.AreEqual(result, "Team A Removed");
        }
        [TestMethod]
        public void MaxTeamsReached()
        {
            List<ITeam> temps = new List<ITeam>();
            temps.Add(new Team("Team A", "Team A"));
            temps.Add(new Team("Team B", "Team B"));
            temps.Add(new Team("Team C", "Team C"));

            temps[0].AddPlayer(Bob);
            temps[0].AddPlayer(Sam);
            temps[1].AddPlayer(Jacob);
            temps[2].AddPlayer(new Player("Jack", 4));

            baseball.AddTeam(temps[0]);
            baseball.AddTeam(temps[1]);

            string result = baseball.AddTeam(temps[2]);

            Assert.AreEqual(baseball.Teams.Count, 2);
            Assert.AreEqual(result, "Unable to add Team C");
        }
    }
}
