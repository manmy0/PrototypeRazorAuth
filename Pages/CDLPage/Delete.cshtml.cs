using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrototypeRazorApp.Models;
using PrototypeRazorAuth.Data;

namespace PrototypeRazorAuth.Pages.CDLPage
{
    public class DeleteModel : PageModel
    {
        private readonly PrototypeRazorAuth.Data.ApplicationDbContext _context;

        public DeleteModel(PrototypeRazorAuth.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CDL CDL { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cdl = await _context.CDL.FirstOrDefaultAsync(m => m.Id == id);

            if (cdl == null)
            {
                return NotFound();
            }
            else
            {
                CDL = cdl;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cdl = await _context.CDL.FindAsync(id);
            if (cdl != null)
            {
                CDL = cdl;
                _context.CDL.Remove(CDL);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
