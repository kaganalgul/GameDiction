using ApplicationCore.Constants;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        readonly IConfiguration _configuration;

        public AppIdentityDbContextSeed(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SeedAsync(RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            if (await roleManager.Roles.AnyAsync() || await userManager.Users.AnyAsync())
            {
                return;
            }

            await roleManager.CreateAsync(new IdentityRole() { Name = AuthorizationConstants.Roles.ADMIN });
            var adminUser = new User() { Email = _configuration["Admin:Email"], UserName = _configuration["Admin:Email"], EmailConfirmed = true };

            await userManager.CreateAsync(adminUser, _configuration["Admin:Sifre"]);
            await userManager.AddToRoleAsync(adminUser, AuthorizationConstants.Roles.ADMIN);

            var demoUser = new User() { Email = _configuration["DemoUser:Email"], UserName = _configuration["DemoUser:Email"], EmailConfirmed = true };
            await userManager.CreateAsync(demoUser, _configuration["DemoUser:Sifre"]);
        }
    }
}