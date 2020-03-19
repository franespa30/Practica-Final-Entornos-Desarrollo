using System;

namespace TryCatch_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant = 5;
            Console.WriteLine("VECTOR de " + cant + " numeros ordenados");
            int[] numeros;
            string linea;
            numeros = new int[cant];
            // llena un vector de numeros por pantalla
            Boolean cargando = true;
            int i = 0;
            int counter = 0;
            string line;


            while (cargando)
            {

                try
                {
                    // Read the file and display it line by line.
                    System.IO.StreamReader file =
                    new System.IO.StreamReader(@"C:\Users\cenec\PC513despues.txt");
                    while ((line = file.ReadLine()) != null)
                    {
                        System.Console.WriteLine(line);
                        counter++;
                    }

                    file.Close();
                    System.Console.WriteLine("There were {0} lines.", counter);
                    // Suspend the screen.
                    System.Console.ReadLine();

                    while (i < numeros.Length)
                    {
                        Console.Write("Ingrese el " + (i + 1) + "nº numero:");
                        linea = Console.ReadLine();
                        numeros[i] = Convert.ToInt32(linea);
                        i++;
                    }
                    cargando = false;
                }

                catch (OverflowException errnum)
                {
                    Console.WriteLine("MAL. El nro. debe ser menor que 100");
                    Console.WriteLine(errnum.Message);
                }
                catch (Exception errfatal)
                {
                    Console.WriteLine("PEOR. FATAL. REMAL. El programa finaliza aqui­.");
                    Console.WriteLine(errfatal.Message);
                    Environment.Exit(2);
                }



            }

            Array.Sort(numeros);

            foreach (int j in numeros)
            {
                System.Console.Write("{0} ", j);
            }
            Console.Write("Presione una tecla para finalizar");
            linea = Console.ReadLine();

        }
    }
}