
using Microsoft.EntityFrameworkCore;
using movieStore.Models;

public class MovieDbContext : DbContext
{

    public MovieDbContext (DbContextOptions<MovieDbContext> options) : base (options)
    {
    }

    public DbSet<Movie> Movies {get; set;}

}