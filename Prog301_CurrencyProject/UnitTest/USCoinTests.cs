using Prog301_CurrencyProject.USCoinClasses;
using Prog301_CurrencyProject;
using static Prog301_CurrencyProject.USCoin;

namespace UnitTest
{
    [TestClass]
    public class USCoinTests
    {

        Penny p;

        public USCoinTests()
        {
            p = new Penny();
        }


        [TestMethod]
        public void USCoinPennyConstructor()
        {
            //Arrange
            p = new Penny();
            //Act 

            //Assert
            Assert.AreEqual(USCoin.USCoinMintMark.D, p.MintMark); //D is the default mint mark
            Assert.AreEqual(System.DateTime.Now.Year, p.Year); //Current year is default year

        }

        [TestMethod]
        public void USCoinMintMark()
        {

            //Arrange
            string mintNameDenver, mintNamePhili, mintNameSanFran, mintNameWestPoint;
            USCoinMintMark D, P, S, W;

            //Act 
            mintNameDenver = "Denver";
            mintNamePhili = "Philadephia";
            mintNameSanFran = "San Francisco";
            mintNameWestPoint = "West Point";
            D = USCoin.USCoinMintMark.D;
            P = USCoin.USCoinMintMark.P;
            S = USCoin.USCoinMintMark.S;
            W = USCoin.USCoinMintMark.W;

            //Assert
            Assert.AreEqual(USCoin.GetMintNameFromMark(D), mintNameDenver);
            Assert.AreEqual(USCoin.GetMintNameFromMark(P), mintNamePhili);
            Assert.AreEqual(USCoin.GetMintNameFromMark(S), mintNameSanFran);
            Assert.AreEqual(USCoin.GetMintNameFromMark(W), mintNameWestPoint);
        }

        [TestMethod]
        public void USCoinPennyMonetaryValue()
        {
            //Arrange
            p = new Penny();
            //Act 
            //nothing should have .01;
            //Assert
            Assert.AreEqual(.01, p.MonetaryValue);
        }

        [TestMethod]
        public void USCoinPennyAbout()
        {
            //Arrange
            p = new Penny();
            //Act 

            //Assert ( Changed to 2023 due to requirements of te assignment )
            Assert.AreEqual("US Penny is from 2023. It is worth $0.01. It was made in Denver", p.About());
        }
    }
}