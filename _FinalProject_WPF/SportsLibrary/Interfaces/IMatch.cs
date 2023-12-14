using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLibrary.Interfaces
{
    //Interface for IMatches
    public interface IMatch
    {
        public List<ITeam> Teams { get; set; }
        public DateOnly MatchDate { get; set; }
        public TimeOnly MatchTime { get; set; }

        public List<int> Score { get; set; }
        public string Result { get; set; }

        public string UpdateScore(int score);
        public string UpdateResult(string result);
        public string DisplayInformation();
    }
}
