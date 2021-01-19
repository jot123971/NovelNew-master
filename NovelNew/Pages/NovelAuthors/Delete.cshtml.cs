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
    public class DeleteModel : PageModel
    {
        private readonly NovelNew.Data.NovelNewContext _context;

        public DeleteModel(NovelNew.Data.NovelNewContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            NovelAuthor = await _context.NovelAuthor.FindAsync(id);

            if (NovelAuthor != null)
            {
                _context.NovelAuthor.Remove(NovelAuthor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
