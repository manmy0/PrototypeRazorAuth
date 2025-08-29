using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrototypeRazorApp.Models;
using PrototypeRazorAuth.Data;

namespace PrototypeRazorAuth.Pages.CompetenciesPage
{
    public class DeleteModel : PageModel
    {
        private readonly PrototypeRazorAuth.Data.ApplicationDbContext _context;

        public DeleteModel(PrototypeRazorAuth.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Competencies Competencies { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competencies = await _context.Competencies.FirstOrDefaultAsync(m => m.Id == id);

            if (competencies == null)
            {
                return NotFound();
            }
            else
            {
                Competencies = competencies;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competencies = await _context.Competencies.FindAsync(id);
            if (competencies != null)
            {
                Competencies = competencies;
                _context.Competencies.Remove(Competencies);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
