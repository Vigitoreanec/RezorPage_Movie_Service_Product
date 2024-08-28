using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rezor_MoviePage.Data;
using Rezor_MoviePage.Model;

namespace Rezor_MoviePage.Pages.Shedules;

public class EditModel(MovieContext movieContext) : PageModel
{
    private readonly MovieContext _context = movieContext;

    [BindProperty]
    public Shedule Shedule { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var shedule =  await _context.Shedule.FirstOrDefaultAsync(m => m.SheduleId == id);
        if (shedule == null)
        {
            return NotFound();
        }
        Shedule = shedule;
        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Attach(Shedule).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!SheduleExists(Shedule.SheduleId))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return RedirectToPage("./Index");
    }

    private bool SheduleExists(int id)
    {
        return _context.Shedule.Any(e => e.SheduleId == id);
    }
}
