using Idea_System.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System;
using System.EnterpriseServices;

namespace Idea_System.Migrations
{
    using Idea_System.Models;
    using Microsoft.Ajax.Utilities;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration :
        DbMigrationsConfiguration<Idea_System.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Idea_System.Models.ApplicationDbContext";
        }

        protected override void Seed(Idea_System.Models.ApplicationDbContext context)
        {
        }
    }
}