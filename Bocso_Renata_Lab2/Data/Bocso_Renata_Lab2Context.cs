﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bocso_Renata_Lab2.Models;

namespace Bocso_Renata_Lab2.Data
{
    public class Bocso_Renata_Lab2Context : DbContext
    {
        public Bocso_Renata_Lab2Context (DbContextOptions<Bocso_Renata_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Bocso_Renata_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Bocso_Renata_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Bocso_Renata_Lab2.Models.Author> Authors { get; set; }

        public DbSet<Bocso_Renata_Lab2.Models.Category> Category { get; set; }
    }
}
