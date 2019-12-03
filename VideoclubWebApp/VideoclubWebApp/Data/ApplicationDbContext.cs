using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VideoclubWebApp.Models;

namespace VideoclubWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<VideoclubWebApp.Models.Film> Film { get; set; }
        public DbSet<VideoclubWebApp.Models.User> User { get; set; }
        public DbSet<VideoclubWebApp.Models.UserFilm> UserFilm { get; set; }
    }
}
