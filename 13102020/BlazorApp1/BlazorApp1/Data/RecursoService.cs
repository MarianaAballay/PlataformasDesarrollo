using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class RecursoService
    {

        private TareasDbContext context;

        public RecursoService(TareasDbContext _context)
        {
            context = _context;
        }
        public async Task<List<Recurso>> getAll()
        {
            return await context.Recurso.ToListAsync();
        }
    }
}
