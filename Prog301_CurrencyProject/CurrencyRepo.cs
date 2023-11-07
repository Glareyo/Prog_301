using Prog301_CurrencyProject.USCoinClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog301_CurrencyProject
{
    public class CurrencyRepo : ICurrencyRepo
    {
        public CurrencyRepo()
        {
            Coins = new List<ICoin>();
        }

        public List<ICoin> Coins { get; set; }
        public string About()
        {
            throw new NotImplementedException();
        }
        public void AddCoin(ICoin c)
        {
            Coins.Add(c);
        }

        public static ICurrencyRepo CreateChange(double amount)
        {
            CurrencyRepo repo = new CurrencyRepo();

            double adjustedAmount = amount;
            
            List<ICoin> returningCoins = new List<ICoin>();

            bool running = true;

            while (running)
            {
                if (adjustedAmount <= 0)
                {
                    running = false;
                }
                if (adjustedAmount >= 1)
                {
                    returningCoins.Add(new DollarCoin());
                    adjustedAmount -= 1;
                }
                else if (adjustedAmount >= 0.5)
                {
                    returningCoins.Add(new HalfDollar());
                    adjustedAmount -= 0.5;
                }
                else if (adjustedAmount >= 0.25)
                {
                    returningCoins.Add(new Quarter());
                    adjustedAmount -= 0.25;
                }
                else if (adjustedAmount >= 0.1)
                {
                    returningCoins.Add(new Dime());
                    adjustedAmount -= 0.1;
                }
                else if (adjustedAmount >= 0.05)
                {
                    returningCoins.Add(new Nickel());
                    adjustedAmount -= 0.05;
                }
                else if (adjustedAmount > 0)
                {
                    returningCoins.Add(new Penny());
                    adjustedAmount -= 0.01;
                }
            }

            repo.Coins = returningCoins;
            return repo;
        }
        public static ICurrencyRepo CreateChange(double amountTendered, double TotalCost)
        {
            throw new NotImplementedException();
        }
        

        public int GetCoinCount()
        {
            return Coins.Count;
        }



        public ICurrencyRepo MakeChange(double amount)
        {
            throw new NotImplementedException();
        }
        public ICurrencyRepo MakeChange(double amountTendered, double totalCost)
        {
            throw new NotImplementedException();
        }
        public ICoin RemoveCoin(ICoin c)
        {
            //Search and see if the repo has a similar coin
            /*if (Coins.Contains(c))
            {*/
                Coins.Remove(c);
                return c;
            //}
            /*else
            {//Else if the coin is not present
                // Determine value of coin attempted to be removed
                // Remove 

            }*/
        }
        public double TotalValue()
        {
            double amount = 0;
            foreach (Coin c in Coins)
                amount += c.MonetaryValue;

            return amount;
        }
    }
}
