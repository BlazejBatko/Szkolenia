using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Szkolenia.Data;
using Szkolenia.Models;

namespace Szkolenia.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly Szkolenia.Data.SzkoleniaContext _context;

        public IndexModel(Szkolenia.Data.SzkoleniaContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Course != null)
            {
                Course = await _context.Course
                .Include(c => c.Trainer).ToListAsync();
            }
        }
    }
}
