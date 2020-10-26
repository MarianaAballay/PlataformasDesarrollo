using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class ListadoTareaService
    {

        private TareasDbContext context;

        public ListadoTareaService(TareasDbContext _context)
        {
            context = _context;
        }
        public async Task<List<Tarea>> getAll()
        {
            return await context.Tarea.ToListAsync();
        }

    }
}
