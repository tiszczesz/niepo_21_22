using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _3ti_sp_cw1_2021_22.Models;

namespace _3ti_sp_cw1_2021_22.Data
{
    public class _AnimalContext : DbContext
    {
        public _AnimalContext (DbContextOptions<_AnimalContext> options)
            : base(options)
        {
        }

        public DbSet<_3ti_sp_cw1_2021_22.Models.Animal> Animal { get; set; }
    }
}
