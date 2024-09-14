using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PIO
{
    internal class ConsoleEx1
    {
        public static void OutputSameLine()
        {
            Console.WriteLine("==>OutputSameLine");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write($"i={i}");
            }
            Console.WriteLine();
            Console.WriteLine("Done");
        }

        public static void OutputSameLineWithFormat()
        {
            Console.WriteLine("==>OutputSameLineWithFormat");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                var output = $"i={i/10:N}";
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(output);
            }
            Console.WriteLine();
            Console.WriteLine("Done");
        }
    }
}
