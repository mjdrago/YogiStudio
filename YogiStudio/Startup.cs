using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using YogiStudio.Models;

[assembly: OwinStartupAttribute(typeof(YogiStudio.Startup))]
namespace YogiStudio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesAndDefaultAdmin();
        }

        private void CreateRolesAndDefaultAdmin()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));

            if (!roleManager.RoleExists("Admin"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                var user = new ApplicationUser();
                user.Email = "admin1@gmail.com";
                user.UserName = "admin1@gmail.com";

                string userPassword = "GoodMorning";

                var checkUser = userManager.Create(user, userPassword);

                if (checkUser.Succeeded)
                {
                    var result1 = userManager.AddToRole(user.Id, "Admin");
                }
            }

            if (!roleManager.RoleExists("Instructor"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Instructor";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("Customer"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Customer";
                roleManager.Create(role);
            }
        }
    }
}
