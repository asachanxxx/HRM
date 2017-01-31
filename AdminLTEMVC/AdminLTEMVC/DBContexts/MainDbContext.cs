using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Domain.Navigation;

namespace AdminLTEMVC.DBContexts
{
    public class MainDbContext : DbContext
    {
        public MainDbContext()
            : base("Syscon")
        {

        }

        //Place for the navigation Entities
        public DbSet<MenuItem> MenuItems { get; set; }
    }
}