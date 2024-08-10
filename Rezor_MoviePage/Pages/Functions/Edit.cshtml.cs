//using LibraryMovie;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rezor_MoviePage.Data;

namespace Rezor_MoviePage.Pages.Functions;

public class EditModel(MovieContext movieContext) : PageModel
{
    [BindProperty]
    public Movie? Movie { get; set; }
    public async void OnGetAsync(int id)
    {
        Movie = await movieContext.Movies.FirstAsync(x => x.Id == id);
        movieContext.SaveChanges();
        ViewData["Title"] = "Обновление фильма";
        //Movie = MovieStorage.Movies.Find(movie => movie.Id == id);
    }
    public async Task<IActionResult> OnPostUpdate(int id)
    {
        if(!ModelState.IsValid)
        {
            return Page();
        }
        var updatevalue = await movieContext.Movies.FirstAsync(movie => movie.Id == id);
        updatevalue.Title = Movie.Title;
        updatevalue.Description = Movie.Description;
        updatevalue.Cost = Movie.Cost;
        updatevalue.URL = Movie.URL;

        await movieContext.SaveChangesAsync();
        return RedirectToPage("/Services");
    }
}
