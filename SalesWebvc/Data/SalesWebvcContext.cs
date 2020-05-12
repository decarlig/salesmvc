using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebvc.Models;

namespace SalesWebvc.Data
{
    public class SalesWebvcContext : DbContext
    {
        public SalesWebvcContext (DbContextOptions<SalesWebvcContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebvc.Models.Denuncia> Denuncia { get; set; }
    }
}
