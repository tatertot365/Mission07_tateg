﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_Movies.Models;

namespace Mission06_Movies.Migrations
{
    [DbContext(typeof(AddMovieContext))]
    partial class AddMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_Movies.Models.MovieResponse", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Category = "Animated",
                            Director = "Dean DeBlois",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "How To Train Your Dragon",
                            Year = 2010
                        },
                        new
                        {
                            MovieID = 2,
                            Category = "Animated",
                            Director = "Joel Crawford",
                            Edited = false,
                            LentTo = "",
                            Notes = "Best Movie Ever",
                            Rating = "PG",
                            Title = "Puss In Boots: The Last Wish",
                            Year = 2022
                        },
                        new
                        {
                            MovieID = 3,
                            Category = "Comedy",
                            Director = "Perry Adelin Blake",
                            Edited = false,
                            LentTo = "",
                            Notes = "Award: Most Unfunny",
                            Rating = "PG",
                            Title = "The Master Of Disguise",
                            Year = 2002
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
