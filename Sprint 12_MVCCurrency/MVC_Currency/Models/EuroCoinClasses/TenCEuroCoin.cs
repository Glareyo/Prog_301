using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVC_Currency
{
    public class TenCEuroCoin : EuroCoin
    {
        public TenCEuroCoin() : base()
        {
            MonetaryValue = 0.1;
            Name = "10c Euro Coin";
        }
    }
}
