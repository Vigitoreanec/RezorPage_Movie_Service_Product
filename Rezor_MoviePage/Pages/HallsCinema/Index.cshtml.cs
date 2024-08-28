using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rezor_MoviePage.Data;
using Rezor_MoviePage.Model;

namespace Rezor_MoviePage.Pages.HallsCinema
{
    public class IndexModel : PageModel
    {
        private readonly Rezor_MoviePage.Data.MovieContext _context;

        public IndexModel(Rezor_MoviePage.Data.MovieContext context)
        {
            _context = context;
        }

        public IList<HallCinema> HallCinema { get;set; } = default!;

        public async Task OnGetAsync()
        {
            HallCinema = await _context.HallCinema.ToListAsync();
        }
    }
}
