using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, numero, cantidad;
            string linea;
            string par = "";
            cantidad = 1;
            Console.WriteLine("¿Cuantos numeros quiere introducir?");
            linea = Console.ReadLine();

            n = int.Parse(linea);

            x = 1;


            while (x <= n)
            {
                Console.WriteLine("Numero " + x + ":");
                linea = Console.ReadLine();
                numero = int.Parse(linea);
                if (numero % 2 == 0 && n != 4)
                {
                    if (n != (n - 1)) { par += linea + " x "; } else { par += linea; }

                    cantidad = numero * cantidad;
                }
                x += 1;
            }
            Console.WriteLine(par + "=" + cantidad);
        }
    }
}
