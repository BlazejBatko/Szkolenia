using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Szkolenia.Data;
using Szkolenia.Models;

namespace Szkolenia.Pages.Courses
{
    public class CreateModel : PageModel
    {
        private readonly Szkolenia.Data.SzkoleniaContext _context;

        public CreateModel(Szkolenia.Data.SzkoleniaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["TrainerId"] = new SelectList(_context.Set<Trainer>(), "TrainerId", "TrainerId");
            return Page();
        }

        [BindProperty]
        public Course Course { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {

            _context.Course.Add(Course);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
