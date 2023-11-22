using Microsoft.AspNetCore.Mvc;

namespace Sprint11_Demo.Controllers
{
    public class TestController : Controller
    {

        public string IndexString()
        {
            return "Hello!";
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
