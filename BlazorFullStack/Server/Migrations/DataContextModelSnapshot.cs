﻿// <auto-generated />
using BlazorFullStack.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorFullStack.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("BlazorFullStack.Shared.Comic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Comic");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Marvel"
                        },
                        new
                        {
                            Id = 2,
                            Name = "DC"
                        });
                });

            modelBuilder.Entity("BlazorFullStack.Shared.SuperHero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ComicId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FisrtName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HeroName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ComicId");

                    b.ToTable("SuperHero");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ComicId = 1,
                            FisrtName = "Peter",
                            HeroName = "Homem aranha",
                            LastName = "Park"
                        },
                        new
                        {
                            Id = 2,
                            ComicId = 2,
                            FisrtName = "Bruce",
                            HeroName = "Batman",
                            LastName = "Will"
                        });
                });

            modelBuilder.Entity("BlazorFullStack.Shared.SuperHero", b =>
                {
                    b.HasOne("BlazorFullStack.Shared.Comic", "Comic")
                        .WithMany()
                        .HasForeignKey("ComicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comic");
                });
#pragma warning restore 612, 618
        }
    }
}
