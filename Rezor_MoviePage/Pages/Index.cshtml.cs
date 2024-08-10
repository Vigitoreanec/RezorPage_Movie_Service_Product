//using LibraryMovie;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rezor_MoviePage.Data;

namespace Rezor_MoviePage.Pages;

public class IndexModel : PageModel
{
    public MovieContext MovieContext { get; set; }
    public IndexModel(MovieContext movieContext)
    {
        MovieContext = movieContext;
    }
    public void OnGet()
    {
        ViewData["Title"] = "Страница Студии Маникюра"; // Тут CopyRight и Title страницы
    }
    
}
