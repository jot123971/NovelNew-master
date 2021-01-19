using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NovelNew.Data;
using NovelNew.Models;

namespace NovelNew.Pages.Novels
{
    public class DetailsModel : PageModel
    {
        private readonly NovelNew.Data.NovelNewContext _context;

        public DetailsModel(NovelNew.Data.NovelNewContext context)
        {
            _context = context;
        }

        public Novel Novel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Novel = await _context.Novel
                .Include(n => n.Genres).FirstOrDefaultAsync(m => m.NovelId == id);

            if (Novel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
