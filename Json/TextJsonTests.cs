using Json.Data;
using StulSoft.Json.Data;
using System.Text.Json;

namespace StulSoft.Json
{
    /// <summary>
    /// Usage of the System.Text.Json.
    /// </summary>
    internal class TextJsonTests
    {
        public static readonly JsonSerializerOptions options = new ()
        {
            PropertyNameCaseInsensitive = true
        };

        /// <summary>
        /// Deserialization with standard .Net JSON support.
        /// 
        /// All fields are defined.
        /// </summary>
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

        /// <summary>
        /// Deserialization with standard .Net JSON support.
        /// 
        /// Not all fields are defined.
        /// </summary>
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

        /// <summary>
        /// Deserialization with standard .Net JSON support.
        /// 
        /// Not all fields are defined. The JSON contains one extra field.
        /// </summary>
        public static void Test3()
        {
            Console.WriteLine("Test3");
            var json = """
                {
                    "name": "The name",
                    "nonUsed": "We don't use it"
                }
                """;
            Record1? record1 = JsonSerializer.Deserialize<Record1>(json, options);
            Console.WriteLine($"record1={record1}");
        }

        /// <summary>
        /// <see cref="Config"/>
        /// </summary>
        public static void Test4()
        {
            Console.WriteLine("Test4");
            var json =
                """
                {
                    "name": "Some name",
                    "records":[
                        {
                            "name": "The name 1",
                            "age": 1
                        },
                        {
                            "name": "The name 2",
                            "age": 2
                        }
                    ]
                }
                """;
            Config? config = Config.FromJson(json);
            Console.WriteLine($"config = {config}");
        }
    }
}
