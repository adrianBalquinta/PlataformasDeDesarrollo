using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDeTareas
{
    class TareasDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite("Data Source=tareas.db");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuario>()
                .ToTable("Usuarios")
                .Property(p => p.Clave);


            modelBuilder.Entity<Tarea>()
                .ToTable("Tareas");



            modelBuilder.Entity<Recurso>()
                .ToTable("Recursos");


            modelBuilder.Entity<Detalle>()
               .ToTable("Detalles");





        }


        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Detalle> Detalles { get; set; }



    }
}
