using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrototypeRazorApp.Models;
using PrototypeRazorAuth.Data;

namespace PrototypeRazorAuth.Pages.GoalsPage
{
    public class DeleteModel : PageModel
    {
        private readonly PrototypeRazorAuth.Data.ApplicationDbContext _context;

        public DeleteModel(PrototypeRazorAuth.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Goals Goals { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goals = await _context.Goals.FirstOrDefaultAsync(m => m.Id == id);

            if (goals == null)
            {
                return NotFound();
            }
            else
            {
                Goals = goals;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goals = await _context.Goals.FindAsync(id);
            if (goals != null)
            {
                Goals = goals;
                _context.Goals.Remove(Goals);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
