using StulSoft.Json.Data;
using System.Text.Json;

namespace StulSoft.Json
{
    /// <summary>
    /// Usage of the System.Text.Json.
    /// </summary>
    internal class TextJsonTests
    {
        private static readonly JsonSerializerOptions options = new ()
        {
            PropertyNameCaseInsensitive = true
        };

        public static void Test1()
        {
            Console.WriteLine("Test1");
            var json = """
                {
                    "name": "The name",
                    "age": 123
                }
                """;
            Record1? record1 = JsonSerializer.Deserialize<Record1>(json, options);
            Console.WriteLine($"record1={record1}");
        }

        public static void Test2()
        {
            Console.WriteLine("Test2");
            var json = """
                {
                    "name": "The name"
                }
                """;
            Record1? record1 = JsonSerializer.Deserialize<Record1>(json, options);
            Console.WriteLine($"record1={record1}");
        }
    }
}
