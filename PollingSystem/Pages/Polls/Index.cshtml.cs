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
    public class IndexModel : PageModel
    {
        private readonly PollingSystem.Data.ApplicationDbContext _context;

        public IndexModel(PollingSystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Poll> Poll { get;set; }

        public async Task OnGetAsync()
        {
            Poll = await _context.Polls.ToListAsync();
        }
    }
}
