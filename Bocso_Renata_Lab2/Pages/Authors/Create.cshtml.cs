using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Bocso_Renata_Lab2.Data;
using Bocso_Renata_Lab2.Models;

namespace Bocso_Renata_Lab2.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Bocso_Renata_Lab2.Data.Bocso_Renata_Lab2Context _context;

        public CreateModel(Bocso_Renata_Lab2.Data.Bocso_Renata_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.Authors Authors { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Authors.Add(Authors);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
