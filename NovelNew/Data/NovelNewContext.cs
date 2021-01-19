using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NovelNew.Models;

namespace NovelNew.Data
{
    public class NovelNewContext : DbContext
    {
        public NovelNewContext (DbContextOptions<NovelNewContext> options)
            : base(options)
        {
        }

        public DbSet<NovelNew.Models.Author> Author { get; set; }

        public DbSet<NovelNew.Models.Genre> Genre { get; set; }

        public DbSet<NovelNew.Models.NovelAuthor> NovelAuthor { get; set; }

        public DbSet<NovelNew.Models.Novel> Novel { get; set; }

        public DbSet<NovelNew.Models.Auther> Auther { get; set; }
    }
}
