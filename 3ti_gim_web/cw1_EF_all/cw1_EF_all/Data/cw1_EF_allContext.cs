using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cw1_EF_all.Models;

namespace cw1_EF_all.Data
{
    public class cw1_EF_allContext : DbContext
    {
        public cw1_EF_allContext (DbContextOptions<cw1_EF_allContext> options)
            : base(options)
        {
        }

        public DbSet<cw1_EF_all.Models.Animal> Animal { get; set; }
    }
}
