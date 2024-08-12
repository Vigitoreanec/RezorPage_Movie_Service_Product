using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rezor_MoviePage.Data;
using Rezor_MoviePage.Model;

namespace Rezor_MoviePage.Pages.Functions
{
    public class DeleteModel(MovieContext movieContext) : PageModel
    {
        public MovieContext MovieContext { get; set; } = movieContext;
        public Movie? Movie { get; set; }
        public async Task OnGetAsync(int id)
        {
            Movie = await MovieContext.Movies.FirstAsync(x => x.Id == id);
            ViewData["Title"] = $"Удаление {Movie.Title}";
        }
        public async Task<IActionResult> OnPostAsync(int id)
        {
            var movie = await movieContext.Movies.FirstAsync(movie => movie.Id == id);
            movieContext.Movies.Remove(movie);
            await movieContext.SaveChangesAsync();
            return RedirectToPage("/Functions/Services");
        }
    }
}
