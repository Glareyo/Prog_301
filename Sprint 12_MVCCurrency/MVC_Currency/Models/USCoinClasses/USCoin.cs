using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Currency
{
    public class USCoin : Coin
    {
        public enum USCoinMintMark { P, D, S, W };

        public USCoinMintMark MintMark;
        
        public virtual string About()
        {
            string about = $"US {Name} is from {Year}. It is worth ${MonetaryValue}. It was made in {GetMintNameFromMark(MintMark)}";
            return about;
        }
        public static string GetMintNameFromMark(USCoinMintMark mark)
        {
            switch(mark)
            {
                case USCoinMintMark.P:
                    return "Philadephia";
                case USCoinMintMark.D:
                    return "Denver";
                case USCoinMintMark.S:
                    return "San Francisco";
            }
            //Else return W
            return "West Point";
        }

        public USCoin()
        {
            Year = System.DateTime.Now.Year;
        }
    }
}
