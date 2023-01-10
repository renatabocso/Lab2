using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bocso_Renata_Lab2.Data;
using Bocso_Renata_Lab2.Models;
using Bocso_Renata_Lab2.Models.ViewModels;

namespace Bocso_Renata_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Bocso_Renata_Lab2.Data.Bocso_Renata_Lab2Context _context;

        public IndexModel(Bocso_Renata_Lab2.Data.Bocso_Renata_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get; set; } = default!;
        public CategoryIndexData CategoryData { get; set; }
        public int CategoryID { get; set; }
        public int BookID { get; set; }
        public async Task OnGetAsync(int? id, int? bookID)
        {
            CategoryData = new CategoryIndexData();

            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
      
            if (id != null)
            {
                var bookCategories = await _context.Book.
                Include(i => i.BookCategories)
                .ThenInclude(i => i.Book)
                .ThenInclude(i => i.Author)
                .SelectMany(s => s.BookCategories)
                .ToListAsync();

                CategoryData.BookCategories = new List<BookCategory> {bookCategories
                    .FirstOrDefault(w => w.CategoryID == id.Value) };
                CategoryID = id.Value;
                CategoryData.Books = bookCategories
                .Where(i => i.CategoryID == id.Value)
                .Select(s => s.Book)
                .ToList();
            }
        }
    }
}
