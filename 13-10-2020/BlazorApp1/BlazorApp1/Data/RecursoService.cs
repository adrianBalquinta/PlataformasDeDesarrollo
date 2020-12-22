using Microsoft.EntityFrameworkCore;
using Model.Entidades;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class RecursoService
    {

        private DataContext context;

        public RecursoService(DataContext _context)
        {
            context = _context;
        }





        public async Task<Recurso> Get(int id)
        {
            var remoteService = RestService.For<IRemoteServices>("https://localhost:44374/api/");
            return await remoteService.GetRecurso(id);
            //return await context.Recursos.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<List<Recurso>> GetAll()
        {
            var remoteService = RestService.For<IRemoteServices>("https://localhost:44374/api/");
            return await remoteService.GetAllRecurso();
            //return await context.Recursos.Include(i=>i.Usuario).ToListAsync();
        }
        /*
        public async Task<List<Usuario>> GetUsuariosRecurso()
        {
            return await context.Usuarios.ToListAsync();
        }

        public async Task<Usuario> GetUsuarioRecurso(int id)
        {
            //var remoteService = RestService.For<IRemoteService>("!-https://localhost:44332/api/");
            //return await remoteService.GetUsuario(id);
            return await context.Usuarios.Where(i => i.Id == id).SingleAsync();
        }*/


        public async Task<Recurso> Save(Recurso value)
        {
            /*
            if (value.Id == 0)
            {
                await context.Recursos.AddAsync(value);
            }
            else
            {
                context.Recursos.Update(value);
            }
            await context.SaveChangesAsync();

            return value;*/
            var remoteService = RestService.For<IRemoteServices>("https://localhost:44374/api/");
            return await remoteService.CrearRecurso(value);
        }

        public async Task<bool> Remove(int id)
        {
            var remoteService = RestService.For<IRemoteServices>("https://localhost:44374/api/");
            return await remoteService.DeleteRecurso(id);
        }


    }
}
