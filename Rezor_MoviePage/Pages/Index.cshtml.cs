using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Rezor_MoviePage.Pages;

public class IndexModel : PageModel
{
    public void OnGet()
    {
        ViewData["Title"] = "Страница Студии Маникюра"; // Тут CopyRight и Title страницы
    }
}
