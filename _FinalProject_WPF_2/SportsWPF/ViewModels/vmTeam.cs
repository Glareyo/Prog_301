using SportsLibrary.Interfaces.StatsInterfaces;
using SportsLibrary.Interfaces;
using SportsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsWPF.ViewModels
{
    public class vmTeam : vmBase
    {
        public ITeam Team;

        public vmTeam(ITeam team)
        {
            Team = team;
        }

        public int TeamID 
        { 
            get { return Team.ID; }
            set
            {
                Team.ID = value;
                OnPropertyChanged();
            }
        }
        public string TeamName
        {
            get { return Team.Name; }
            set
            {
                Team.Name = value;
                OnPropertyChanged();
            }
        }
        public string TeamDescription
        {
            get { return Team.Description; }
            set
            {
                Team.Description = value;
                OnPropertyChanged();
            }
        }
        public List<IPlayer> Players { get; }
        public List<IMatch> Matches { get; set; }
        public List<IStats> Stats { get; set; }
        public ISport PlayingSport { get; set; }
    }
}
