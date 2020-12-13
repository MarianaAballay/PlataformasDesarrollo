using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1.Data;

namespace BlazorApp1.Data
{
    public class DetalleServicio
    {


            public async Task<Detalle> Get(int id)
            {
            //return await context.Detalle.Where(i => i.Id == id).SingleAsync();
                var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
                return await remoteService.GetDetalle(id);
            }

            public async Task<List<Detalle>> GetAllDetalle()
            {
                var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
                return await remoteService.GetAllDetalle();
            }

        public async Task<Detalle> SaveDetalle(Detalle valor) {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GuardarDetalle(valor);
        }

        /*public async Task<List<Detalle>> GetAll()
            {
                return await context.Detalle.ToListAsync();
            }

            public async Task<Detalle> Save(Detalle value)
            {
                if (value.Id == 0)
                {
                    await context.Detalle.AddAsync(value);
                }
                else
                {
                    context.Detalle.Update(value);
                }
                await context.SaveChangesAsync();
                return value;
            }*/

        public async Task<List<Recurso>> GetRecurso()
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GetAllRecurso();
        }


        public async Task<List<Tarea>> GetTarea()
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GetAllTarea();
        }


        public async Task<Detalle> Remove(int id)
            {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api");

            return await remoteService.DeleteDetalle(id);
        }


        }
    }

