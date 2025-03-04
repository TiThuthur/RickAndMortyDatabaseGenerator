﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RickAndMortyDatabaseGenerator;

#nullable disable

namespace RickAndMortyDatabaseGenerator.Migrations
{
    [DbContext(typeof(RickAndMortyDBContext))]
    partial class RickAndMortyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("Rick.Character", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Episodes")
                        .HasColumnType("TEXT");

                    b.Property<string>("ErrorMessage")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LocationID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("OriginID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Species")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<string>("URL")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("LocationID");

                    b.HasIndex("OriginID");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("Rick.Location", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Dimension")
                        .HasColumnType("TEXT");

                    b.Property<string>("ErrorMessage")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Residents")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<string>("URL")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Rick.Character", b =>
                {
                    b.HasOne("Rick.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationID");

                    b.HasOne("Rick.Location", "Origin")
                        .WithMany()
                        .HasForeignKey("OriginID");

                    b.Navigation("Location");

                    b.Navigation("Origin");
                });
#pragma warning restore 612, 618
        }
    }
}
