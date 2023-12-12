using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVC_Currency
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
