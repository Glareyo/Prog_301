using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLibrary.Repos
{
    public class PlayersRepo : IRepo
    {
        public PlayersRepo()
        {
            PlayersList = new List<IPlayer>();


            PlayersList.Add(new Player("Jacob", 4));
            PlayersList.Add(new Player("Sam", 1));
            PlayersList.Add(new Player("Sara", 6));
        }

        public List<IPlayer> PlayersList { get; set; }

        public string AddPlayer(IPlayer player)
        {
            PlayersList.Add(player);
            return $"Adding {player.Name}";
        }
        public string RemovePlayer(IPlayer player)
        {
            PlayersList.Remove(player);
            return $"Removing {player.Name}";
        }
    }
}
