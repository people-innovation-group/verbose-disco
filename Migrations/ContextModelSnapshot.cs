﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace verbose_disco.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("Models.Org", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("boarding")
                        .HasColumnType("INTEGER");

                    b.Property<string>("classification")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("dateLastModified")
                        .HasColumnType("TEXT");

                    b.Property<string>("gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("identifier")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("parentSourcedId")
                        .HasColumnType("TEXT");

                    b.Property<string>("sourcedId")
                        .HasColumnType("TEXT");

                    b.Property<string>("status")
                        .HasColumnType("TEXT");

                    b.Property<string>("type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Orgs");
                });
#pragma warning restore 612, 618
        }
    }
}
