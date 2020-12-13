using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ClassLibrary1.Data;

namespace BlazorApp1.Data
{
    public class TareaServicio
    {
        /*public List<Tarea> GetTareas()
        {
            var bd = new TareasDbContext();

            var list = bd.Tarea.ToList();

            return list;
        }




        private TareasDbContext context;

        public TareaServicio(TareasDbContext _context)
        {
            context = _context;
        }*/



        public async Task<Tarea> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:64280/api");
            return await remoteService.GetTarea(id);
        }




        public async Task<List<Tarea>> GetAllTarea()
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GetAllTarea();
        }


        public async Task<Tarea> SaveTarea(Tarea valor)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GuardarTarea(valor);
        }


        public async Task<Tarea> Remove(int id)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api");

            return await remoteService.DeleteTarea(id);
        }
        public async Task<List<Recurso>> GetAllRecurso()
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GetAllRecurso();
        }


    }
}