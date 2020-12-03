using Microsoft.EntityFrameworkCore;
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class DataContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite("Data Source=C:\\Users\\HUGO\\Desktop\\PlataformaDeDesarrollo\\repository\\13-10-2020" +
                "\\BlazorApp1\\BlazorApp1\\bin\\Debug\\netcoreapp3.1\\tareas.db");

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
