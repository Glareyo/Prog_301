using Prog301_CurrencyProject;
using Prog301_CurrencyProject.EuroCoinClasses;
using Prog301_CurrencyProject.USCoinClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class EuroCurrencyRepoTests
    {
        ICurrencyRepo repo;
        OneEuroCoin oneEuroCoin;
        TwoCEuroCoin twoEuroCoin;
        FiftyCEuroCoin fiftyCEuroCoin;
        TwentyCEuroCoin twentyCEuroCoin;
        TenCEuroCoin tenCEuroCoin;
        FiveCEuroCoin fiveCEuroCoin;
        TwoCEuroCoin twoCEuroCoin;
        OneCEuroCoin oneCEuroCoin;

        public EuroCurrencyRepoTests()
        {
            repo = new CurrencyRepo();
            oneEuroCoin = new OneEuroCoin();
            twoEuroCoin = new TwoCEuroCoin();
            fiftyCEuroCoin = new FiftyCEuroCoin();
            twentyCEuroCoin = new TwentyCEuroCoin();
            tenCEuroCoin = new TenCEuroCoin();
            fiveCEuroCoin = new FiveCEuroCoin();
            twoCEuroCoin = new TwoCEuroCoin();
            oneCEuroCoin = new OneCEuroCoin();
        }
        [TestMethod]
        public void AddCoinTest()
        {
            //Arrange
            int coinCountOrig, coinCountAfterOneC, coinCountAfterFiveOneCs;
            int numOneCs = 4;


            Double valueOrig, valueAfterOneC, valueAfterFiveOneCs;
            Double valueAfterTenC, valueAfterTwentyC, valueAfterFiftyC, valueAfterEuro, valueAfterTwoEuro;
            //Act
            coinCountOrig = repo.GetCoinCount();
            valueOrig = repo.TotalValue();

            repo.AddCoin(oneCEuroCoin);
            coinCountAfterOneC = repo.GetCoinCount();
            valueAfterOneC = repo.TotalValue();

            for (int i = 0; i < numOneCs; i++)
            {
                repo.AddCoin(oneCEuroCoin);
            }
            coinCountAfterFiveOneCs = repo.GetCoinCount();
            valueAfterFiveOneCs = repo.TotalValue();

            repo.AddCoin(tenCEuroCoin);
            valueAfterTenC = repo.TotalValue();
            repo.AddCoin(twentyCEuroCoin);
            valueAfterTwentyC = repo.TotalValue();
            repo.AddCoin(fiftyCEuroCoin);
            valueAfterFiftyC = repo.TotalValue();
            repo.AddCoin(oneEuroCoin);
            valueAfterEuro = repo.TotalValue();
            repo.AddCoin(twoEuroCoin);
            valueAfterTwoEuro = repo.TotalValue();

            //Assert
            Assert.AreEqual(coinCountOrig + 1, coinCountAfterOneC);
            Assert.AreEqual(coinCountAfterOneC + numOneCs, coinCountAfterFiveOneCs);

            Assert.AreEqual(valueOrig + oneCEuroCoin.MonetaryValue, valueAfterOneC);
            Assert.AreEqual(valueAfterOneC + (numOneCs * oneCEuroCoin.MonetaryValue), valueAfterFiveOneCs);

            Assert.AreEqual(valueAfterFiveOneCs + tenCEuroCoin.MonetaryValue, valueAfterTenC);
            Assert.AreEqual(valueAfterTenC + twentyCEuroCoin.MonetaryValue, valueAfterTwentyC);
            Assert.AreEqual(valueAfterTwentyC + fiftyCEuroCoin.MonetaryValue, valueAfterFiftyC);
            Assert.AreEqual(valueAfterFiftyC + oneEuroCoin.MonetaryValue, valueAfterEuro);
            Assert.AreEqual(valueAfterEuro + twoEuroCoin.MonetaryValue, valueAfterTwoEuro);
        }
        

        [TestMethod]
        public void RemoveCoinTest()
        {

            //Arrange
            int coinCountOrig, coinCountAfterOneC, coinCountAfterFiveOneCs;
            int numOneCs = 4;


            Double valueOrig, valueAfterOneC, valueAfterFiveOneCs;
            Double valueAfterFiveC, valueAfterTenC, valueAfterTwentyC, valueAfterFiftyC, valueAfterOneEuro,valueAfterTwoEuro;

            repo = new CurrencyRepo();  //reset repo

            //add some coins
            repo.AddCoin(oneCEuroCoin);

            for (int i = 0; i < numOneCs; i++)
            {
                repo.AddCoin(oneCEuroCoin);
            }
            repo.AddCoin(fiveCEuroCoin);
            repo.AddCoin(tenCEuroCoin);
            repo.AddCoin(twentyCEuroCoin);
            repo.AddCoin(fiftyCEuroCoin);
            repo.AddCoin(oneEuroCoin);
            repo.AddCoin(twoEuroCoin);

            //Act
            coinCountOrig = repo.GetCoinCount();
            valueOrig = repo.TotalValue();
            repo.RemoveCoin(oneCEuroCoin);
            coinCountAfterOneC = repo.GetCoinCount();
            valueAfterOneC = repo.TotalValue();

            for (int i = 0; i < numOneCs; i++)
            {
                repo.RemoveCoin(oneCEuroCoin);
            }
            coinCountAfterFiveOneCs = repo.GetCoinCount();
            valueAfterFiveOneCs = repo.TotalValue();

            repo.RemoveCoin(fiveCEuroCoin);
            valueAfterFiveC = repo.TotalValue();
            repo.RemoveCoin(tenCEuroCoin);
            valueAfterTenC = repo.TotalValue();
            repo.RemoveCoin(twentyCEuroCoin);
            valueAfterTwentyC = repo.TotalValue();
            repo.RemoveCoin(fiftyCEuroCoin);
            valueAfterFiftyC = repo.TotalValue();
            repo.RemoveCoin(oneEuroCoin);
            valueAfterOneEuro = repo.TotalValue();
            repo.RemoveCoin(twoEuroCoin);
            valueAfterTwoEuro = repo.TotalValue();


            //Assert
            Assert.AreEqual(coinCountOrig - 1, coinCountAfterOneC);
            Assert.AreEqual(coinCountAfterOneC - numOneCs, coinCountAfterFiveOneCs);

            Assert.AreEqual(valueOrig - oneCEuroCoin.MonetaryValue, valueAfterOneC);
            Assert.AreEqual(valueAfterOneC - (numOneCs * oneCEuroCoin.MonetaryValue), valueAfterFiveOneCs);

            //Assert.AreEqual(valueAfterFiveMorePennies - nickel.MonetaryValue, valueAfterNickel); //HUH? 1.35 != 1.35 both are double?
            Assert.AreEqual(valueAfterFiveC - tenCEuroCoin.MonetaryValue, valueAfterTenC);
            Assert.AreEqual(valueAfterTenC - twentyCEuroCoin.MonetaryValue, valueAfterTwentyC);
            Assert.AreEqual(valueAfterTwentyC - fiftyCEuroCoin.MonetaryValue, valueAfterFiftyC);

        }
    }
}
