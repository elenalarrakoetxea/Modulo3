﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Relacion1aN.Models;

    public class Relacion1aNContext : DbContext
    {
        public Relacion1aNContext (DbContextOptions<Relacion1aNContext> options)
            : base(options)
        {
        }

    }
