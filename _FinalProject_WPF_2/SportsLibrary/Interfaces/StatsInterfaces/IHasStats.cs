using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLibrary.Interfaces.StatsInterfaces
{
    public interface IHasStats
    {
        public List<IStats> Stats { get; set; }
        public string AddStats(IStats Stats);
        public string UpdateStats(IStats stat, int newStatNum);
    }
}
