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
        }

        List<IPlayer> PlayersList;
    }
}
