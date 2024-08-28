using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rezor_MoviePage.Data;
using Rezor_MoviePage.Model;

namespace Rezor_MoviePage.Pages.Shedules
{
    public class IndexModel : PageModel
    {
        private readonly Rezor_MoviePage.Data.MovieContext _context;

        public IndexModel(Rezor_MoviePage.Data.MovieContext context)
        {
            _context = context;
        }

        public IList<Shedule> Shedule { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Shedule = await _context.Shedule
                .Include(x => x.Movie)
                .Include(x => x.HallCinema).ToListAsync();
        }
    }
}
