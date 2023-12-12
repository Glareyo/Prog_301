using Microsoft.AspNetCore.Mvc;
using MVC_Currency;
using MVC_Currency.Controllers;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace MVC_CurrencyUnitTests
{
    [TestClass]
    public class MakeChangeTests
    {
        CurrencyRepo repo;
        RepoViewModel repoViewModel;
        CurrencyController controller;

        public MakeChangeTests()
        {
            repo = new CurrencyRepo();
            repoViewModel = new RepoViewModel(repo);
            controller = new CurrencyController();
        }

        [TestMethod]
        public void StandardIndex()
        {
            var baseIndex = controller.Index() as ViewResult;
            var result = (RepoViewModel)baseIndex.ViewData.Model;

            Assert.AreEqual(result.TotalValue, 0);
            Assert.AreEqual(result.Coins.Count, 0);
        }

        [TestMethod]
        public void CanMakeChange()
        {
            //Credit
            //https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/unit-testing/creating-unit-tests-for-asp-net-mvc-applications-cs
            //Demonstrated how to unit test MVC Controllers
            var changeTwoDollars = (new CurrencyController()).MakeChange(2) as ViewResult;
            var changeThreeDollars = (new CurrencyController()).MakeChange(3) as ViewResult;
            var changeTwoDollarsAndFiveCents = (new CurrencyController()).MakeChange(2.05) as ViewResult;
            var changeTwoDollarsAndFiftyCents = (new CurrencyController()).MakeChange(2.5) as ViewResult;
            var changeTwoDollarsAndFiftySevenCents = (new CurrencyController()).MakeChange(2.57) as ViewResult;

            var changeTwoDollarsResult = (RepoViewModel)changeTwoDollars.ViewData.Model;
            var changeThreeDollarsResult = (RepoViewModel)changeThreeDollars.ViewData.Model;
            var changeTwoDollarsAndFiveCentsResult = (RepoViewModel)changeTwoDollarsAndFiveCents.ViewData.Model;
            var changeTwoDollarsAndFiftyCentsResult = (RepoViewModel)changeTwoDollarsAndFiftyCents.ViewData.Model;
            var changeTwoDollarsAndFiftySevenCentsResult = (RepoViewModel)changeTwoDollarsAndFiftySevenCents.ViewData.Model;

            Assert.AreEqual(changeTwoDollarsResult.Coins.Count, 2);
            Assert.AreEqual(changeThreeDollarsResult.Coins.Count, 3);
            Assert.AreEqual(changeTwoDollarsAndFiveCentsResult.Coins.Count, 3);
            Assert.AreEqual(changeTwoDollarsAndFiftyCentsResult.Coins.Count, 3);
            Assert.AreEqual(changeTwoDollarsAndFiftySevenCentsResult.Coins.Count, 6);

            Assert.AreEqual(Math.Round(changeTwoDollarsResult.TotalValue,2), 2);
            Assert.AreEqual(Math.Round(changeThreeDollarsResult.TotalValue, 2), 3);
            Assert.AreEqual(Math.Round(changeTwoDollarsAndFiveCentsResult.TotalValue, 2), 2.05);
            Assert.AreEqual(Math.Round(changeTwoDollarsAndFiftyCentsResult.TotalValue, 2), 2.5);
            Assert.AreEqual(Math.Round(changeTwoDollarsAndFiftySevenCentsResult.TotalValue, 2), 2.57);
        }
    }
}