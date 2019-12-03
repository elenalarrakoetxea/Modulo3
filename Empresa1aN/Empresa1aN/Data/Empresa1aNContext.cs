using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Empresa1aN.Models;

    public class Empresa1aNContext : DbContext
    {
        public Empresa1aNContext (DbContextOptions<Empresa1aNContext> options)
            : base(options)
        {
        }

        public DbSet<Empresa1aN.Models.Departamento> Departamento { get; set; }
        public DbSet<Empresa1aN.Models.Empleado> Empleado { get; set; }
    }
