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
    public class IndexModel : PageModel
    {
        private readonly Sprint11_HW.Data.Sprint11_HWContext _context;

        public IndexModel(Sprint11_HW.Data.Sprint11_HWContext context)
        {
            _context = context;
        }

        public IList<Human> Human { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Human != null)
            {
                Human = await _context.Human.ToListAsync();
            }
        }
    }
}
