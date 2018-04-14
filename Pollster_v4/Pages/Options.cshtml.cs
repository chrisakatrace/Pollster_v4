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
    public class OptionsModel : PageModel
    {
        private readonly Pollster_v4.Data.ApplicationDbContext _context;

        public OptionsModel(Pollster_v4.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public string QuestionsId { get; set; }

        public IActionResult OnGet()
        {
            QuestionsId = TempData["QuestionsId"].ToString();

            return Page();
        }

        [BindProperty]
        public Options Options { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Options.Add(Options);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Options");
        }
    }
}