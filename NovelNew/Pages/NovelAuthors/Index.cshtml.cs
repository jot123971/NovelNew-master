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
    public class IndexModel : PageModel
    {
        private readonly NovelNew.Data.NovelNewContext _context;

        public IndexModel(NovelNew.Data.NovelNewContext context)
        {
            _context = context;
        }

        public IList<NovelAuthor> NovelAuthor { get;set; }

        public async Task OnGetAsync()
        {
            NovelAuthor = await _context.NovelAuthor
                .Include(n => n.Authors)
                .Include(n => n.Novels).ToListAsync();
        }
    }
}
