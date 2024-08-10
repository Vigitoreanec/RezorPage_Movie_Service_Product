using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rezor_MoviePage.Data;
//using LibraryMovie;

namespace Rezor_MoviePage.Pages.Functions;

public class DetailsModel(MovieContext movieContext) : PageModel
{

    public Movie? Movie { get; set; }
    public async Task OnGetAsync(int id)
    {
        Movie = await movieContext.Movies.FirstAsync(x => x.Id == id);
                
        ViewData["Title"] = $"Услуга  \" {Movie.Title} \" ";
        //Movie = MovieStorage.Movies.Find(x => x.Id == id);

        //ViewData["Title"] = Movie.Title;
    }
    
}
