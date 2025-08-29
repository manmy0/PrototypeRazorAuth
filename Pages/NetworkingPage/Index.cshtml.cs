using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PrototypeRazorApp.Models;
using PrototypeRazorAuth.Data;

namespace PrototypeRazorAuth.Pages.NetworkingPage
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly PrototypeRazorAuth.Data.ApplicationDbContext _context;

        public IndexModel(PrototypeRazorAuth.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Networking> Networking { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Networking = await _context.Networking.ToListAsync();
        }
    }
}
