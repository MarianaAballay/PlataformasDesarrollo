﻿using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1.Data;

namespace BlazorApp1.Data
{
    public class UsuarioServicio
    {
        

        public async Task<Usuario> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GetUsuario(id);
            //return await context.Usuario.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<List<Usuario>> GetAllUsuario()
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GetAllUsuario();
        }

        public async Task<Usuario> SaveUsuario(Usuario valor)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GuardarUsuario(valor);
        }


        /*public async Task<List<Usuario>> GetAll()
        {
            return await context.Usuario.ToListAsync();
        }

        public async Task<Usuario> Save(Usuario value)
        {
            if (value.Id == 0)
            {
                await context.Usuario.AddAsync(value);
            }
            else
            {
                context.Usuario.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }*/

        public async Task<Usuario> Remove(int id)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api");

            return await remoteService.DeleteUsuario(id);
        }

    }
}

