﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Personality.Entities;

#nullable disable

namespace Personality.Migrations
{
    [DbContext(typeof(PersonalityContext))]
    [Migration("20230218190151_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Personality.Entities.Personality", b =>
                {
                    b.Property<Guid>("personalityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("function")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("personalityId");

                    b.ToTable("Personalities");

                    b.HasData(
                        new
                        {
                            personalityId = new Guid("e5ee8b4d-110f-4066-81f2-a03144fbcaaf"),
                            function = "test",
                            name = "Pera",
                            surname = "Peric"
                        },
                        new
                        {
                            personalityId = new Guid("1f6f2144-1655-410c-9e6a-adb3662a46f8"),
                            function = "funkcija",
                            name = "Ivana",
                            surname = "Ivanovic"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
