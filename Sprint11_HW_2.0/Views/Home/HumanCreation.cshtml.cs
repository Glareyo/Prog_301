using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sprint11_HW_2._0.Models;

namespace Sprint11_HW_2._0.Views.Home
{
    //Credits
    // http.www.youtube.com/watch?v=pmWFzzU_NB4
    // tutorialsEU - C# => Demonstrated implentation of Razor and pages.
    public class HumanCreationModel : PageModel
    {
        private readonly DatabaseHandler _databaseHandler;

        public List<IHuman> HumanList { get; set; } = new List<IHuman>();

        [BindProperty]

        public Human MyHuman { get; set; }

        public HumanCreationModel(DatabaseHandler databaseHandler)
        {
            _databaseHandler = databaseHandler;
        }

        public void OnGet()
        {
            HumanList = _databaseHandler.Humans.ToList();
        }

        public IActionResult OnPost()
        {
            _databaseHandler.Humans.Add(MyHuman);
            _databaseHandler.SaveChanges();
            return RedirectToPage();
        }
    }
}
