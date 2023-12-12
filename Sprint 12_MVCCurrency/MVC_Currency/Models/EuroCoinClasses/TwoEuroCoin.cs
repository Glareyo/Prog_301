using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVC_Currency
{
    public class TwoEuroCoin : EuroCoin
    {
        public TwoEuroCoin() : base()
        {
            MonetaryValue = 2;
            Name = "2 Euro Coin";
        }
    }
}
