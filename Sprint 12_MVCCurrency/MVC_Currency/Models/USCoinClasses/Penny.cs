using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Currency
{
    public class Penny : USCoin
    {
        public Penny() : base()
        {
            this.MintMark = USCoinMintMark.D;
            MonetaryValue = 0.01;

            Name = "Penny";
        }
        public Penny(USCoinMintMark mark)
        {
            this.MintMark = mark;
        }
    }
}
