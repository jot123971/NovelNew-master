using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NovelNew.Data;
using NovelNew.Models;

namespace NovelNew.Pages.NovelAuthors
{
    public class CreateModel : PageModel
    {
        private readonly NovelNew.Data.NovelNewContext _context;

        public CreateModel(NovelNew.Data.NovelNewContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AuthorId"] = new SelectList(_context.Author, "AuthorId", "AuthorId");
        ViewData["NovelId"] = new SelectList(_context.Set<Novel>(), "NovelId", "NovelId");
            return Page();
        }

        [BindProperty]
        public NovelAuthor NovelAuthor { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.NovelAuthor.Add(NovelAuthor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
