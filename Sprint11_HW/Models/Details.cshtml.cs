using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sprint11_HW.Data;

namespace Sprint11_HW.Models
{
    public class DetailsModel : PageModel
    {
        private readonly Sprint11_HW.Data.Sprint11_HWContext _context;

        public DetailsModel(Sprint11_HW.Data.Sprint11_HWContext context)
        {
            _context = context;
        }

      public Human Human { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Human == null)
            {
                return NotFound();
            }

            var human = await _context.Human.FirstOrDefaultAsync(m => m.ID == id);
            if (human == null)
            {
                return NotFound();
            }
            else 
            {
                Human = human;
            }
            return Page();
        }
    }
}
