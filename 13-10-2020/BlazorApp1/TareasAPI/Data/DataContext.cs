using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareasAPI.Data
{
    public class DataContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite("Data Source=tareas.db");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*

            modelBuilder.Entity<Usuario>()
                .ToTable("Usuarios")
                .Property(p => p.Clave);


            modelBuilder.Entity<Tarea>()
                .ToTable("Tareas");



            modelBuilder.Entity<Recurso>()
                .ToTable("Recursos");


            modelBuilder.Entity<Detalle>()
               .ToTable("Detalles");


            */


        }




    }
}
