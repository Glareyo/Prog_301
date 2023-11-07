using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog301_CurrencyProject.USCoinClasses
{
    public class Quarter : USCoin
    {
        public Quarter() : base()
        {
            this.MintMark = USCoinMintMark.D;
            MonetaryValue = 0.25;

            Name = "Quarter";
        }
        public Quarter(USCoinMintMark mark)
        {
            this.MintMark = mark;
        }
    }
}
