using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog301_CurrencyProject.USCoinClasses
{
    public class Dime : USCoin
    {
        public Dime() : base()
        {
            this.MintMark = USCoinMintMark.D;
            MonetaryValue = 0.1;

            Name = "Dime";
        }
        public Dime(USCoinMintMark mark)
        {
            this.MintMark = mark;
        }
    }
}
