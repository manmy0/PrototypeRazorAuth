using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrototypeRazorApp.Models;
using PrototypeRazorAuth.Data;

namespace PrototypeRazorAuth.Pages.SummaryPage
{
    public class DetailsModel : PageModel
    {
        private readonly PrototypeRazorAuth.Data.ApplicationDbContext _context;

        public DetailsModel(PrototypeRazorAuth.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Summary Summary { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var summary = await _context.Summary.FirstOrDefaultAsync(m => m.Id == id);
            if (summary == null)
            {
                return NotFound();
            }
            else
            {
                Summary = summary;
            }
            return Page();
        }
    }
}
