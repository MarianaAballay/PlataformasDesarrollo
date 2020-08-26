using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroCorrecto = 56;
            int nroCliente = 0;
            while (numeroCorrecto != nroCliente) {
                Console.WriteLine("Ingrese un número entre el 1 y 100. Tiene 3 intentos: ");
                nroCliente = int.Parse(Console.ReadLine());
                if (nroCliente == numeroCorrecto) {
                    Console.WriteLine("Usted ha ganado el juego!");
                }
                else {
                    Console.WriteLine("Seguir intentando!");
                }
                

            }
        }
    }
}
