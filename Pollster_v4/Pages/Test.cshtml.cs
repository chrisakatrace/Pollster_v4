using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pollster_v4.Data;
using Pollster_v4.Models;

namespace Pollster_v4.Pages
{
    public class TestModel : PageModel
    {
        private readonly Pollster_v4.Data.ApplicationDbContext _context;

        public TestModel(Pollster_v4.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Questions> Questions { get;set; }

        public async Task OnGetAsync()
        {
            Questions = await _context.Questions.ToListAsync();
        }
    }
}
