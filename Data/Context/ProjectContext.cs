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
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //sonuna s eklememesini sa�lar
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

			//�l silindi�inde �le Ba�l� �l�elerde silinir
			//modelBuilder.Entity<Il>().HasMany(x => x.Ilce).WithRequired().WillCascadeOnDelete(true);
		}

		//Veritaban�ndaki tablolarla Program�n ba�lant� kuruldu�u yer

		public DbSet<Ornek> Ornek { get; set; }


	}
}