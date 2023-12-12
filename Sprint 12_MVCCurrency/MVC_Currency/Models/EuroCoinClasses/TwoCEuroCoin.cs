using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVC_Currency
{
    public class TwoCEuroCoin : EuroCoin
    {
        public TwoCEuroCoin() : base()
        {
            MonetaryValue = 0.02;
            Name = "2c Euro Coin";
        }
    }
}
