using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rezor_MoviePage.Model;
using Rezor_MoviePage.ViewModel;

namespace Rezor_MoviePage.Pages.Account;

public class LoginModel(UserManager<User> userManager, SignInManager<User> signInManager) : PageModel
{
    [BindProperty]
    public LoginViewModel LoginViewModel { get; set; }
    public async Task<IActionResult> OnPostAsync()
    {
        if(!ModelState.IsValid || LoginViewModel is null)
        {
            return Page();
        }
        var user = await userManager.FindByEmailAsync(LoginViewModel.EmailAddress);
        if (user is not null)
        {
            var passwordCheck = await userManager.CheckPasswordAsync(user, LoginViewModel.Password);
            if (passwordCheck)
            {
                var rezult = await signInManager.PasswordSignInAsync(user, LoginViewModel.Password, false, false);
                if (rezult.Succeeded)
                {
                    return RedirectToPage("../Index");
                }
            }
        }

        TempData["Error"] = "Вы ввели не правильные данные";
        return Page();
    }
}
