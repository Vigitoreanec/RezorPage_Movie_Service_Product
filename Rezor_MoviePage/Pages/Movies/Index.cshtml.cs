
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rezor_MoviePage.Data;
using Rezor_MoviePage.Model;

namespace Rezor_MoviePage.Pages.Movies;

public class IndexModel : PageModel
{
    private readonly MovieContext _context;

    public IndexModel(MovieContext context) => _context = context;

    public IList<Movie> Movie { get;set; } = default!;

    public async Task OnGetAsync()
    {
        Movie = await _context.Movies.ToListAsync();
    }
}
