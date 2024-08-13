//using LibraryMovie;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rezor_MoviePage.Data;
using Rezor_MoviePage.Model;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Rezor_MoviePage.Pages.Functions;


public class PrivacyModel(MovieContext movieContext) : PageModel
{
    public IEnumerable<Shedule> Shedules { get; set; }
    //public MovieContext MovieContext { get; set; } = movieContext;
    public string? Selected { get; set; }
    public string? MaxDate { get; set; }
    public string? MinDate { get; set; }
    
    public async Task OnGetAsync()
    {
        MinDate = DateTime.Today.ToString("yyyy-MM-dd");
        Selected = DateTime.Today.ToString("yyyy-MM-dd");
        var dtDate = await movieContext.Shedule.MaxAsync(shedule => shedule.StartFilm);
        MaxDate = dtDate.ToString("yyyy-MM-dd");

        Shedules = movieContext.Shedule.Include(shedule => shedule.Movie).Where(x => x.StartFilm.Day == DateTime.Today.Day);
        //MaxDate = (from row in movieContext.Shedule
        //               group row by true into r
        //               select new
        //               {
        //                   max = r.Max(x => x.StartFilm)
        //               }).First().max;

        ViewData["Title"] = "Доступные услуги";
    }

    //------------
    //2
    public async Task OnPostAsync()
    {
        IEnumerable<Shedule> shedulesFiltered = movieContext.Shedule.Include(shedule => shedule.Movie);
        ViewData["Title"] = $"Поиск услуги {SearchTitleMovie}";
        if (SearchDateMovie is not null)
        {
            shedulesFiltered = shedulesFiltered
                .Where(shedule => shedule.StartFilm.Date.Day == SearchDateMovie.Value.Day &&
                        shedule.StartFilm.Date.Month == SearchDateMovie.Value.Month);

            MinDate = DateTime.Today.ToString("yyyy-MM-dd");
            var dtDate = await movieContext.Shedule.MaxAsync(shedule => shedule.StartFilm);
            MaxDate = dtDate.ToString("yyyy-MM-dd");
            Selected = SearchDateMovie.Value.ToString("yyyy-MM-dd");
        }
        if (SearchTitleMovie is not null)
        {
            //if(shedulesFiltered is null)
            //{
            //    shedulesFiltered = movieContext.Shedule
            //        .Where(shedule => shedule.Movie.Title.Contains(SearchTitleMovie));
            //}
            //else
            //{
            //    shedulesFiltered = shedulesFiltered.Where(shedule => shedule.Movie.Title.Contains(SearchTitleMovie));
            //}
            shedulesFiltered = shedulesFiltered.Where(shedule => shedule.Movie.Title.Contains(SearchTitleMovie));
        }
        Shedules = shedulesFiltered;
    }

    [BindProperty]
    public string? SearchTitleMovie { get; set; }

    [BindProperty, DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime? SearchDateMovie { get; set; }

    public string ChangeFormatTime(int i)
    {
        if(i<10)
        {
            return $"0{i}";
        }
        return i.ToString();
    }

    //1
    //public async Task OnPostAsync()
    //{
    //    ViewData["Title"] = $"Поиск услуги {SearchTitleMovie}";
    //    if(SearchDateMovie is not null)
    //    {
    //        Selected = SearchDateMovie.Value.ToString("yyyy-MM-dd");
    //    }
    //    if (SearchTitleMovie is null)
    //    {
    //        return;

    //    }
    //    //movies = movieContext.Movies;
    //    //movies = await movieContext.Movies.Where(x => x.Title.Contains(SearchTitleMovie)).ToListAsync();
    //}
}
