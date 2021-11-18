using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using WEB_953503_Klimovich.Entities;

namespace WEB_953503_Klimovich.Data
{
    public static class DbInitializer
    {
        private class SeedableUser<T> where T : IdentityUser
        {
            public T User { get; set; }
            public string Password { get; set; }
        }

        private static async void SeedUser<T>(this UserManager<T> userManager, SeedableUser<T> user) where T : IdentityUser
        {
            await userManager.CreateAsync(user.User, user.Password);
        }

        private static async void SeedAdmin<T>(this UserManager<T> userManager, SeedableUser<T> user) where T : IdentityUser
        {
            await userManager.CreateAsync(user.User, user.Password);

            //await userManager.AddToRoleAsync(await userManager.FindByEmailAsync(user.User.Email), "admin");
        }


        private static readonly List<IdentityRole> ROLES = new List<IdentityRole>()
        {
            new IdentityRole()
            {
                Name = "admin",
                NormalizedName = "admin"
            }
        };

        private static readonly List<SeedableUser<ApplicationUser>> ADMINS = new List<SeedableUser<ApplicationUser>>()
        {
            new SeedableUser<ApplicationUser>()
            {
                User = new ApplicationUser{ Email = "artemklimo@gmail.com", UserName = "Artegful" },
                Password = "admin"
            }
        };

        private static readonly List<SeedableUser<ApplicationUser>> USERS = new List<SeedableUser<ApplicationUser>>()
        {
            new SeedableUser<ApplicationUser>()
            {
                User = new ApplicationUser{ Email = "vasya@gmail.com", UserName = "Vasya" },
                Password = "1234"
            },
            new SeedableUser<ApplicationUser>()
            {
                User = new ApplicationUser{ Email = "vanya@gmail.com", UserName = "Vanya" },
                Password = "1234"
            }
        };

        public static async Task Seed(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            context.Database.EnsureCreated();

            PopulateRoles(context, roleManager);

            PopulateUsersIfNeeded(context, userManager);
        }

        private async static void PopulateRoles(ApplicationDbContext context, RoleManager<IdentityRole> roleManager)
        {
            if (context.Roles.Any())
            {
                return;
            }

            foreach (var role in ROLES)
            {
                await roleManager.CreateAsync(role);
            }
        }

        private static void PopulateUsersIfNeeded(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            if (context.Users.Any())
            {
                return;
            }

            foreach (var user in USERS)
            {
                userManager.SeedUser(user);
            }

            foreach (var admin in ADMINS)
            {
                userManager.SeedAdmin(admin);
            }
        }
    }
}
