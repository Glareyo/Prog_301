using Microsoft.AspNetCore.Mvc;

namespace Sprint11_HW_2._0.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {

             return View();
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}
