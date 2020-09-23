using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Tareas> listatareas = new List<Tareas>();
            listatareas.Add(new Tareas("Ejercicio 1", "01/10/2020", 20, new Recursos(), true));
            listatareas.Add(new Tareas("Ejercicio 2", "08/10/2020", 21, new Recursos(), true));
            listatareas.Add(new Tareas("Ejercicio 3", "15/10/2020", 22, new Recursos(), true));
            listatareas.Add(new Tareas("Ejercicio 4", "24/10/2020", 23, new Recursos(), true));
            listatareas.Add(new Tareas("Ejercicio 5", "31/10/2020", 24, new Recursos(), true));


        }
    }
}
