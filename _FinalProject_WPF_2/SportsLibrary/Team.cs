using SportsLibrary.Interfaces;
using SportsLibrary.Interfaces.StatsInterfaces;
using SportsLibrary.Sports;

namespace SportsLibrary
{
    public class Team : ITeam, IHasStats
    {
        public Team()
        {
            ID = teamCount++;
            Players = new List<IPlayer>();
            Name = $"Team{ID}";
            Description = $"This is Team {ID}";
            PlayingSport = new Baseball();
        }
        public Team(string name, string description)
        {
            ID = teamCount++;
            Players = new List<IPlayer>();
            Name = name;
            Description = description;
            PlayingSport = new Baseball();
        }
        public Team(string name, string description, List<IPlayer> players)
        {
            ID = teamCount++;
            Players = players;
            Name = name;
            Description = description;
            PlayingSport = new Baseball();
        }
        public Team(string name, string description, List<IPlayer> players, ISport playingSport)
        {
            ID = teamCount++;
            Players = players;
            Name = name;
            Description = description;
            PlayingSport = playingSport;
        }

        public static int teamCount;

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<IPlayer> Players { get; }
        public List<IMatch> Matches { get; set; }
        public List<IStats> Stats { get; set; }
        public ISport PlayingSport { get; set; }

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
