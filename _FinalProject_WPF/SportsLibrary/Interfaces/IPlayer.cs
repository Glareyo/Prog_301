namespace SportsLibrary
{
    public interface IPlayer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public ITeam PlayingTeam { get; set; }

        public string UpdateNumber(int number);
        public string UpdateName(string name);
    }
}
