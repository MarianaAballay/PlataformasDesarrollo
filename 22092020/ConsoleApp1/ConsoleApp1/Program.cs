using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Insertar();
            //Borrar();
            Listar();

            Console.WriteLine("Probando programa");

            
        }


        static void Insertar()
        {
            var ctx = new TareasDbContext();
            ctx.Usuario.Add(new Usuarios { Id = 1, nombre = "Mariana", clave = "1234" });

            ctx.Add(new Usuarios() { Id = 2, nombre = "Leonardo", clave = "5656" });
            ctx.Add(new Usuarios() { Id = 3, nombre = "Gervasio", clave = "2323" });
            ctx.Add(new Usuarios() { Id = 4, nombre = "Obdulio", clave = "9865" });
            ctx.Add(new Usuarios() { Id = 5, nombre = "Pancrasio", clave = "1245" });
            ctx.Add(new Usuarios() { Id = 6, nombre = "Giliberto", clave = "2356" });
            ctx.Add(new Usuarios() { Id = 7, nombre = "Torillo", clave = "2574" });

            ctx.SaveChanges();
        }

        static void Actualizar() {

            var ctx = new TareasDbContext();
            var lista = ctx.Usuario.Where(i => i.Id == 1).ToList();
            lista[0].nombre = "Viviana";

            ctx.SaveChanges();

        }

        static void Borrar()
        {
            var ctx = new TareasDbContext();

            var user = ctx.Usuario.Where(i => i.Id == 1).Single();
            ctx.Usuario.Remove(user);

            ctx.SaveChanges();
        }

        static void Listar()
        {
            var ctx = new TareasDbContext();

            var lista = ctx.Usuario.ToList();
            foreach (var users in lista)
            {
                Console.WriteLine($"Nombre: {users.nombre} ({users.Id})");
            }
        }
    }


}
