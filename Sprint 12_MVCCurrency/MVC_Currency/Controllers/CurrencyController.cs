using Microsoft.AspNetCore.Mvc;

namespace MVC_Currency.Controllers
{
    public class CurrencyController : Controller
    {
        ICurrencyRepo repo { get; set; }
        RepoViewModel vm { get; set; }

        public CurrencyController()
        {
            repo = new CurrencyRepo();
            vm = new RepoViewModel(repo);
        }

        // GET: CurrencyRepo
        public ActionResult Index()
        {
            return View(vm);
        }

        // GET: CurrencyRepo
        public ActionResult MakeChange(Double Amount)
        {
            vm.MakeChange(Amount);
            return View(vm);
        }
    }
}
