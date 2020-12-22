using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TareasAPI.Data;
using Model.Entidades;
using Microsoft.EntityFrameworkCore;

namespace TareasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly DataContext _context;
        public UsuarioController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Usuario> Get()
        {
            return _context.Usuarios.ToList();
        }


        [HttpPost]
        public IActionResult Post(Usuario valor)
        {
            var local = _context.Usuarios.Local.FirstOrDefault(e => e.Id.Equals(valor.Id));

            if (local != null)
                _context.Entry(local).State = EntityState.Detached;

            if (valor.Id == 0)
            {
                _context.Entry(valor).State = EntityState.Added;
            }
            else
            {
                _context.Entry(valor).State = EntityState.Modified;
            }
            _context.SaveChanges();
            return Ok(valor);
        }


        [HttpDelete("{valor}")]
        public IActionResult Delete(int valor)
        {


            var eliminado = _context.Usuarios.Local.SingleOrDefault(e => e.Id == valor);

            if (eliminado != null)
            {
               var recursos =  _context.Recursos.Include(i => i.Usuario).ToList();
               foreach (Recurso recurso in recursos)
                {
                    if(recurso.UsuarioId != valor)
                    {
                        _context.Entry(eliminado).State = EntityState.Deleted;
                        _context.SaveChanges();

                        return Ok();
                    }
                    else
                    {
                        return NoContent();
                    }
                }
 
            }
            else
            {
                return NotFound();
            }
            _context.SaveChanges();
            return Ok();
        }




    }
}
