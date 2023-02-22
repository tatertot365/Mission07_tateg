using System;
using Microsoft.EntityFrameworkCore;

namespace Mission06_Movies.Models
{
	public class AddMovieContext : DbContext
	{
        // this is the Movie context that allows movies to be saved in the controller
        public AddMovieContext(DbContextOptions<AddMovieContext> options) : base(options)
        {
        }
        // Here the Database is set up to contains objects from the MovieResponse class
        public DbSet<MovieResponse> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
 
        // The database is seeded movie categories and movies
        protected override void OnModelCreating(ModelBuilder mv)
        {
            // movie categories
            mv.Entity<Category>().HasData(
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Comedy"
                },

                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Animated"
                },

                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Horror"
                },

                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Action/Adventure"
                },

                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Drama"
                },

                new Category
                {
                    CategoryID = 6,
                    CategoryName = "Television"
                }

            );

            // movies
            mv.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    MovieID = 1,
                    CategoryID = 2,
                    Title = "How To Train Your Dragon",
                    Year = 2010,
                    Director = "Dean DeBlois",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new MovieResponse
                {
                    MovieID = 2,
                    CategoryID = 2,
                    Title = "Puss In Boots: The Last Wish",
                    Year = 2022,
                    Director = "Joel Crawford",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = "Best Movie Ever"
                },
                new MovieResponse
                {
                    MovieID = 3,
                    CategoryID = 1,
                    Title = "The Master Of Disguise",
                    Year = 2002,
                    Director = "Perry Adelin Blake",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = "Award: Most Unfunny"

                }
            );
        }

    }
}

