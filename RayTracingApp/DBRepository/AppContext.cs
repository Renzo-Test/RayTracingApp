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
        public DbSet<Material> Materials { get; set; }
        public AppContext(string dbName) : base(dbName) { }

        public void ClearDBTable(string table) {
            Database.ExecuteSqlCommand($"TRUNCATE TABLE [{table}]");
        }
    }
}
