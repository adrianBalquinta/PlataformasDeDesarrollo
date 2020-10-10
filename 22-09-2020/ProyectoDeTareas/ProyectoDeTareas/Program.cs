using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoDeTareas
{
    class Program
    {
        static void Main(string[] args)
        {

            Insertar();
            ConsultarUsuarios();
            ConsultarTareas();
            ConsultarRecursos();

            //List<Tarea> tareas = new List<Tarea>();

            //tareas.Add(new Tarea("Tarea2", new DateTime(2020, 9, 23), 12, new Recurso(), false));
            //tareas.Add(new Tarea("Tarea3", new DateTime(2020, 9, 24), 12, new Recurso(), false));
            //tareas.Add(new Tarea("Tarea4", new DateTime(2020, 9, 25), 11, new Recurso(), false));
            //tareas.Add(new Tarea("Tarea5", new DateTime(2020, 9, 25), 11, new Recurso(), false));

        }



        static void Insertar()
        {
            var ctx = new TareasDbContext();

            ctx.Usuarios.Add(new Usuario("Usuario1","1111"));
            ctx.Usuarios.Add(new Usuario("Usuario2", "2222"));
            ctx.Usuarios.Add(new Usuario("Usuario3", "3333"));
            ctx.Usuarios.Add(new Usuario("Usuario4", "4444"));
            ctx.Usuarios.Add(new Usuario("Usuario5", "5555"));
            ctx.SaveChanges();
            var listaUsuarios = ctx.Usuarios.ToList();
            Usuario usuario1 = listaUsuarios[0];
            Usuario usuario2 = listaUsuarios[1];
            Usuario usuario3 = listaUsuarios[2];
            Usuario usuario4 = listaUsuarios[3];
            Usuario usuario5 = listaUsuarios[4];


            ctx.Tareas.Add(new Tarea("Tarea1", new DateTime(2020, 10, 23),100,new Recurso("Recurso1", usuario1)));
            ctx.Tareas.Add(new Tarea("Tarea2", new DateTime(2020, 10, 24), 100, new Recurso("Recurso2", usuario2)));
            ctx.Tareas.Add(new Tarea("Tarea3", new DateTime(2020, 10, 25), 100, new Recurso("Recurso3", usuario3)));
            ctx.Tareas.Add(new Tarea("Tarea4", new DateTime(2020, 10, 26), 100, new Recurso("Recurso4", usuario4)));
            ctx.Tareas.Add(new Tarea("Tarea5", new DateTime(2020, 10, 27), 100, new Recurso("Recurso5", usuario5)));

            ctx.SaveChanges();
            var listaRecursos = ctx.Recursos.ToList();
            Recurso recurso1 = listaRecursos[0];
            Recurso recurso2 = listaRecursos[1];
            Recurso recurso3 = listaRecursos[2];
            Recurso recurso4 = listaRecursos[3];
            Recurso recurso5 = listaRecursos[4];

            var listaTareas = ctx.Tareas.ToList();
            Tarea tarea1 = listaTareas[0];
            Tarea tarea2 = listaTareas[1];
            Tarea tarea3 = listaTareas[2];
            Tarea tarea4 = listaTareas[3];
            Tarea tarea5 = listaTareas[4];


            ctx.Detalles.Add(new Detalle(new DateTime(), "30m", recurso1, tarea1));
            ctx.Detalles.Add(new Detalle(new DateTime(), "30m", recurso2, tarea2));
            ctx.Detalles.Add(new Detalle(new DateTime(), "30m", recurso3, tarea3));
            ctx.Detalles.Add(new Detalle(new DateTime(), "30m", recurso4, tarea4));
            ctx.Detalles.Add(new Detalle(new DateTime(), "30m", recurso5, tarea5));


            ctx.SaveChanges();
        }


        static void ConsultarUsuarios()
        {
            var ctx = new TareasDbContext();

            var lista = ctx.Usuarios.ToList();
            foreach (var item in lista)
            {
                Console.WriteLine($"Nombre: {item.User} ({item.Id})");
            }
        }

        static void ConsultarTareas()
        {
            var ctx = new TareasDbContext();

            var lista = ctx.Tareas.ToList();
            foreach (var item in lista)
            {
                Console.WriteLine($"Tareas: {item.Titulo} ({item.Vencimiento})");
            }
        }

        static void ConsultarRecursos()
        {
            var ctx = new TareasDbContext();

            var lista = ctx.Recursos.ToList();
            foreach (var item in lista)
            {
                Console.WriteLine($"Nombre: {item.Nombre} ({item.Id})");
            }
        }

        static void Actualizacion()
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuarios.Where(i => i.Id == 1).Single();
            usuario.User = "Scarlett";

            var usuario2 = ctx.Usuarios.Where(i => i.Id == 3).FirstOrDefault();
            if (usuario2 != null)
            {
                usuario2.User = "Juanse";
            }

            var usuario3 = ctx.Usuarios.Where(i => i.User == "Usuario4" && i.Id < 4).FirstOrDefault();
            if (usuario3 != null)
            {
                usuario3.User = "Francisco";
            }

            var tarea = ctx.Tareas.Where(i => i.Id == 1).Single();
            tarea.Titulo = "Otra tarea";

            var tarea1 = ctx.Tareas.Where(i => i.Id == 3).FirstOrDefault();
            if (tarea1 != null)
            {
                tarea1.Titulo = "Otra cosa";
            }

            var tarea3 = ctx.Tareas.Where(i => i.Titulo == "Tarea4" && i.Id < 4).FirstOrDefault();
            if (tarea3 != null)
            {
                tarea3.Titulo = "Otro";
                tarea3.Vencimiento = tarea3.Vencimiento.AddDays(20);
            }

            ctx.SaveChanges();
        }


        static void Borrado()
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuarios.Where(i => i.Id == 5).Single();
            ctx.Usuarios.Remove(usuario);



            ctx.SaveChanges();
        }

    }
}
