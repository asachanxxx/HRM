using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Domain.Navigation;
using Domain.System;

namespace AdminLTEMVC.DBContexts
{
    public class MainDbContext : DbContext
    {
        /*
         update-database -ConfigurationTypeName  AdminLTEMVC.DBContexts.MainMigrations.Configuration
         */
        public MainDbContext()
            : base("Syscon")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<MainDbContext>(new CreateDatabaseIfNotExists<MainDbContext>());

        }

        //Place for the navigation Entities
        public DbSet<MenuItems> MenuItemsIns { get; set; }
        public DbSet<Menu> MenuIns { get; set; }

        //Place for the System Entities
        public DbSet<AutoGenerateInfo> AutoGenerateInfoIns { get; set; }
    }
}