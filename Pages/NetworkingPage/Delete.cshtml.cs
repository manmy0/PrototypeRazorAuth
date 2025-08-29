using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrototypeRazorApp.Models;
using PrototypeRazorAuth.Data;

namespace PrototypeRazorAuth.Pages.NetworkingPage
{
    public class DeleteModel : PageModel
    {
        private readonly PrototypeRazorAuth.Data.ApplicationDbContext _context;

        public DeleteModel(PrototypeRazorAuth.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Networking Networking { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var networking = await _context.Networking.FirstOrDefaultAsync(m => m.Id == id);

            if (networking == null)
            {
                return NotFound();
            }
            else
            {
                Networking = networking;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var networking = await _context.Networking.FindAsync(id);
            if (networking != null)
            {
                Networking = networking;
                _context.Networking.Remove(Networking);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
