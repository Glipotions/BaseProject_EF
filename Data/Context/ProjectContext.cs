using Data.OgrenciTakipMigration;
using Model;
using Model.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Data.Context
{
	public class ProjectContext : BaseDbContext<ProjectContext, Configuration>
	{
		public ProjectContext()
		{
			Configuration.LazyLoadingEnabled = false;   //
		}

		public ProjectContext(string connectionString) : base(connectionString)
		{
			Configuration.LazyLoadingEnabled = false;
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //sonuna s eklememesini saðlar
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

			//Ýl silindiðinde Ýle Baðlý Ýlçelerde silinir
			//modelBuilder.Entity<Il>().HasMany(x => x.Ilce).WithRequired().WillCascadeOnDelete(true);
		}

		//Veritabanýndaki tablolarla Programýn baðlantý kurulduðu yer

		public DbSet<Ornek> Ornek { get; set; }


	}
}