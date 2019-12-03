using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Autor1a1.Models;

    public class Autor1a1Context : DbContext
    {
        public Autor1a1Context (DbContextOptions<Autor1a1Context> options)
            : base(options)
        {
        }

        public DbSet<Autor1a1.Models.Autor> Autor { get; set; }
        public DbSet<Autor1a1.Models.Biografia>Biografia { get; set; }
    }
