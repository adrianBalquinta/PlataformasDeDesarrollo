using Microsoft.EntityFrameworkCore;
using Model.Entidades;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class DetalleService
    {

        private DataContext context;
        public DetalleService(DataContext _context)
        {
            context = _context;
        }

        public async Task<Detalle> Get(int id)
        {
            var remoteService = RestService.For<IRemoteServices>("https://localhost:44374/api/");
            return await remoteService.GetDetalle(id);
            //return await context.Detalles.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<List<Detalle>> GetAll()
        {
            var remoteService = RestService.For<IRemoteServices>("https://localhost:44374/api/");
            return await remoteService.GetAllDetalle();
            //return await context.Detalles.ToListAsync();
        }
/*
        public async Task<List<Recurso>> GetRecursosDetalle()
        {
            return await context.Recursos.ToListAsync();
        }

        public async Task<List<Tarea>> GetTareasDetalle()
        {
            return await context.Tareas.ToListAsync();
        }

        public async Task<Recurso> GetRecursoDetalle(int id)
        {
            //var remoteService = RestService.For<IRemoteService>("!-https://localhost:44332/api/");
            //return await remoteService.GetUsuario(id);
            return await context.Recursos.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<Tarea> GetTareaDetalle(int id)
        {
            //var remoteService = RestService.For<IRemoteService>("!-https://localhost:44332/api/");
            //return await remoteService.GetUsuario(id);
            return await context.Tareas.Where(i => i.Id == id).SingleAsync();
        }*/


        public async Task<Detalle> Save(Detalle value)
        {
            /*
            if (value.Id == 0)
            {
                await context.Detalles.AddAsync(value);
            }
            else
            {
                context.Detalles.Update(value);
            }
            await context.SaveChangesAsync();

            return value;

            */
            var remoteService = RestService.For<IRemoteServices>("https://localhost:44374/api/");
            return await remoteService.CrearDetalle(value);
        }

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Detalles.Where(i => i.Id == id).SingleAsync();
            context.Detalles.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }

    }
}
