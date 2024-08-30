
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rezor_MoviePage.Model;
using Rezor_MoviePage.ViewModel;

namespace Rezor_MoviePage.Pages.Account;

public class RegisterModel(UserManager<User> userManager, SignInManager<User> signInManager) : PageModel
{
    [BindProperty]
    public RegisterViewModel RegisterViewModel { get; set; }
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid || RegisterViewModel is null)
        {
            return Page();
        }
        var user = await userManager.FindByEmailAsync(RegisterViewModel.EmailAddress);
        if (user is not null)
        {
            TempData["Error"] = $"Этот {user.Email} уже Занят";
            return Page();
        }
        if(RegisterViewModel.ConfirmPassword != RegisterViewModel.Password)
        {
            TempData["Error"] = $"Пароли не совпадают";
            return Page();
        }

        var newUser = new User
        {
            Email = RegisterViewModel.EmailAddress,
            UserName = RegisterViewModel.EmailAddress
        };
        var newUserResponse = await userManager.CreateAsync(newUser, RegisterViewModel.Password);

        if (newUserResponse.Succeeded)
        {
            await userManager.AddToRoleAsync(newUser, UserRoles.User);
        }

        return RedirectToPage("../Index");

    }
}
