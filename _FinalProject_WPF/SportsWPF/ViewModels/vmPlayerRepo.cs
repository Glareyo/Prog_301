using SportsLibrary;
using SportsLibrary.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsWPF.ViewModels
{
    public class vmPlayerRepo : vmBase
    {
        public PlayersRepo playerRepo;

        public vmPlayerRepo()
        {
            playerRepo = new PlayersRepo();
        }


        public List<IPlayer> PlayersList 
        { 
            get { return playerRepo.PlayersList; }
        }
    }
}
