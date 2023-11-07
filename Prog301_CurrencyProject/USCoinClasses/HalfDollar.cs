using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prog301_CurrencyProject.USCoin;

namespace Prog301_CurrencyProject.USCoinClasses
{
    public class HalfDollar : USCoin
    {
        public HalfDollar() : base()
        {
            this.MintMark = USCoinMintMark.D;
            MonetaryValue = 0.5;

            Name = "Half Dollar Coin";
        }
        public HalfDollar(USCoinMintMark mark)
        {
            this.MintMark = mark;
        }
    }
}
