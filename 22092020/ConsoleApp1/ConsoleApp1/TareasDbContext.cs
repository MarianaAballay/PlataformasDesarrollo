using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TareasDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Data Source = tareas.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Usuarios>().ToTable("Usuario");
            modelBuilder.Entity<Tareas>().ToTable("Tarea");
            modelBuilder.Entity<Detalles>().ToTable("Detalle");
            modelBuilder.Entity<Recursos>().ToTable("Recurso");
        }

        public DbSet<Usuarios> Usuario { get; set; }
    }
}
