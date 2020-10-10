using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDeTareas
{
    class Usuario
    {
        public Usuario() { }

        public Usuario( String user, String clave)
        {
            User = user;
            Clave = clave;
        }

        public int Id { get; set; }
        public string User { get; set; }
        public string Clave { get; set; }



    }
}
