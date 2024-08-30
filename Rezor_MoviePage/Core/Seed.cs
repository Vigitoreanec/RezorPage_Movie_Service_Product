using Microsoft.AspNetCore.Identity;
using Rezor_MoviePage.Model;

namespace Rezor_MoviePage.Core;

public class Seed
{
    public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
    {
        using var service = applicationBuilder.ApplicationServices.CreateScope();
        var roleManager = service.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
        {
            await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
        }
        if (!await roleManager.RoleExistsAsync(UserRoles.User))
        {
            await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
        }

        var userManager = service.ServiceProvider.GetRequiredService<UserManager<User>>();
        string adminEmail = "VipAdminEmail@mail.ru";
        var Admin = await userManager.FindByEmailAsync(adminEmail);

        if (Admin is null)
        {
            var user = new User
            {
                UserName = "Admin_User",
                Email = adminEmail,
                EmailConfirmed = true,
            };
            await userManager.CreateAsync(user, "Admin1234!");
            await userManager.AddToRoleAsync(user,UserRoles.Admin);
        }

        string userEmail = "UserEmail@mail.ru";
        var User = await userManager.FindByEmailAsync(userEmail);

        if (User is null)
        {
            var newUser = new User
            {
                UserName = "new_User",
                Email = userEmail,
                EmailConfirmed = true,
            };
            await userManager.CreateAsync(newUser, "User1234!");
            await userManager.AddToRoleAsync(newUser, UserRoles.User);
        }
    }
}
