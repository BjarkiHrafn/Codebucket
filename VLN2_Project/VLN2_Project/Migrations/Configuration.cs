using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using VLN2_Project.Models;

namespace VLN2_Project.Migrations
{
    using Models.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<VLN2_Project.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(VLN2_Project.Models.ApplicationDbContext context)
        {
            var manager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(
                    new ApplicationDbContext()));

            for (int i = 0; i < 4; i++)
            {
                var user = new ApplicationUser()
                {
                    UserName = string.Format("User{0}", i.ToString())
                };
                manager.Create(user, string.Format("Password{0}", i.ToString()));
            }
            //var projects = new List<Project>();
            //foreach(Project p in projects)
            //{
            //    var projectInDatabase = context.Projects.Where(
            //        s => s._ownerID == p._ownerID && s._title == p._title && s.bytes == p.bytes).SingleOrDefault();
            //    if(projectInDatabase == null)
            //    {
            //        context.Projects.Add(p);
            //    }
            //    context.SaveChanges();
            //}
            
                //  This method will be called after migrating to the latest version.

                //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
                //  to avoid creating duplicate seed data. E.g.
                //
                //    context.People.AddOrUpdate(
                //      p => p.FullName,
                //      new Person { FullName = "Andrew Peters" },
                //      new Person { FullName = "Brice Lambson" },
                //      new Person { FullName = "Rowan Miller" }
                //    );
                //
       }
    }
}
