using System;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ident = 000;
            Console.WriteLine("Por favor, ingrese su nombre: ");
            String nombre = Console.ReadLine();
            Console.WriteLine("Por favor, ingrese su nro de cliente (3 dígitos): ");
            String numeros = Console.ReadLine();
            ident = int.Parse(numeros);
            String mensaje;

            if (ident >= 000 & ident <=300)
            {
                mensaje = "Cliente Categoría Azul";
            }
            else if (ident >= 301 && ident <=600)
            {
                mensaje = "Cliente Categoría Gold";
            }
            else {
                mensaje = "Cliente Categoría Platinum";

            }
            Console.WriteLine("Bienvenido " +nombre +" Eres "+ mensaje);
        }
    }
}
