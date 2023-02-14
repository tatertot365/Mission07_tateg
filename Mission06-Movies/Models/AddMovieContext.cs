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

        // The database is seeded with 3 different movies and contains their information
        protected override void OnModelCreating(ModelBuilder mv)
        {
            mv.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    MovieID = 1,
                    Category = "Animated",
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
                    Category = "Animated",
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
                    Category = "Comedy",
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

