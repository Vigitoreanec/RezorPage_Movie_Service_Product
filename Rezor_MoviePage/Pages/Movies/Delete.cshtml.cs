using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rezor_MoviePage.Data;
using Rezor_MoviePage.Model;
using Rezor_MoviePage.Services.Interfaces;


namespace Rezor_MoviePage.Pages.Movies;

public class DeleteModel(MovieContext context, IPhotoService photoService) : PageModel
{
    [BindProperty]
    public Movie Movie { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var movie = await context.Movies.FirstOrDefaultAsync(m => m.Id == id);

        if (movie == null)
        {
            return NotFound();
        }
        else
        {
            Movie = movie;
        }
        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var movie = await context.Movies.FindAsync(id);
        if (movie != null)
        {
            Movie = movie;
            context.Movies.Remove(Movie);
            await context.SaveChangesAsync();
            await photoService.DeletePhotoAsync(movie.URL);
        }

        return RedirectToPage("./Index");
    }
}
