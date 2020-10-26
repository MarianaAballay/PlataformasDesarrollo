using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class UsuarioService
    {
        private TareasDbContext context;

        public UsuarioService(TareasDbContext _context)
        {
            context = _context;
        }
        public async Task<List<Usuario>> getAll()
        {
            return await context.Usuario.ToListAsync();
        }

    }
}
