namespace SportsLibrary
{
    public interface ITeam
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<IPlayer> Players { get; }

        public string AddPlayer(IPlayer player);
        public string RemovePlayer(IPlayer player);
    }
}
