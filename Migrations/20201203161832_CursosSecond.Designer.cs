﻿// <auto-generated />
using Cursos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Digital_Scilicet.Migrations
{
    [DbContext(typeof(CursosContext))]
    [Migration("20201203161832_CursosSecond")]
    partial class CursosSecond
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Cursos.Models.Curso", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Categoria")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OwnerMail")
                        .HasColumnType("TEXT");

                    b.Property<double>("Precio")
                        .HasColumnType("REAL");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("OwnerMail");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("Cursos.Models.Usuario", b =>
                {
                    b.Property<string>("Mail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Mail");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Cursos.Models.Curso", b =>
                {
                    b.HasOne("Cursos.Models.Usuario", "Owner")
                        .WithMany("Cursos")
                        .HasForeignKey("OwnerMail");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Cursos.Models.Usuario", b =>
                {
                    b.Navigation("Cursos");
                });
#pragma warning restore 612, 618
        }
    }
}
