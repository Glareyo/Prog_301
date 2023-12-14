using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsLibrary.Interfaces.StatsInterfaces
{
    public interface IStats
    {
        public string StatName { get; set; }
        public int Stat { get; set; }

        public string UpdateStats(int stat, bool addStat);
    }
}
