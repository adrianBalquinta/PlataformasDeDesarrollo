using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDeTareas
{
    class Tareas
    {

        public string Titulo { get; set; }
        public string Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public Recursos Responsable { get; set; }
        public bool Estado { get; set; }
    }
}
