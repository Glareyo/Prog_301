namespace SportsLibrary
{
    public interface IHasTeams
    {
        public List<ITeam> Teams { get; set; }

        public int MaxTeams { get; }

        string AddTeam(ITeam team);
        string RemoveTeam(ITeam team);
    }
}
