﻿// <auto-generated />
using CalculadoraApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CalculadoraApi.Migrations
{
    [DbContext(typeof(CalculadoraContext))]
    [Migration("20241014204334_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("CalculadoraApi.Models.Calculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Operacion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Operando1")
                        .HasColumnType("REAL");

                    b.Property<double>("Operando2")
                        .HasColumnType("REAL");

                    b.Property<string>("Resultado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Calculos");
                });
#pragma warning restore 612, 618
        }
    }
}
