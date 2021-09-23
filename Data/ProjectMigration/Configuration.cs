using Data.Context;
using System.Data.Entity.Migrations;

namespace Data.OgrenciTakipMigration
{
	public class Configuration : DbMigrationsConfiguration<ProjectContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
			AutomaticMigrationDataLossAllowed = true; //Veri kaybı durumu olsun mu?
			
		}
	}
}
