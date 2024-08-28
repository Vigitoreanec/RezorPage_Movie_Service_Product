using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Rezor_MoviePage.Data;
using Rezor_MoviePage.Model;
using Rezor_MoviePage.Services.Interfaces;
using Rezor_MoviePage.ViewModel;

namespace Rezor_MoviePage.Pages.Movies;

public class CreateModel(MovieContext context, IPhotoService photoService) : PageModel
{
    public IActionResult OnGet()
    {
        return Page();
    }

    [BindProperty]
    public MovieViewModel movieViewModel { get; set; } = default!;

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid || movieViewModel.URL is null)
        {
            return Page();
        }

        var addPhotoRezult = await photoService.AddPhotoAsync(movieViewModel.URL);
        var movie = new Movie
        {
            Title = movieViewModel.Title,
            Description = movieViewModel.Description,
            Duration = default(TimeSpan),
            URL = addPhotoRezult.Url.ToString(),

        };
        context.Movies.Add(movie);
        await context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
