using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.EntityFrameworkCore;
using Rezor_MoviePage.Data;
using Rezor_MoviePage.Model;
using Rezor_MoviePage.Services.Interfaces;
using Rezor_MoviePage.ViewModel;

namespace Rezor_MoviePage.Pages.Movies
{
    public class EditModel(MovieContext context, IPhotoService photoService) : PageModel
    {
        [BindProperty]
        public MovieViewModel MovieViewModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie =  await context.Movies.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            MovieViewModel = new MovieViewModel 
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Duration = movie.Duration,
                URL = null
            };
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var movie = await context.Movies.FirstOrDefaultAsync(m => m.Id == MovieViewModel.Id);
            if(MovieViewModel.URL is not null)
            {
                photoService.DeletePhotoAsync(movie.URL);
                var addPhotoRezult = await photoService.AddPhotoAsync(MovieViewModel.URL);
                movie.URL = addPhotoRezult.Url.ToString();
            }

            movie.Title = MovieViewModel.Title;
            movie.Description = MovieViewModel.Description;
            movie.Duration = MovieViewModel.Duration;

            await context.SaveChangesAsync();
            //context.Attach(MovieViewModel).State = EntityState.Modified;

            //try
            //{
            //    photoService.AddPhotoAsync();
            //    await context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!MovieExists(MovieViewModel.Id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            return RedirectToPage("./Index");
        }

        //private bool MovieExists(int id)
        //{
        //    return context.Movies.Any(e => e.Id == id);
        //}
    }
}
