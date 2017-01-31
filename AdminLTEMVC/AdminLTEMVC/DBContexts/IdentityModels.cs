using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using AdminLTEMVC.Models;

namespace AdminLTEMVC.DBContexts
{
    public class IdentityDB : IdentityDbContext<ApplicationUser>
    {
        public IdentityDB()
            : base("Syscon", throwIfV1Schema: false)
        {
        }

        public static IdentityDB Create()
        {
            return new IdentityDB();
        }
    }
}