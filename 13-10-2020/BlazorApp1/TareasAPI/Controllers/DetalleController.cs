using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Entidades;
using TareasAPI.Data;

namespace TareasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalleController : ControllerBase
    {

        private readonly DataContext _context;
        public DetalleController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Detalle> Get()
        {
            return _context.Detalles.Include(i=>i.Recurso).Include(i=>i.Tarea).ToList();
        }

        [HttpPost]
        public IActionResult Post(Detalle valor)
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

    }
}
