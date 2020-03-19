using System;

namespace Colores
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            char[] c = { '╝', '╗', '║', '╣' };
            ConsoleColor currentForeground = Console.ForegroundColor;
            ConsoleColor currentBackground = Console.BackgroundColor;

            for (int i = 0; i < 15000; i++)
            {
                Random r = new Random();
                Console.SetCursorPosition(r.Next(80), r.Next(24));
                Console.WriteLine(c[r.Next(4)]);
                Console.ForegroundColor = colors[r.Next(14)];
                //Console.BackgroundColor = colors[r.Next(14)];
            }
            Console.ResetColor();
            Console.SetCursorPosition(80, 24);

        }
    }
}