using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog301_CurrencyProject.USCoinClasses
{
    public class Nickel : USCoin
    {
        public Nickel() : base()
        {
            this.MintMark = USCoinMintMark.D;
            MonetaryValue = 0.05;

            Name = "Nickel";
        }
        public Nickel(USCoinMintMark mark)
        {
            this.MintMark = mark;
        }
    }
}
