using System.Data.Entity;

namespace Sample_EF_RelationsApp
{
    public class DemoDataContext : DbContext
    {
        public DemoDataContext() : base("MyDemoDbContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DemoDataContext>());
        }

        public DbSet<Person> PersonList { get; set; }
    }
}
