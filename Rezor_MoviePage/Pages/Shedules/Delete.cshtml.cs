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
    public class DeleteModel : PageModel
    {
        private readonly Rezor_MoviePage.Data.MovieContext _context;

        public DeleteModel(Rezor_MoviePage.Data.MovieContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Shedule Shedule { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shedule = await _context.Shedule.FirstOrDefaultAsync(m => m.SheduleId == id);

            if (shedule == null)
            {
                return NotFound();
            }
            else
            {
                Shedule = shedule;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shedule = await _context.Shedule.FindAsync(id);
            if (shedule != null)
            {

                Shedule = shedule;
                _context.Shedule.Remove(Shedule);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
