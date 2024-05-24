using Newtonsoft.Json;
using StulSoft.Json.Data;

namespace StulSoft.Json
{
    internal record Record2(string Name, int? Age)
    {
        /// <summary>
        /// Creates the Record2 from a JSON.
        /// </summary>
        /// <param name="json"></param>
        /// <returns>Record2 or null</returns>
        public static Record2? FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Record2>(json);
        }
    }

    /// <summary>
    /// Demonstartes some manipulations with JSON.
    /// </summary>
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Logging Program");

            Test1();
            Test2();
            Test3();
            Test4();
            Test5();
        }

        private static void Test1()
        {
            Console.WriteLine("==>Test1");
            var json = @"{""name"": ""name"", ""age"": 123}";
            var rec1 = JsonConvert.DeserializeObject<Record1>(json);
            Console.WriteLine($"rec1: {rec1}");

            var rec2 = Record1.FromJson(json);
            Console.WriteLine($"rec2: {rec2}");

            var rec3 = Record2.FromJson(json);
            Console.WriteLine($"rec3: {rec3}");
        }

        private static void Test2()
        {
            Console.WriteLine("==>Test2");
            var json = @"{""name"":""the name""}";
            var rec1 = Record1.FromJson(json);
            if (rec1 != null)
            {
                Console.WriteLine($"rec1: {rec1}");
                var aTestResult = rec1.Age == null;
                Console.WriteLine($"aTestResult: {aTestResult}");
            }
        }

        private static void Test3()
        {
            Console.WriteLine("==>Test3");
            var json = @"{""name"":""the name"", ""age"":65, ""nonDefined"": ""test""}";
            var rec2 = JsonConvert.DeserializeObject<Record2>(json);
            Console.WriteLine($"rec2: {rec2}");
        }

        private static void Test4()
        {
            Console.WriteLine("==>Test4");
            TextJsonTests.Test1();
            TextJsonTests.Test2();
        }

        private static void Test5()
        {
            Console.WriteLine("==>Test5");
            string json = """
                {
                    "id": 1,
                    "theObject":{
                        "name": "It is an object",
                        "age": 54
                    }
                }
                """;

            ComplexData? cd1 = ComplexData.FromJson(json);
            Console.WriteLine(cd1);

            if (cd1 != null){
                SimpleData? sd1 = JsonConvert.DeserializeObject<SimpleData>(JsonConvert.SerializeObject(cd1.theObject));
                Console.WriteLine($"sd1: {sd1}");
            }
            

            ComplexData cd2 = new ComplexData(1, new SimpleData("a name 22", 43));
            string json2 = JsonConvert.SerializeObject(cd2);
            Console.WriteLine($"json2: {json2}");
        }
    }
}