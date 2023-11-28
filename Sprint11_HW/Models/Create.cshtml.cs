using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sprint11_HW.Data;

namespace Sprint11_HW.Models
{
    public class CreateModel : PageModel
    {
        private readonly Sprint11_HW.Data.Sprint11_HWContext _context;

        public CreateModel(Sprint11_HW.Data.Sprint11_HWContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Human Human { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Human == null || Human == null)
            {
                return Page();
            }

            _context.Human.Add(Human);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
