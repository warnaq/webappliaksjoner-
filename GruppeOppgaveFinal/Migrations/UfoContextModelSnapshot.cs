﻿// <auto-generated />
using System;
using GruppeOppgaveFinal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GruppeOppgaveFinal.Migrations
{
    [DbContext(typeof(UfoContext))]
    partial class UfoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("GruppeOppgaveFinal.Models.Observasjoner", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Beskrivelse")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("adress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("dato")
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("fullnavn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("land")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("observasjoner");
                });
#pragma warning restore 612, 618
        }
    }
}
