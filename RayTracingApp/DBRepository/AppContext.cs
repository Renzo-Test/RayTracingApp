using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBRepository
{
    public class AppContext : DbContext
    {
        public DbSet<Figure> Figures { get; set; }
        public AppContext() : base("RayTracingAppDB") { }
    }
}
