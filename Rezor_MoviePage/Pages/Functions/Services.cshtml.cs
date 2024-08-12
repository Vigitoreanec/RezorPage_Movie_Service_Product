//using LibraryMovie;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rezor_MoviePage.Data;
using Rezor_MoviePage.Model;

namespace Rezor_MoviePage.Pages.Functions;


public class PrivacyModel(MovieContext movieContext) : PageModel
{
    public IEnumerable<Movie> movies { get; set; } = movieContext.Movies;
    public MovieContext MovieContext { get; set; } = movieContext;
    
    public void OnGet()
    {
        ViewData["Title"] = "Доступные услуги";
    }

    [BindProperty]
    public string? SearchTitleMovie { get; set; }

    public async Task OnPostAsync()
    {
        ViewData["Title"] = $"Поиск услуги {SearchTitleMovie}";
        if (SearchTitleMovie is null)
            return;
        movies = await movieContext.Movies.Where(x => x.Title.Contains(SearchTitleMovie)).ToListAsync();
    }
}
