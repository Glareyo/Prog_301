using SportsLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLibrary
{
    public class Match : IMatch
    {
        public Match(List<ITeam> _Teams)
        {
            Teams = _Teams;
            MatchDate = DateOnly.FromDateTime(DateTime.Now);
            MatchTime = TimeOnly.FromDateTime(DateTime.Now);

            Score = new List<int>();
            Result = "Undetermined";
        }


        public List<ITeam> Teams { get; set; }
        public DateOnly MatchDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public TimeOnly MatchTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<int> Score { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Result { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string DisplayInformation()
        {
            throw new NotImplementedException();
        }

        public string UpdateResult(string result)
        {
            throw new NotImplementedException();
        }

        public string UpdateScore(int score)
        {
            throw new NotImplementedException();
        }
    }
}
