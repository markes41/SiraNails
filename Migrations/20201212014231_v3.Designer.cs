﻿// <auto-generated />
using Cursos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Digital_Scilicet.Migrations
{
    [DbContext(typeof(CursosContext))]
    [Migration("20201212014231_v3")]
    partial class v3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CursoUsuario", b =>
                {
                    b.Property<long>("CursosID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OwnerMail")
                        .HasColumnType("TEXT");

                    b.HasKey("CursosID", "OwnerMail");

                    b.HasIndex("OwnerMail");

                    b.ToTable("CursoUsuario");
                });

            modelBuilder.Entity("Cursos.Models.Curso", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadVideos")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Categoria")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Idioma")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Precio")
                        .HasColumnType("REAL");

                    b.Property<string>("Subtitulos")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

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

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Rol")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Mail");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("CursoUsuario", b =>
                {
                    b.HasOne("Cursos.Models.Curso", null)
                        .WithMany()
                        .HasForeignKey("CursosID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cursos.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("OwnerMail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}