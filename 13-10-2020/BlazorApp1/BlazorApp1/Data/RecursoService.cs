using Microsoft.EntityFrameworkCore;
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


        public async Task<List<Recurso>> GetAll()
        {
            return await context.Recursos.ToListAsync();
        }


    }
}
