namespace NewFinanacialCodeFirst.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using NewFinanacialCodeFirst.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NewFinanacialCodeFirst.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(NewFinanacialCodeFirst.Models.ApplicationDbContext context)
        {
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

            // THIS SECTION IS USED TO SEED USERS
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            if (!context.Users.Any(u => u.Email == "jcheek.producer@gmail.com"))
            {
                var user = new ApplicationUser
                {
                    UserName = "jcheek.producer@gmail.com",
                    Email = "jcheek.producer@gmail.com",
                    FirstName = "James",
                    LastName = "Cheek",
                    FullName = "James Cheek",
                    DisplayName = "JCheek"
                };

                userManager.Create(user, "J@mes1");

                userManager.AddToRoles(user.Id, new string[] { "Admin" });
            }



        }
    }
}
