using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVC_Currency
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
