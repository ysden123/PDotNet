using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MThreading
{
    internal class Service1
    {
        public static void Test1()
        {
            Console.WriteLine("==>MThreading.Test1");
            Console.WriteLine("==>Before Method1");
            Method1().GetAwaiter().GetResult();
            Console.WriteLine("==>After Method1");

            var result1 = Method2().GetAwaiter().GetResult();
            Console.WriteLine($"result1 = {result1}");

            var result2 = Method3().GetAwaiter().GetResult();
            Console.WriteLine($"result2 = {string.Join(", ", result2)}");
        }

        public static void Test2()
        {
            Console.WriteLine("==>MThreading.Test2");

            Console.WriteLine("==>MThreading.Test2 P001");
            var task = Method3();
            Console.WriteLine("==>MThreading.Test2 P002 before wait");
            task.Wait();
            Console.WriteLine("==>MThreading.Test2 P003 after wait");
            var taskResult = task.Result;
            Console.WriteLine($"result = {string.Join(", ", taskResult)}");
        }

        public static async Task Method1()
        {
            Console.WriteLine("==>MThreading.Method1");
            await Task.Run(() =>
            {
                Console.WriteLine("Inside thread.");
                Task.Delay(500).Wait();
                Console.WriteLine("Thread completed.");
            });
        }

        public static async Task<string> Method2()
        {
            Console.WriteLine("==>MThreading.Method2");
            string result = "Started";
            await Task.Run(() =>
            {
                Task.Delay(500).Wait();
                result = "Done";
            });
            return result;
        }

        public static async Task<List<string>> Method3()
        {
            Console.WriteLine("==>MThreading.Method2");
            List<string> result = new List<string>();
            await Task.Run(() =>
            {
                Task.Delay(500).Wait();
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine($"{i}");
                    Task.Delay(500).Wait();
                    result.Add($"Str {i}");
                }
            });
            return result;
        }
    }
}
