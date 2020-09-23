using System;
using System.Diagnostics.Tracing;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
      
            Console.WriteLine(esBisiesto(IngresarAnioNac("Ingrese año de nacimiento")));
        }

        static int IngresarAnioNac(String mensaje) {
            Console.WriteLine(mensaje);
            String d = Console.ReadLine();
            return int.Parse(d);
        }
        static bool esBisiesto(int valor) {
            if (valor % 4 == 0 & valor % 100 != 0 & valor % 400 == 0)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
