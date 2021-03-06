﻿using Model.Entidades;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public interface IRemoteServices
    {




        [Get("/Detalle")]
        Task<List<Detalle>> GetAllDetalle();

        [Get("/Detalle/{id}")]
        Task<Detalle> GetDetalle(int id);

        [Get("/Detalle/{id}")]
        Task<List<Detalle>> GetDetalleTarea(int id);

        [Post("/Detalle")]
        Task<Detalle> CrearDetalle(Detalle valor);

        [Delete("/Detalle/{valor}")]
        Task<bool> DeleteDetalle(int valor);


        [Get("/Recurso")]
        Task<List<Recurso>> GetAllRecurso();

        [Get("/Recurso/{id}")]
        Task<Recurso> GetRecurso(int id);

        [Post("/Recurso")]
        Task<Recurso> CrearRecurso(Recurso valor);

        [Delete("/Recurso/{valor}")]
        Task<bool> DeleteRecurso(int valor);

        [Get("/Tarea")]
        Task<List<Tarea>> GetAllTarea();

        [Get("/Tarea/{id}")]
        Task<Tarea> GetTarea(int id);

        [Post("/Tarea")]
        Task<Tarea> CrearTarea(Tarea valor);

        [Delete("/Tarea/{valor}")]
        Task<bool> DeleteTarea(int valor);


        [Get("/Usuario")]
        Task<List<Usuario>> GetAllUsuario();

        [Get("/Usuario/{id}")]
        Task<Usuario> GetUsuario(int id);

        [Post("/Usuario")]
        Task<Usuario> GuardarUsuario(Usuario valor);

        [Delete("/Usuario/{valor}")]
        Task<bool> DeleteUsuario(int valor);

    }
}
