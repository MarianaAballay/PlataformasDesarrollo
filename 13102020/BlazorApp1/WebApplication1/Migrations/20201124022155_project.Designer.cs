﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(TareasDbContext))]
    [Migration("20201124022155_project")]
    partial class project
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ClassLibrary1.Data.Detalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("recursoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("tareaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("tiempo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("recursoId");

                    b.HasIndex("tareaId");

                    b.ToTable("Detalle");
                });

            modelBuilder.Entity("ClassLibrary1.Data.Recurso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("usuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("usuarioId");

                    b.ToTable("Recurso");
                });

            modelBuilder.Entity("ClassLibrary1.Data.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Estado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Estimacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Vencimiento")
                        .HasColumnType("TEXT");

                    b.Property<int>("responsableId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("responsableId");

                    b.ToTable("Tarea");
                });

            modelBuilder.Entity("ClassLibrary1.Data.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("clave")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("nombre")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ClassLibrary1.Data.Detalle", b =>
                {
                    b.HasOne("ClassLibrary1.Data.Recurso", "recurso")
                        .WithMany()
                        .HasForeignKey("recursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibrary1.Data.Tarea", "tarea")
                        .WithMany()
                        .HasForeignKey("tareaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("recurso");

                    b.Navigation("tarea");
                });

            modelBuilder.Entity("ClassLibrary1.Data.Recurso", b =>
                {
                    b.HasOne("ClassLibrary1.Data.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("usuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ClassLibrary1.Data.Tarea", b =>
                {
                    b.HasOne("ClassLibrary1.Data.Recurso", "Responsable")
                        .WithMany()
                        .HasForeignKey("responsableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Responsable");
                });
#pragma warning restore 612, 618
        }
    }
}
