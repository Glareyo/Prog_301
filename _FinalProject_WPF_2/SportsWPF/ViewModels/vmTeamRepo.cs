using SportsLibrary;
using SportsLibrary.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsWPF.ViewModels
{
    public class vmTeamRepo
    {
        public TeamsRepo repo { get; set; }

        public vmTeamRepo(TeamsRepo _repo)
        {
            this.repo = _repo;
        }

        public List<ITeam> TeamsList
        {
            get { return repo.TeamsList; }
        }
    }
}
