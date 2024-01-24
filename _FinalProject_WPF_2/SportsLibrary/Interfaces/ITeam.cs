using SportsLibrary.Interfaces;

namespace SportsLibrary
{
    public interface ITeam
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public ISport PlayingSport { get; set; }
        
        public List<IPlayer> Players { get; }

        public List<IMatch> Matches { get; set; }

        public string AddPlayer(IPlayer player);
        public string RemovePlayer(IPlayer player);
    }
}
