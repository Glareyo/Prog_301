﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Currency
{
    public class CurrencyRepo : ICurrencyRepo
    {
        public static int currencyRepoCount;
        public int ID { get; set; }
        public enum CoinType { Euro, US };
        public CurrencyRepo()
        {
            ID = currencyRepoCount++;
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

        public static ICurrencyRepo CreateChange(double amount,CoinType type)
        {
            CurrencyRepo repo = new CurrencyRepo();

            List<ICoin> returningCoins = new List<ICoin>();

            if (type == CoinType.US)
            {
                returningCoins = CreateUSChange(amount);
            }
            else
            {
                returningCoins = CreateEuroChange(amount);
            }
            repo.Coins = returningCoins;
            return repo;
        }

        static List<ICoin> CreateUSChange(double amount)
        {
            double adjustedAmount = amount;

            List<ICoin> returningCoins = new List<ICoin>();

            bool running = true;

            while (running)
            {
                adjustedAmount = Math.Round(adjustedAmount, 2);

                if (adjustedAmount <= 0)
                {
                    running = false;
                }
                else if (adjustedAmount >= 1)
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

            return returningCoins;
        }
        static List<ICoin> CreateEuroChange(double amount)
        {
            decimal adjustedAmount = Convert.ToDecimal(amount);

            List<ICoin> returningCoins = new List<ICoin>();

            bool running = true;

            while (running)
            {
                if (adjustedAmount <= 0)
                {
                    running = false;
                }
                if (adjustedAmount >= 2)
                {
                    returningCoins.Add(new TwoEuroCoin());
                    adjustedAmount -= 2;
                }
                else if (adjustedAmount >= 1)
                {
                    returningCoins.Add(new OneEuroCoin());
                    adjustedAmount -= 1;
                }
                else if (adjustedAmount >= Convert.ToDecimal(0.5))
                {
                    returningCoins.Add(new FiftyCEuroCoin());
                    adjustedAmount -= Convert.ToDecimal(0.5);
                }
                else if (adjustedAmount >= Convert.ToDecimal(0.20))
                {
                    returningCoins.Add(new TwentyCEuroCoin());
                    adjustedAmount -= Convert.ToDecimal(0.20);
                }
                else if (adjustedAmount >= Convert.ToDecimal(0.1))
                {
                    returningCoins.Add(new TenCEuroCoin());
                    adjustedAmount -= Convert.ToDecimal(0.1);
                }
                else if (adjustedAmount >= Convert.ToDecimal(0.05))
                {
                    returningCoins.Add(new FiveCEuroCoin());
                    adjustedAmount -= Convert.ToDecimal(0.05);
                }
                else if (adjustedAmount >= Convert.ToDecimal(0.02))
                {
                    returningCoins.Add(new TwoCEuroCoin());
                    adjustedAmount -= Convert.ToDecimal(0.02);
                }
                else if (adjustedAmount > 0)
                {
                    returningCoins.Add(new OneCEuroCoin());
                    adjustedAmount -= Convert.ToDecimal(0.01);
                }
            }

            return returningCoins;
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
            return CreateChange(amount, CoinType.US);
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
