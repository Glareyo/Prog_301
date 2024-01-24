using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLibrary.Repos
{
    public class TeamsRepo: IRepo
    {
        public List<ITeam> TeamsList { get; set; }

        public TeamsRepo()
        {
            TeamsList = new List<ITeam>();
        }

        public string AddTeam(ITeam team)
        {
            TeamsList.Add(team);
            return $"Adding {team.Name}";
        }
        public string RemoveTeam(ITeam team)
        {
            TeamsList.Remove(team);
            return $"Removing {team.Name}";
        }
    }
}
