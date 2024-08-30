//using LibraryMovie;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rezor_MoviePage.Model;
//using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Rezor_MoviePage.Data;

public class MovieContext (DbContextOptions<MovieContext> options): IdentityDbContext(options)
{
    public DbSet<User> Users {  get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<HallCinema> HallCinema { get; set; }
    public DbSet<Shedule> Shedule { get; set; }

}