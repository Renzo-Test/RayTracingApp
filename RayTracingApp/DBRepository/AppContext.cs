using Domain;
using System.Data.Entity;

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
		public DbSet<PosisionatedModel> PosisionatedModels { get; set; }
    public DbSet<Log> Logs { get; set; }

		public AppContext(string dbName) : base(dbName) { }
		public AppContext() : base(DefaultDatabase) { }

		public void ClearDBTable(string table)
		{
			Database.ExecuteSqlCommand($"DELETE [{table}]");
		}
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<PosisionatedModel>()
				.HasRequired(pm => pm.ModelScene)
				.WithMany(s => s.PosisionatedModels)
				.HasForeignKey(pm => pm.SceneId);
		}
	}
}
