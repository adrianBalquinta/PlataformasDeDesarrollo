using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDeTareas
{
    class Detalle
    {

        public Detalle(){}

        public Detalle(DateTime fecha, string tiempo, Recurso recurso, Tarea tarea)
        {
            Fecha = fecha;
            Tiempo = tiempo;
            Recurso = recurso;
            Tarea = tarea;
        }
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Tiempo { get; set; }
        public int RecursoId { get; set; }
        public Recurso Recurso { get; set; }
        public int TareaId { get; set; }
        public Tarea Tarea { get; set; }
        
    }
}
