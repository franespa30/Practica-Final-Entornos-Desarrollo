using System;

namespace Meses
{
    class Program
    {
        static void Main(string[] args)
        {
            byte dia;
            string mes;
            int año;
            String linea;

            Console.Write("Dime el dia: ");
            linea = Console.ReadLine();

            dia = byte.Parse(linea);

            Console.Write("Dime el mes(Tres primeras letras): ");
            mes = Console.ReadLine();

            Console.Write("Dime el año: ");
            linea = Console.ReadLine();

            año = int.Parse(linea);

            if (mes.Equals("ene") || mes.Equals("feb") || mes.Equals("mar"))
            {
                Console.WriteLine(dia + "/" + mes + "/" + año);
                Console.WriteLine("Corresponde al primer trimestre");
            }
        }
    }
}