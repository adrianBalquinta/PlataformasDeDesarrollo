﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDeTareas
{
    class Recurso
    {
        public Recurso() { }

        public Recurso(String nombre, Usuario usuario) 
        {

            Nombre = nombre;
            Usuario = usuario;


        }


        public int Id { get; set; }
        public string Nombre { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

    }
}
