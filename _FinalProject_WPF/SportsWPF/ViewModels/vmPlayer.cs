using SportsLibrary;
using SportsLibrary.Interfaces.StatsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsWPF.ViewModels
{
    public class vmPlayer : vmBase
    {
        IPlayer player;

        public vmPlayer()
        {
            player = new Player();
        }

        public IPlayer Player
        {
            get {  return player; }
            set
            {
                player = value;
                OnPropertyChanged();
            }
        }

        public string Name 
        { 
            get { return player.Name; }
            set
            {
                player.Name = value;
                OnPropertyChanged();
            }
        }

        public int Number 
        {
            get { return player.Number; } 
            set 
            { 
                player.Number = value; 
                OnPropertyChanged(); 
            } 
        }

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
    }
}
