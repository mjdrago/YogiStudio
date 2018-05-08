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

            if (!context.ClassDetails.Any(t => t.ClassName == "Deep Stretch"))
            {
                var newClass = new ClassDetail { ClassName = "Deep Stretch", ClassDescription = "Beginner+ Warms muscles, releases tension, helps flexibility and promotes active recovery." };
                context.ClassDetails.AddOrUpdate(newClass);
                context.SaveChanges();
            }

            if (!context.ClassDetails.Any(t => t.ClassName == "Hot Yoga"))
            {
                var newClass = new ClassDetail { ClassName = "Hot Yoga", ClassDescription = "Beginner+ Builds strength, flexibility and promotes detoxification." };
                context.ClassDetails.AddOrUpdate(newClass);
                context.SaveChanges();
            }


            if (!context.ClassDetails.Any(t => t.ClassName == "Vinyasa"))
            {
                var newClass = new ClassDetail { ClassName = "Vinyasa", ClassDescription = "Intermediate+ Develop strength, flexibility and stamina through balances and inversions that challenge your body." };
                context.ClassDetails.AddOrUpdate(newClass);
                context.SaveChanges();
            }
            if (!context.ClassDetails.Any(t => t.ClassName == "Power Yoga"))
            {
                var newClass = new ClassDetail { ClassName = "Power Yoga", ClassDescription = "Intermediate+ Heated, and strength building. Yoga like you've never experienced. Fast passed to challenge your mind and body." };
                context.ClassDetails.AddOrUpdate(newClass);
                context.SaveChanges();
            }
            if (!context.ClassDetails.Any(t => t.ClassName == "Bootcamp"))
            {
                var newClass = new ClassDetail { ClassName = "Bootcamp", ClassDescription = "Advanced+ Intense, cross training workout, combining Yoga with strength training by using bumbbells and body weight exercises." };
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
