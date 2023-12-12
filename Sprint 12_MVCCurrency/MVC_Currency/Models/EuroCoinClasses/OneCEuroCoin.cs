using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVC_Currency
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
