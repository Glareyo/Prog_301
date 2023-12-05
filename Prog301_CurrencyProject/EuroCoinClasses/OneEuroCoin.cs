using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prog301_CurrencyProject.USCoin;
using System.Xml.Linq;

namespace Prog301_CurrencyProject.EuroCoinClasses
{
    public class OneEuroCoin : EuroCoin
    {
        public OneEuroCoin() : base()
        {
            MonetaryValue = 1;
            Name = "1 Euro Coin";
        }
    }
}
