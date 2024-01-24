using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLibrary.Interfaces
{
    public interface IHasMatches
    {
        int MaxNumOfMatches { get; set; }
        List<IMatch> Matches { get; set; }

        string AddMatch(IMatch match);
        string UpdateMatchScore(IMatch match, int score);
        string UpdateMatchResult(IMatch match, string result);
    }
}
