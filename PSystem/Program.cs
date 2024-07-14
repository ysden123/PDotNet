using System.Collections;

namespace PSystem
{
    internal class Program
    {
        public static void Main()
        {
            ShowEnvVariables();
        }

        private static void ShowEnvVariables()
        {
            Console.WriteLine();
            Console.WriteLine("==>ShowEnvVariables");

            var dic = new SortedDictionary<string, string?>();

            foreach (DictionaryEntry item in Environment.GetEnvironmentVariables())
            {
                string? key = item.Key?.ToString();
                string? value = item.Value?.ToString();

                if (key != null)
                    dic.Add(key, value);
            }

            foreach (var item in dic)
            {
                Console.WriteLine("  {0} = {1}", item.Key, item.Value);
            }
        }
    }
}