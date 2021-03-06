﻿using System;
using System.Data.Entity;

namespace Sample_EF_RelationsApp
{
    public class DemoDataContext : DbContext
    {
        public DemoDataContext() : base("MyDemoDbContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DemoDataContext>());
            // Write generated SQL to Console
            Database.Log = Console.Write;
        }

        public DbSet<Person> PersonList { get; set; }
        public DbSet<CustomTask> TastList { get; set; }
    }
}
