using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rezor_MoviePage.Data;
using Rezor_MoviePage.Model;
//using LibraryMovie;

namespace Rezor_MoviePage.Pages.Functions;

public class DetailsModel(MovieContext movieContext) : PageModel
{

    public Shedule? shedule { get; set; }
    public async Task OnGetAsync(int id)
    {
        shedule = await movieContext.Shedule.Include(shedule => shedule.Movie).FirstAsync(shedule => shedule.SheduleId == id);
                
        ViewData["Title"] = $"Услуга  \" {shedule.Movie.Title} \" ";
        //Movie = MovieStorage.Movies.Find(x => x.Id == id);

        //ViewData["Title"] = Movie.Title;
    }
    
}
