using SportsLibrary.Interfaces.StatsInterfaces;

namespace SportsLibrary
{
    public class Player : IPlayer, IHasStats
    {
        public Player()
        {
            ID = playerCount++;
            Name = "Bob";
            Number = 1;
        }
        public Player(string name, int number)
        {
            ID = playerCount++;
            Name = name;
            Number = number;
        }
        public Player(string name, int number, ITeam playingTeam)
        {
            ID = playerCount++;
            Name = name;
            Number = number;
            PlayingTeam = playingTeam;
        }

        public static int playerCount;

        public int ID { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public List<IStats> Stats { get; set; }
        public ITeam PlayingTeam { get; set; }

        public string UpdateNumber(int number)
        {
            Number = number;
            return $"{Name}'s Number Changed to {Number}";
        }
        public string UpdateName(string name)
        {
            Name = name;
            return $"Player is now {Name}";
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
