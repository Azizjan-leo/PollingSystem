using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PollingSystem.Data;
using PollingSystem.Models;

namespace PollingSystem.Pages.Polls
{
    public class DetailsModel : PageModel
    {
        private readonly PollingSystem.Data.ApplicationDbContext _context;

        public DetailsModel(PollingSystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Poll Poll { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Poll = await _context.Polls.FirstOrDefaultAsync(m => m.Id == id);

            if (Poll == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
