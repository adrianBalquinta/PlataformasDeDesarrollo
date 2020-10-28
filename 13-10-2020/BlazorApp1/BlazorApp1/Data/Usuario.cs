using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Usuario
    {


        public Usuario() { }

        public Usuario(String user, String clave)
        {
            User = user;
            Clave = clave;
        }

        public int Id { get; set; }
        public string User { get; set; }
        public string Clave { get; set; }


    }
}
