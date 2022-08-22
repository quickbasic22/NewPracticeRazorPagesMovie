using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
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
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "PG"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "PG-13"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "The Shawshank Redemption",
                        ReleaseDate = DateTime.Parse("1994-9-14"),
                        Genre = "Drama",
                        Price = 10.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "The Godfather",
                        ReleaseDate = DateTime.Parse("1972-3-24"),
                        Genre = "Crime",
                        Price = 12.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "The Godfather: Part II",
                        ReleaseDate = DateTime.Parse("1974-12-20"),
                        Genre = "Crime",
                        Price = 12.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Drop zone",
                        ReleaseDate = new DateTime(1994, 12, 20),
                        Genre = "Action, Thriller",
                        Price = 1.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Conan",
                        ReleaseDate = new DateTime(1982, 8, 22),
                        Genre = "Action",
                        Price = 1.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Back to the future",
                        ReleaseDate = new DateTime(1985, 3, 15),
                        Genre = "Science Fiction",
                        Price = 1.99M,
                        Rating = "PG"
                    },
                    new Movie
                    {
                        Title = "The good, the bad, and the ugly",
                        ReleaseDate = new DateTime(2017, 1, 9),
                        Genre = "Western",
                        Price = 1.99M,
                        Rating = "R"
                    }

                ) ;
                context.SaveChanges();
            }
        }
    }
}
