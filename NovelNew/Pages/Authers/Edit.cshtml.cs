using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NovelNew.Data;
using NovelNew.Models;

namespace NovelNew.Pages.Authers
{
    public class EditModel : PageModel
    {
        private readonly NovelNew.Data.NovelNewContext _context;

        public EditModel(NovelNew.Data.NovelNewContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Auther Auther { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Auther = await _context.Auther.FirstOrDefaultAsync(m => m.AuthorId == id);

            if (Auther == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Auther).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutherExists(Auther.AuthorId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AutherExists(int id)
        {
            return _context.Auther.Any(e => e.AuthorId == id);
        }
    }
}
