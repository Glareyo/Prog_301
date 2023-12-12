using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVC_Currency
{
    public class FiveCEuroCoin : EuroCoin
    {
        public FiveCEuroCoin() : base()
        {
            MonetaryValue = 0.05;
            Name = "5c Euro Coin";
        }
    }
}
