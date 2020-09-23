using System;
using System.Collections.Generic;

namespace ProyectoDeTareas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Tareas> tareas = new List<Tareas>();

            tareas.Add(new Tareas("Tarea1", new DateTime(2020, 9, 22), 10, new Recursos(), false));
            tareas.Add(new Tareas("Tarea2", new DateTime(2020, 9, 23), 12, new Recursos(), false));
            tareas.Add(new Tareas("Tarea3", new DateTime(2020, 9, 24), 12, new Recursos(), false));
            tareas.Add(new Tareas("Tarea4", new DateTime(2020, 9, 25), 11, new Recursos(), false));
            tareas.Add(new Tareas("Tarea5", new DateTime(2020, 9, 25), 11, new Recursos(), false));

           


        }
    }
}
