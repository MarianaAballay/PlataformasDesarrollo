using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class RecursoServicio
    {
        public List<Recurso> GetRecursos()
        {
            var bd = new TareasDbContext();

            var list = bd.Recurso.ToList();

            return list;

        }



        private TareasDbContext context;

        public RecursoServicio(TareasDbContext _context)
        {
            context = _context;
        }

        public async Task<Recurso> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GetRecurso(id);
            //return await context.Recurso.Where(i => i.Id == id).SingleAsync();
        }
        public async Task<List<Recurso>> GetAllRecurso()
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GetAllRecurso();
        }
        /*public async Task<List<Recurso>> GetAll()
        {
            return await context.Recurso.ToListAsync();
        }*/

        public async Task<Recurso> SaveRecurso(Recurso valor)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GuardarRecurso(valor);
        }

        /*public async Task<Recurso> Save(Recurso value)
        {
            if (value.Id == 0)
            {
                await context.Recurso.AddAsync(value);
            }
            else
            {
                context.Recurso.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }*/

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Recurso.Where(i => i.Id == id).SingleAsync();
            context.Recurso.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Usuario>> GetUsuarios()
        {
            return await context.Usuario.ToListAsync();
        }

    }
}

