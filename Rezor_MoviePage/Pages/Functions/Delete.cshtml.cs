//using LibraryMovie;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rezor_MoviePage.Data;


namespace Rezor_MoviePage.Pages.Functions;

public class DeleteModel(MovieContext movieContext) : PageModel
{
    public Movie? Movie { get; set; }
    public async Task OnGetAsync(int id)
    {
        //Movie = MovieStorage.Movies.Find(movie => movie.Id == id);
        Movie = await movieContext.Movies.FirstAsync(movie => movie.Id == id);
        ViewData["Title"] = "Удаление фильма";
    }

    public async Task<IActionResult> OnPostDeleteAsync(int id)
    {
        var movie = await movieContext.Movies.FirstAsync(movie => movie.Id == id);
        movieContext.Movies.Remove(movie);
        await movieContext.SaveChangesAsync();
        return RedirectToPage("/Services");
    }
}
