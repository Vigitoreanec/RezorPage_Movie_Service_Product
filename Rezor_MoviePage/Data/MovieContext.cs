//using LibraryMovie;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Rezor_MoviePage.Data;

public class MovieContext (DbContextOptions<MovieContext> options): DbContext(options)
{
    public DbSet<Movie> Movies { get; set; }

}