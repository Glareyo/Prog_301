using SportsLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLibrary.Sports
{
    public abstract class Sport : ISport, IHasTeams,IHasMatches
    {
        public Sport()
        {
            Teams = new List<ITeam>();
            Matches = new List<IMatch>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public List<ITeam> Teams { get; set; }
        public int MaxTeams { get; set; }
        public int MaxNumOfMatches { get; set; }
        public List<IMatch> Matches { get; set; }

        public string AddMatch(IMatch match)
        {
            throw new NotImplementedException();
        }

        public string AddTeam(ITeam team)
        {//Add team if max team is not exceeding
            if (Teams.Count < MaxTeams)
            {
                Teams.Add(team);
                return (team.Name + " Added");
            }
            return ("Unable to add " + team.Name);
        }

        public string RemoveTeam(ITeam team)
        {
            Teams.Remove(team);
            return team.Name + "Removed";
        }

        public string UpdateMatchResult(IMatch match, string result)
        {
            match.UpdateResult(result);
            return ("Match Updated");
        }

        public string UpdateMatchScore(IMatch match, int score)
        {
            match.UpdateScore(score);
            return ("Match Updated");
        }
    }
}
