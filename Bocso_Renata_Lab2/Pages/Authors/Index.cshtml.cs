using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bocso_Renata_Lab2.Data;
using Bocso_Renata_Lab2.Models;

namespace Bocso_Renata_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Bocso_Renata_Lab2.Data.Bocso_Renata_Lab2Context _context;

        public IndexModel(Bocso_Renata_Lab2.Data.Bocso_Renata_Lab2Context context)
        {
            _context = context;
        }

        public IList<Models.Authors> Authors { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Authors != null)
            {
                Authors = await _context.Authors.ToListAsync();
            }
        }
    }
}
