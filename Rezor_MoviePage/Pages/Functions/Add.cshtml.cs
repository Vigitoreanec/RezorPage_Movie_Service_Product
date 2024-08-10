//using LibraryMovie;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rezor_MoviePage.Data;

namespace Rezor_MoviePage.Pages.Functions;

public class AddModel(MovieContext movieContext) : PageModel
{
    
    public void OnGet()
    {
        ViewData["Title"] = "Добавление фильма";
    }
    [BindProperty]
    public Movie? movie {  get; set; }
    public async Task<IActionResult> OnPostAsync()
    {
        //var last = MovieStorage.Movies.Last();
        //movie.Id = last.Id;
        //movie.Id++;
        if (movie is null || !ModelState.IsValid)
        {
            return Page();
        }
        //MovieStorage.Movies.Add(movie);
        await movieContext.Movies.AddAsync(movie);
        await movieContext.SaveChangesAsync();
        return RedirectToPage("/Services");
    }
}
