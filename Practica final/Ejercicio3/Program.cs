using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            string linea, op;

            Console.WriteLine("Dime un numero:");
            linea = Console.ReadLine();
            num1 = double.Parse(linea);

            Console.WriteLine("Dime un operador:");
            op = Console.ReadLine();


            Console.WriteLine("Dime un segundo numero:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            switch (op)
            {
                case "+":
                    Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                    break;

                case "-":
                    Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                    break;

                case "*":
                    Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("No se puede dividir entre 0");
                    }
                    else
                    {
                        Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                    }

                    break;
                default:
                    Console.WriteLine("Operador no valido");
                    break;
            }
        }
    }
}
