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
		private const string DefaultDatabase = "RayTracingAppDB";
		public DbSet<Figure> Figures { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Scene> Scenes { get; set; }
        public DbSet<Log> Logs { get; set; }

        public AppContext(string dbName) : base(dbName)  { }
		public AppContext() : base(DefaultDatabase) { }

		public void ClearDBTable(string table) {
            Database.ExecuteSqlCommand($"DELETE [{table}]");
        }
    }
}
