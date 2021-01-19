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
    public class IndexModel : PageModel
    {
        private readonly NovelNew.Data.NovelNewContext _context;

        public IndexModel(NovelNew.Data.NovelNewContext context)
        {
            _context = context;
        }

        public IList<Novel> Novel { get;set; }

        public async Task OnGetAsync()
        {
            Novel = await _context.Novel
                .Include(n => n.Genres).ToListAsync();
        }
    }
}
