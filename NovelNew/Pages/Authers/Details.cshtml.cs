﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NovelNew.Data;
using NovelNew.Models;

namespace NovelNew.Pages.Authers
{
    public class DetailsModel : PageModel
    {
        private readonly NovelNew.Data.NovelNewContext _context;

        public DetailsModel(NovelNew.Data.NovelNewContext context)
        {
            _context = context;
        }

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
    }
}
