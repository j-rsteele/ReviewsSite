﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewsSite;

namespace ReviewsSite.Migrations
{
    [DbContext(typeof(Moviecontext))]
    [Migration("20211020184737_UpdatedSeedData")]
    partial class UpdatedSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewsSite.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Actor1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Actor2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Actor3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Actor4"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Actor5"
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Award")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Award = "none",
                            Genre = "Action",
                            Rating = "R",
                            ReleaseYear = 2010,
                            Title = "Movie1a1a2"
                        },
                        new
                        {
                            Id = 2,
                            Award = "none",
                            Genre = "Drama",
                            Rating = "G",
                            ReleaseYear = 2011,
                            Title = "Movie2a3a4"
                        },
                        new
                        {
                            Id = 3,
                            Award = "none",
                            Genre = "Comedy",
                            Rating = "PG",
                            ReleaseYear = 2012,
                            Title = "Movie3a5a2a1"
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.MovieActors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieActors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActorId = 1,
                            MovieId = 1
                        },
                        new
                        {
                            Id = 2,
                            ActorId = 2,
                            MovieId = 1
                        },
                        new
                        {
                            Id = 3,
                            ActorId = 3,
                            MovieId = 2
                        },
                        new
                        {
                            Id = 4,
                            ActorId = 4,
                            MovieId = 2
                        },
                        new
                        {
                            Id = 5,
                            ActorId = 5,
                            MovieId = 3
                        },
                        new
                        {
                            Id = 6,
                            ActorId = 2,
                            MovieId = 3
                        },
                        new
                        {
                            Id = 7,
                            ActorId = 1,
                            MovieId = 3
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "pretty good",
                            MovieId = 1,
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = 2,
                            Comment = "really bad",
                            MovieId = 2,
                            Name = "Jane Doe"
                        },
                        new
                        {
                            Id = 3,
                            Comment = "scary",
                            MovieId = 3,
                            Name = "Scott"
                        },
                        new
                        {
                            Id = 4,
                            Comment = "delicious",
                            MovieId = 2,
                            Name = "Bob"
                        },
                        new
                        {
                            Id = 5,
                            Comment = "supergood",
                            MovieId = 3,
                            Name = "David"
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.MovieActors", b =>
                {
                    b.HasOne("ReviewsSite.Models.Actor", "Actor")
                        .WithMany("Movies")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReviewsSite.Models.Movie", "Movie")
                        .WithMany("Actors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.HasOne("ReviewsSite.Models.Movie", "Movie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("ReviewsSite.Models.Actor", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("ReviewsSite.Models.Movie", b =>
                {
                    b.Navigation("Actors");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
