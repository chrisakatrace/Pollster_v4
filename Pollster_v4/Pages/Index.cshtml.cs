using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pollster_v4.Models;

namespace Pollster_v4.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Pollster_v4.Data.ApplicationDbContext _context;

        public IndexModel(Pollster_v4.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public string UserId { get; set; }

        public async Task OnGetAsync()
        {
            UserId = HttpContext.User.Identity.Name;

            Questions = await _context.Questions.ToListAsync();
        }

        public IList<Questions> Questions { get; set; }

        [BindProperty]
        public Answers Answers { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Answers.Add(Answers);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
