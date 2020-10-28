using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareaService
    {
         
        public Task< List<Tarea>> GetTareas()
        {
            List<Tarea> tareas = new List<Tarea>();

            tareas.Add(new Tarea("Tarea1", new DateTime(2020, 10, 23), 100, new Recurso("Recurso1", new Usuario("Usuario1", "1111"))));
            tareas.Add(new Tarea("Tarea2", new DateTime(2020, 10, 24), 100, new Recurso("Recurso2", new Usuario("Usuario2", "2222"))));
            tareas.Add(new Tarea("Tarea3", new DateTime(2020, 10, 25), 100, new Recurso("Recurso3", new Usuario("Usuario3", "3333"))));
            tareas.Add(new Tarea("Tarea4", new DateTime(2020, 10, 26), 100, new Recurso("Recurso4", new Usuario("Usuario4", "4444"))));
            tareas.Add(new Tarea("Tarea5", new DateTime(2020, 10, 27), 100, new Recurso("Recurso5", new Usuario("Usuario5", "5555"))));

            return Task.FromResult(tareas);
        }
    }
}
