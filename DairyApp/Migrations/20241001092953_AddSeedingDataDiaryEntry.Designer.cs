﻿// <auto-generated />
using System;
using DairyApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DairyApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241001092953_AddSeedingDataDiaryEntry")]
    partial class AddSeedingDataDiaryEntry
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DairyApp.Models.DiaryEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DiaryEntries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2024, 10, 1, 2, 29, 53, 295, DateTimeKind.Local).AddTicks(9963),
                            Description = "Description 1",
                            Title = "Title 1"
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2024, 10, 1, 2, 29, 53, 296, DateTimeKind.Local).AddTicks(19),
                            Description = "Description 2",
                            Title = "Title 2"
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(2024, 10, 1, 2, 29, 53, 296, DateTimeKind.Local).AddTicks(21),
                            Description = "Description 3",
                            Title = "Title 3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
