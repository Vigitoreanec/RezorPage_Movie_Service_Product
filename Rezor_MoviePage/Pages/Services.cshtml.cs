//using LibraryMovie;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rezor_MoviePage.Data;

namespace Rezor_MoviePage.Pages
{

    public class PrivacyModel(MovieContext movieContext) : PageModel
    {
        public MovieContext MovieContext { get; set; } = movieContext;
        //public PrivacyModel(MovieContext movieContext) => MovieContext = movieContext;
        public void OnGet()
        {
            ViewData["Title"] = "Доступные услуги";
        }
        
        [BindProperty]
        public Movie? MyServices { get; set; }

        public IActionResult OnPost()
        {
            if(MyServices is not null && ModelState.IsValid)
            {
                //MovieStorage.Movies.Add(MyServices);

                return RedirectToPage("/Services");
            }
            return Page();
        }
    }

}
