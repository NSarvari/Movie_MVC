﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieReviews.Data;

namespace MovieReviews.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200502200759_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataStructure.Actor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Award")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Residence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("DataStructure.Director", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("DataStructure.Genre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("DataStructure.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Award")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discreption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleasedYear")
                        .HasColumnType("int");

                    b.Property<string>("Scenarist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("DataStructure.MovieActor", b =>
                {
                    b.Property<int>("movieId")
                        .HasColumnType("int");

                    b.Property<int>("actorId")
                        .HasColumnType("int");

                    b.HasKey("movieId", "actorId");

                    b.HasIndex("actorId");

                    b.ToTable("MovieActor");
                });

            modelBuilder.Entity("DataStructure.MovieDirector", b =>
                {
                    b.Property<int>("movieId")
                        .HasColumnType("int");

                    b.Property<int>("directorId")
                        .HasColumnType("int");

                    b.HasKey("movieId", "directorId");

                    b.HasIndex("directorId");

                    b.ToTable("MovieDirector");
                });

            modelBuilder.Entity("DataStructure.MovieGenre", b =>
                {
                    b.Property<int>("movieId")
                        .HasColumnType("int");

                    b.Property<int>("genreId")
                        .HasColumnType("int");

                    b.HasKey("movieId", "genreId");

                    b.HasIndex("genreId");

                    b.ToTable("MovieGenre");
                });

            modelBuilder.Entity("DataStructure.MovieActor", b =>
                {
                    b.HasOne("DataStructure.Actor", "Actor")
                        .WithMany("MovieActors")
                        .HasForeignKey("actorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataStructure.Movie", "Movie")
                        .WithMany("MovieActors")
                        .HasForeignKey("movieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataStructure.MovieDirector", b =>
                {
                    b.HasOne("DataStructure.Director", "Director")
                        .WithMany("MovieDirectors")
                        .HasForeignKey("directorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataStructure.Movie", "Movie")
                        .WithMany("MovieDirectors")
                        .HasForeignKey("movieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataStructure.MovieGenre", b =>
                {
                    b.HasOne("DataStructure.Genre", "Genre")
                        .WithMany("MovieGenres")
                        .HasForeignKey("genreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataStructure.Movie", "Movie")
                        .WithMany("MovieGenres")
                        .HasForeignKey("movieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}