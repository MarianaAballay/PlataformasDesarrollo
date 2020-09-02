using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secreto = random.Next(10);
            int numero = 0;
            for (int i = 0; i < 3; i++)
            {

                ingreseUnNumero("Ingrese un número, tiene 3 intentos: ", numero);
                if (numero == secreto) break;
            }
            if (numero == secreto)
            {
                Ganaste();
            }
            else
            {
                Perdiste(secreto);
            }

        }

        static void ingreseUnNumero(String mensaje, int numero) {
            Console.WriteLine(mensaje);
            string valor = Console.ReadLine();
            numero = int.Parse(valor);
        }

        static String Ganaste()
        {
            String mensaje = "Ganaste el juego!";
            return mensaje;
        }
        static void Perdiste(int valor)
        {
            Console.WriteLine("Perdiste! el numero secreto es:" + valor);
        }
    }
}
