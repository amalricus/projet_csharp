using Library.DataAcess.Dao;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Library.DataAcess.Dao
{
    public class MyDataContext : DbContext
    {
        public MyDataContext() : base("name=FormationTestEntity")
        {
        }

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(dbModelBuilder);
        }

        public DbSet<Capteur> Capteur { get; set; }
        public DbSet<Releve> Releve { get; set; }
        public DbSet<Ligne> Ligne { get; set; }
    }
}
