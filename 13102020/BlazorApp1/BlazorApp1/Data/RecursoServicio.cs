using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1.Data;

namespace BlazorApp1.Data
{
    public class RecursoServicio
    {
      
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

        public async Task<Recurso> Remove(int id)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api");

            return await remoteService.DeleteRecurso(id);
        }

        public async Task<List<Usuario>> GetAllUsuario()
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GetAllUsuario();
        }

    }
}

