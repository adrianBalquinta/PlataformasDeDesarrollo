using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDeTareas
{
    class Tareas
    {
        public Tareas(string titulo, DateTime vencimiento, int estimacion, Recursos responsable, bool estado)
        {
            Titulo = titulo;
            Vencimiento = vencimiento;
            Estimacion = estimacion;
            Responsable = responsable;
            Estado = estado;
        }

        public string Titulo { get; set; }
        public DateTime Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public Recursos Responsable { get; set; }
        public bool Estado { get; set; }
    }
}
