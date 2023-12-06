using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Szkolenia.Models;

namespace Szkolenia.Data
{
    public class SzkoleniaContext : DbContext
    {
        public SzkoleniaContext (DbContextOptions<SzkoleniaContext> options)
            : base(options)
        {
        }

        public DbSet<Szkolenia.Models.Course> Course { get; set; } = default!;

        public DbSet<Szkolenia.Models.Trainer>? Trainer { get; set; }
    }
}
