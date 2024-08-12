//using LibraryMovie;
using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rezor_MoviePage.Data;
using Rezor_MoviePage.Model;

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
        //if (movieContext.Movies.Where(x => x.Title == movie.Title).Count() == 0)
        await movieContext.Movies.AddAsync(movie);
        await movieContext.SaveChangesAsync();

        
        return RedirectToPage("/Functions/Services");
    }
}
