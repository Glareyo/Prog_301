using Prog301_CurrencyProject.EuroCoinClasses;
using Prog301_CurrencyProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UnitTest
{
    [TestClass]
    public class EuroCoinTests
    {
        OneEuroCoin oneEuroCoin;
        TwoEuroCoin twoEuroCoin;
        FiftyCEuroCoin fiftyCEuroCoin;
        TwentyCEuroCoin twentyCEuroCoin;
        TenCEuroCoin tenCEuroCoin;
        FiveCEuroCoin fiveCEuroCoin;
        TwoCEuroCoin twoCEuroCoin;
        OneCEuroCoin oneCEuroCoin;

        public EuroCoinTests()
        {
            oneEuroCoin = new OneEuroCoin();
            twoEuroCoin = new TwoEuroCoin();
            fiftyCEuroCoin = new FiftyCEuroCoin();
            twentyCEuroCoin = new TwentyCEuroCoin();
            tenCEuroCoin = new TenCEuroCoin();
            fiveCEuroCoin = new FiveCEuroCoin();
            twoCEuroCoin = new TwoCEuroCoin();
            oneCEuroCoin = new OneCEuroCoin();
        }



        [TestMethod]
        public void CheckCoinValue()
        {
            Assert.AreEqual(oneEuroCoin.MonetaryValue, 1);
            Assert.AreEqual(twoEuroCoin.MonetaryValue, 2);
            Assert.AreEqual(fiftyCEuroCoin.MonetaryValue, 0.5);
            Assert.AreEqual(twentyCEuroCoin.MonetaryValue, 0.2);
            Assert.AreEqual(tenCEuroCoin.MonetaryValue, 0.1);
            Assert.AreEqual(fiveCEuroCoin.MonetaryValue, 0.05);
            Assert.AreEqual(twoCEuroCoin.MonetaryValue, 0.02);
            Assert.AreEqual(oneCEuroCoin.MonetaryValue, 0.01);
        }

        [TestMethod]
        public void CheckCoinName()
        {
            Assert.AreEqual(oneEuroCoin.Name, "1 Euro Coin");
            Assert.AreEqual(twoEuroCoin.Name, "2 Euro Coin");
            Assert.AreEqual(fiftyCEuroCoin.Name, "50c Euro Coin");
            Assert.AreEqual(twentyCEuroCoin.Name, "20c Euro Coin");
            Assert.AreEqual(tenCEuroCoin.Name, "10c Euro Coin");
            Assert.AreEqual(fiveCEuroCoin.Name, "5c Euro Coin");
            Assert.AreEqual(twoCEuroCoin.Name, "2c Euro Coin");
            Assert.AreEqual(oneCEuroCoin.Name, "1c Euro Coin");
        }

        [TestMethod]
        public void CheckCoinAbout()
        {
            Assert.AreEqual(oneEuroCoin.About(), $"The 1 Euro Coin is from {System.DateTime.Now.Year}. It is worth €1.");
            Assert.AreEqual(twoEuroCoin.About(), $"The 2 Euro Coin is from {System.DateTime.Now.Year}. It is worth €2.");
            Assert.AreEqual(fiftyCEuroCoin.About(), $"The 50c Euro Coin is from {System.DateTime.Now.Year}. It is worth €0.5.");
            Assert.AreEqual(twentyCEuroCoin.About(), $"The 20c Euro Coin is from {System.DateTime.Now.Year}. It is worth €0.2.");
            Assert.AreEqual(tenCEuroCoin.About(), $"The 10c Euro Coin is from {System.DateTime.Now.Year}. It is worth €0.1.");
            Assert.AreEqual(fiveCEuroCoin.About(), $"The 5c Euro Coin is from {System.DateTime.Now.Year}. It is worth €0.05.");
            Assert.AreEqual(twoCEuroCoin.About(), $"The 2c Euro Coin is from {System.DateTime.Now.Year}. It is worth €0.02.");
            Assert.AreEqual(oneCEuroCoin.About(), $"The 1c Euro Coin is from {System.DateTime.Now.Year}. It is worth €0.01.");
        }
    }
}
