using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Who are You",
                        ReleaseDate = DateTime.Parse("1999-2-15"),
                        Genre = "Romantic Romance",
                        Price = 10.99M,
                        Rating = "R"
    
                    },

                    new Movie
                    {
                        Title = "Who are you 2 ",
                        ReleaseDate = DateTime.Parse("2000-3-13"),
                        Genre = "Romantic Romance",
                        Price = 10.99M,
                        Rating = "R"

                    },

                    new Movie
                    {
                        Title = "Who are You 3",
                        ReleaseDate = DateTime.Parse("2001-2-23"),
                        Genre = "Romantic Romance",
                        Price =10.99M,
                        Rating = "R"

                    },

                    new Movie
                    {
                        Title = "Who am I",
                        ReleaseDate = DateTime.Parse("2001-8-14"),
                        Genre = "Western",
                        Price = 100.19M,
                                Rating = "R"

                    }
                );
                context.SaveChanges();
            }
        }
    }
}