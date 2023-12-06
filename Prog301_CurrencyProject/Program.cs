using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog301_CurrencyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ICoin> coinList1 = CurrencyRepo.CreateChange(3, CurrencyRepo.CoinType.Euro).Coins;
            List<ICoin> coinList2 = CurrencyRepo.CreateChange(1.5, CurrencyRepo.CoinType.Euro).Coins;
            List<ICoin> coinList3 = CurrencyRepo.CreateChange(.35, CurrencyRepo.CoinType.Euro).Coins;

            foreach (ICoin coin in coinList1)
            {
                Console.WriteLine(coin);
            }
            Console.WriteLine(coinList1.Count);
            Console.WriteLine();

            foreach (ICoin coin in coinList2)
            {
                Console.WriteLine(coin);
            }
            Console.WriteLine(coinList1.Count);
            Console.WriteLine();
            
            foreach (ICoin coin in coinList3)
            {
                Console.WriteLine(coin);
            }
            Console.WriteLine(coinList1.Count);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
