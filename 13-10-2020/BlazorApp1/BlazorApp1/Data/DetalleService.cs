using Microsoft.EntityFrameworkCore;
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



        public async Task<List<Detalle>> GetAll()
        {
            return await context.Detalles.ToListAsync();
        }
    }
}
