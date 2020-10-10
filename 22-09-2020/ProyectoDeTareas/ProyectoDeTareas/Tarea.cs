using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDeTareas
{
    class Tarea
    {

        public Tarea(){}

        public Tarea(string titulo, DateTime vencimiento, int estimacion, Recurso responsable)
        {
            Titulo = titulo;
            Vencimiento = vencimiento;
            Estimacion = estimacion;
            Responsable = responsable;
            Estado = true;
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public int IdResponsable { get; set; }
        public Recurso Responsable { get; set; }
        public bool Estado { get; set; }
    }
}
