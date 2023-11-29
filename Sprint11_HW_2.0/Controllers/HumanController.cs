using Microsoft.AspNetCore.Mvc;

namespace Sprint11_HW_2._0.Controllers
{
    public class HumanController : Controller
    {
        //Credit
        // Jeff Meyer
        // Helped recieved in creating a new page that is viewable

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HumanView()
        {
            return View();
        }
    }
}
