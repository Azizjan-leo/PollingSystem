using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PollingSystem.Data;
using PollingSystem.Models;

namespace PollingSystem.Pages.Polls
{

    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Poll Poll { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync(string[] dynamicField)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Polls.Add(Poll);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
