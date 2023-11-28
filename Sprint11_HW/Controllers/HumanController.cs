using Microsoft.AspNetCore.Mvc;

namespace Sprint11_HW.Controllers
{
    public class HumanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
