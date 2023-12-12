using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVC_Currency
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
