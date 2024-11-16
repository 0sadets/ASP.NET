

using DataAccess.Entities;
using Microsoft.AspNetCore.Identity;

namespace Book_Shop.Helpers
{
    public enum Roles
    {
        User,
        Admin
    }
    public static class Seeder
    {
        public static async Task SeedRoles(IServiceProvider app)
        {
            var roleManager = app.GetRequiredService<RoleManager<IdentityRole>>();

            foreach (var role in Enum.GetNames(typeof(Roles)))
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }
        public static async Task SeedAdmin(IServiceProvider app)
        {
            var userManager = app.GetRequiredService<UserManager<Customer>>();

            const string USERNAME = "myadmin@myadmin.com";
            const string PASSWORD = "Admin1@";

            var existingUser = userManager.FindByNameAsync(USERNAME).Result;

            if (existingUser == null)
            {
                var user = new Customer
                {
                    UserName = USERNAME,
                    Email = USERNAME,
                };

                var result = userManager.CreateAsync(user, PASSWORD).Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }

    }
}
