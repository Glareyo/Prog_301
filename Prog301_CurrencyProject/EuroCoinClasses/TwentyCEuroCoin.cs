using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prog301_CurrencyProject.USCoin;
using System.Xml.Linq;

namespace Prog301_CurrencyProject.EuroCoinClasses
{
    public class TwentyCEuroCoin : EuroCoin
    {
        public TwentyCEuroCoin() : base()
        {
            MonetaryValue = 0.2;
            Name = "20c Euro Coin";
        }
    }
}
