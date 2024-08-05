
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LibraryMovie;

namespace Rezor_MoviePage.Pages
{
    public class PrivacyModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Title"] = "Доступные услуги";
        }
        [BindProperty]
        public Movie? MyServices { get; set; }

        public void OnPost()
        {
            if(MyServices is not null && ModelState.IsValid)
            {
                MovieStorage.Movies.Add(MyServices);
                //return RedirectToPage("/Services");
            }
            //return Page();
        }
    }

}
