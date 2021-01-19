using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NovelNew.Data;
using NovelNew.Models;

namespace NovelNew.Pages.NovelAuthors
{
    public class DetailsModel : PageModel
    {
        private readonly NovelNew.Data.NovelNewContext _context;

        public DetailsModel(NovelNew.Data.NovelNewContext context)
        {
            _context = context;
        }

        public NovelAuthor NovelAuthor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            NovelAuthor = await _context.NovelAuthor
                .Include(n => n.Authors)
                .Include(n => n.Novels).FirstOrDefaultAsync(m => m.NovelAuthorId == id);

            if (NovelAuthor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
