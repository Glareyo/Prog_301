using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLibrary.Sports
{
    public class TeamSport : Sport, IHasTeams
    {
        public TeamSport()
        {
            MaxTeams = 0;
            Teams = new List<ITeam>();
        }

        public List<ITeam> Teams { get; set; }
        public int MaxTeams { get; set; }
        public string AddTeam(ITeam team)
        {
            Teams.Add(team);
            return $"Adding {team.Name}";
        }
        public string RemoveTeam(ITeam team)
        {
            Teams.Remove(team);
            return $"Remove {team.Name}";
        }
    }
}
