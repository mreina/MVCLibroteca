﻿// <auto-generated />
using MVCLibroteca.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCLibroteca.Migrations
{
    [DbContext(typeof(ConexionMysqlDataContext))]
    [Migration("20210612184100_migracionAutores")]
    partial class migracionAutores
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("MVCLibroteca.Models.Autores", b =>
                {
                    b.Property<int>("idAutor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("aMaterno")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("aPaterno")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("estatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("nacionalidad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("idAutor");

                    b.ToTable("autores");
                });
#pragma warning restore 612, 618
        }
    }
}