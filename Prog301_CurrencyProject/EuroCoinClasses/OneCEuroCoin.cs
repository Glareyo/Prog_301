using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prog301_CurrencyProject.USCoin;
using System.Xml.Linq;

namespace Prog301_CurrencyProject.EuroCoinClasses
{
    public class OneCEuroCoin : EuroCoin
    {
        public OneCEuroCoin() : base()
        {
            MonetaryValue = 0.01;
            Name = "1c Euro Coin";
        }
    }
}
