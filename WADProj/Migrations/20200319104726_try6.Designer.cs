﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WADProj.Models;

namespace WADProj.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20200319104726_try6")]
    partial class try6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WADProj.Models.Comment", b =>
                {
                    b.Property<int>("IdComment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdMovie")
                        .HasColumnType("int");

                    b.Property<int?>("MovieIdMovie")
                        .HasColumnType("int");

                    b.Property<int>("ReviewScore")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("IdComment");

                    b.HasIndex("MovieIdMovie");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("WADProj.Models.Genre", b =>
                {
                    b.Property<int>("IdGenre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdGenre");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("WADProj.Models.Movie", b =>
                {
                    b.Property<int>("IdMovie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Overview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Popularity")
                        .HasColumnType("float");

                    b.Property<string>("PosterPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReviewScore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMovie");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("WADProj.Models.MovieGenre", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("MovieGenre");
                });

            modelBuilder.Entity("WADProj.Models.MovieRating", b =>
                {
                    b.Property<int>("IdMovieRating")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOf1ReviewStars")
                        .HasColumnType("int");

                    b.Property<int>("NumberOf2ReviewStars")
                        .HasColumnType("int");

                    b.Property<int>("NumberOf3ReviewStars")
                        .HasColumnType("int");

                    b.Property<int>("NumberOf4ReviewStars")
                        .HasColumnType("int");

                    b.Property<int>("NumberOf5ReviewStars")
                        .HasColumnType("int");

                    b.HasKey("IdMovieRating");

                    b.HasIndex("MovieId")
                        .IsUnique();

                    b.ToTable("MovieRating");
                });

            modelBuilder.Entity("WADProj.Models.Comment", b =>
                {
                    b.HasOne("WADProj.Models.Movie", "Movie")
                        .WithMany("Comments")
                        .HasForeignKey("MovieIdMovie");
                });

            modelBuilder.Entity("WADProj.Models.MovieGenre", b =>
                {
                    b.HasOne("WADProj.Models.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WADProj.Models.Movie", "Movie")
                        .WithMany("Genres")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WADProj.Models.MovieRating", b =>
                {
                    b.HasOne("WADProj.Models.Movie", "Movie")
                        .WithOne("MovieRating")
                        .HasForeignKey("WADProj.Models.MovieRating", "MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
