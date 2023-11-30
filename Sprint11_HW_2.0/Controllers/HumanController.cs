// Jeff Meyers
// Provided lectures and documentation on creating and using MVC Applications.
// Also showed how to create views through the controllers

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Sprint11_HW_2._0.Models;

namespace Sprint11_HW_2._0.Controllers
{
    public class HumanController : Controller
    {
        static Human human;
        static List<Human> humanList;

        public HumanController()
        {
            if (human == null)
            {
                human = new Human();
            }
            if (humanList == null)
            {
                humanList = new List<Human>() { human, new Human(), new Human() };
            }
        }


        // GET: HomeController1
        public ActionResult Index()
        {
            // Shows the human to the page
            return View(humanList);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            var h = humanList.Where(x => x.ID == id).FirstOrDefault();
            return View(h);
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            var h = humanList.Where(x => x.ID == id).FirstOrDefault();
            return View(h);
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Human human)
        {
            try
            {
                for(int i = 0; i < humanList.Count; i++)
                {
                    if (humanList[i].ID == human.ID)
                    {
                        humanList[i].FirstName = human.FirstName;
                        humanList[i].LastName = human.LastName;
                        humanList[i].Age = human.Age;
                        humanList[i].Occupation = human.Occupation;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
