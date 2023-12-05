using Microsoft.AspNetCore.Mvc;
using Sprint11_HW_2._0.Controllers;
using Sprint11_HW_2._0.Models;

namespace Sprint11_HW_2._0_UnitTests
{
    [TestClass]
    public class HumanTests
    {
        Human Steve;
        HumanController repo;

        public HumanTests()
        {
            Steve = new Human();
            repo = new HumanController();
        }

        [TestMethod]
        public void IsAHuman()
        {
            Assert.IsInstanceOfType(Steve, typeof(IHuman));
        }


        [TestMethod]
        public void GetHuman()
        {
            //Credit
            //https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/unit-testing/creating-unit-tests-for-asp-net-mvc-applications-cs
            //Demonstrated how to unit test MVC Controllers
            var result = repo.Details(1) as ViewResult;
            var person = (Human)result.ViewData.Model;
            Assert.AreEqual("Jacob", person.FirstName);
            Assert.AreEqual("Larringston", person.LastName);
        }
    }
}