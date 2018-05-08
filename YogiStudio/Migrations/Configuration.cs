namespace YogiStudio.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<YogiStudio.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(YogiStudio.Models.ApplicationDbContext context)
        {

            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            if (!context.Users.Any(t => t.UserName == "mjd@gmail.com"))
            {
                var user = new ApplicationUser { UserName = "mjd@gmail.com", Email = "mjd@gmail.com" };
                userManager.Create(user, "goodmorning");
                var userAccount = new Customer { FirstName = "Mario", LastName = "Drago", DateOfBirth = Convert.ToDateTime("11/20/1987"), ApplicationUserId = user.Id };
                context.Customers.AddOrUpdate(userAccount);
                userManager.AddToRole(user.Id, "Instructor");
                context.SaveChanges();
            }

            if (!context.Users.Any(t => t.UserName == "sh@gmail.com"))
            {
                var user = new ApplicationUser { UserName = "sh@gmail.com", Email = "sh@gmail.com" };
                userManager.Create(user, "goodmorning");
                var userAccount = new Customer { FirstName = "Sarah", LastName = "Henry", DateOfBirth = Convert.ToDateTime("11/15/1989"), ApplicationUserId = user.Id };
                context.Customers.AddOrUpdate(userAccount);
                userManager.AddToRole(user.Id, "Instructor");
                context.SaveChanges();
            }

            if (!context.Users.Any(t => t.UserName == "cs@gmail.com"))
            {
                var user = new ApplicationUser { UserName = "cs@gmail.com", Email = "cs@gmail.com" };
                userManager.Create(user, "goodmorning");
                var userAccount = new Customer { FirstName = "Courtney", LastName = "Severson", DateOfBirth = Convert.ToDateTime("03/15/1991"), ApplicationUserId = user.Id };
                context.Customers.AddOrUpdate(userAccount);
                userManager.AddToRole(user.Id, "Instructor");
                context.SaveChanges();
            }

            if (!context.ClassDetails.Any(t => t.ClassName == "Beginner Yoga"))
            {
                var newClass = new ClassDetail { ClassName = "Beginner Yoga", ClassDescription = "Basic class." };
                context.ClassDetails.AddOrUpdate(newClass);
                context.SaveChanges();
            }

            if (!context.ClassDetails.Any(t => t.ClassName == "Intermediate Yoga"))
            {
                var newClass = new ClassDetail { ClassName = "Intermdediate Yoga", ClassDescription = "Slightly harder class." };
                context.ClassDetails.AddOrUpdate(newClass);
                context.SaveChanges();
            }


            if (!context.ClassDetails.Any(t => t.ClassName == "Advanced Yoga"))
            {
                var newClass = new ClassDetail { ClassName = "Advanced Yoga", ClassDescription = "Killer class. User beware." };
                context.ClassDetails.AddOrUpdate(newClass);
                context.SaveChanges();
            }
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
