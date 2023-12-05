using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prog301_CurrencyProject.USCoin;
using System.Xml.Linq;

namespace Prog301_CurrencyProject.EuroCoinClasses
{
    public class FiftyCEuroCoin : EuroCoin
    {
        public FiftyCEuroCoin() : base()
        {
            MonetaryValue = 0.5;
            Name = "50c Euro Coin";
        }
    }
}
