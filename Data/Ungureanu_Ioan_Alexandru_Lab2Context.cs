using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ungureanu_Ioan_Alexandru_Lab2.Models;

namespace Ungureanu_Ioan_Alexandru_Lab2.Data
{
    public class Ungureanu_Ioan_Alexandru_Lab2Context : DbContext
    {
        public Ungureanu_Ioan_Alexandru_Lab2Context (DbContextOptions<Ungureanu_Ioan_Alexandru_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ungureanu_Ioan_Alexandru_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Ungureanu_Ioan_Alexandru_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Ungureanu_Ioan_Alexandru_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
