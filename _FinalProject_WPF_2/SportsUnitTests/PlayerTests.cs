using SportsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsUnitTests
{
    [TestClass]
    public class PlayerTests
    {
        Player player;

        public PlayerTests()
        {
            player = new Player();
        }

        [TestMethod]
        public void PlayerIsAIPlayer()
        {
            Assert.IsInstanceOfType(player, typeof(IPlayer));
        }

        //Credit: Jeff Meyers
        // Explanation of benefits/Reasons of using Loops in tests.
        [TestMethod]
        public void PlayerIDIsUnique()
        {
            List<IPlayer> players = new List<IPlayer>();

            players.Add(new Player());
            players.Add(new Player());
            players.Add(new Player("Sam", 1));
            players.Add(new Player("Jim", 2));

            foreach(Player x in players)
            {
                foreach(Player y in players)
                {
                    if (x !=y)
                    {
                        Assert.AreNotEqual(x.ID, y.ID);
                    }
                }
            }
        }

        [TestMethod]
        public void UpdatePlayerInformation()
        {
            string prevName = player.Name;
            int prevNum = player.Number;

            string newName = "Sam";
            int newNum = 3;

            player.UpdateName(newName);
            player.UpdateNumber(newNum);

            Assert.AreEqual(player.Name, newName);
            Assert.AreEqual(player.Number, newNum);
            Assert.AreNotEqual(player.Name, prevName);
            Assert.AreNotEqual(player.Number, prevNum);
        }

    }
}
