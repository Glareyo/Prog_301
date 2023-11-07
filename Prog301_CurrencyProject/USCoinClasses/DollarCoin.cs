using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog301_CurrencyProject.USCoinClasses
{
    public class DollarCoin : USCoin
    {
        public DollarCoin() : base()
        {
            this.MintMark = USCoinMintMark.D;
            MonetaryValue = 1;

            Name = "Dollar Coin";
        }
        public DollarCoin(USCoinMintMark mark)
        {
            this.MintMark = mark;
        }
    }
}
