﻿// <auto-generated />
using System;
using AuthorizedPerson.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AuthorizedPerson.Migrations
{
    [DbContext(typeof(AuthorizedPersonContext))]
    partial class AuthorizedPersonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AuthorizedPerson.Entities.AuthorizedPersonModel", b =>
                {
                    b.Property<Guid>("authorizedPersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("addressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ducumentNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tableNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("authorizedPersonId");

                    b.ToTable("authorizedPeople");

                    b.HasData(
                        new
                        {
                            authorizedPersonId = new Guid("6659fef1-30dc-4c5b-93e6-7f96beb1afef"),
                            addressId = new Guid("e5a687a0-8f6e-4de4-8241-3b0feb36b0fd"),
                            ducumentNumber = "1234453",
                            name = "Amila",
                            surname = "Salihbegovic",
                            tableNumber = "234"
                        },
                        new
                        {
                            authorizedPersonId = new Guid("23f2a8ff-e5df-495b-8c11-0b64016b8551"),
                            addressId = new Guid("fcc355e0-28c8-44f3-8e4b-3c5aff7d3903"),
                            ducumentNumber = "2345323",
                            name = "Almir",
                            surname = "Salihbegovic",
                            tableNumber = "12345"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}