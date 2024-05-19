﻿// <auto-generated />
using System;
using GameShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameShop.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20240515202211_Initialize")]
    partial class Initialize
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GameShop.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Developer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReleaseDate")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Developer = "FromSoftware",
                            ImageFileName = "EldenRing.jpg",
                            Name = "Elden_Ring",
                            Price = 1300m,
                            Publisher = "FromSoftware,Bandai Namco Entertainment",
                            ReleaseDate = 2022,
                            Type = "Action"
                        },
                        new
                        {
                            Id = 2,
                            Developer = "Valve",
                            ImageFileName = "Portal.jpg",
                            Name = "Portal_2",
                            Price = 150m,
                            Publisher = "Valve",
                            ReleaseDate = 2011,
                            Type = "Puzzle"
                        },
                        new
                        {
                            Id = 3,
                            Developer = "Supergiant Games",
                            ImageFileName = "Hades.jpg",
                            Name = "Hades",
                            Price = 250m,
                            Publisher = "Supergiant Games",
                            ReleaseDate = 2020,
                            Type = "Roguelike"
                        },
                        new
                        {
                            Id = 4,
                            Developer = "One More Level,3D Realms",
                            ImageFileName = "Ghostrunner.jpg",
                            Name = "Ghostrunner",
                            Price = 480m,
                            Publisher = "505 Games",
                            ReleaseDate = 2020,
                            Type = "Action"
                        },
                        new
                        {
                            Id = 5,
                            Developer = "FromSoftware",
                            ImageFileName = "Sekiro.jpg",
                            Name = "Sekiro",
                            Price = 1800m,
                            Publisher = "Activision,FromSoftware",
                            ReleaseDate = 2019,
                            Type = "Action"
                        },
                        new
                        {
                            Id = 6,
                            Developer = "Bethesda Game Studios",
                            ImageFileName = "Skyrim.jpg",
                            Name = "The_Elder_Scrolls_V_Skyrim",
                            Price = 720m,
                            Publisher = "Bethesda Softworks",
                            ReleaseDate = 2016,
                            Type = "Adventure"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
