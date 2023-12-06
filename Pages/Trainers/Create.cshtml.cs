using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Szkolenia.Data;
using Szkolenia.Models;

namespace Szkolenia.Pages.Trainers
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
            return Page();
        }

        [BindProperty]
        public Trainer Trainer { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {

            _context.Trainer.Add(Trainer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
