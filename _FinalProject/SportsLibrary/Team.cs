using SportsLibrary.Interfaces;
using SportsLibrary.Interfaces.StatsInterfaces;

namespace SportsLibrary
{
    public class Team : ITeam, IHasStats
    {
        public Team()
        {
            Players = new List<IPlayer>();
            Name = "Team1";
            Description = "This is Team 1";
        }
        public Team(string name, string description)
        {
            Players = new List<IPlayer>();
            Name = name;
            Description = description;
        }
        public Team(string name, string description, List<IPlayer> players)
        {
            Players = players;
            Name = name;
            Description = description;
        }


        public string Name { get; set; }
        public string Description { get; set; }
        public List<IPlayer> Players { get; }
        public List<IMatch> Matches { get; set; }
        public List<IStats> Stats { get; set; }

        public string AddPlayer(IPlayer player)
        {
            Players.Add(player);
            return $"Added {player.Name}";
        }

        public string RemovePlayer(IPlayer player)
        {
            Players.Remove(player);
            return $"Removing {player.Name}";
        }

        public string AddStats(IStats Stats)
        {
            throw new NotImplementedException();
        }
        public string UpdateStats(IStats stat, int newStatNum)
        {
            throw new NotImplementedException();
        }
    }
}
