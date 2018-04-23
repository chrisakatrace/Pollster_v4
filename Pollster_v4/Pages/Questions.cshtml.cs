using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pollster_v4.Data;
using Pollster_v4.Models;

namespace Pollster_v4.Pages
{
    public class QuestionsModel : PageModel
    {
        private readonly Pollster_v4.Data.ApplicationDbContext _context;

        public QuestionsModel(Pollster_v4.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public string UserId { get; set; }

        public IActionResult OnGet()
        {
            UserId = HttpContext.User.Identity.Name;

            return Page();
        }

        [BindProperty]
        public Questions Questions { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Questions.Add(Questions);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}