using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Console.WriteLine("Ingrese 10 numeros");
            for (int nro = 0; nro <= 10; nro++){

                String valor = Console.ReadLine();
                int numero = int.Parse(valor);
                contador = contador + numero;

                if (contador >= 50) {
                    Console.WriteLine("La suma es: " + contador + " es igual o mayor a 50");
                    break; 
                }
                
            }

            Console.WriteLine("La suma de los números ingresados es: " + contador);
        }
    }
}
