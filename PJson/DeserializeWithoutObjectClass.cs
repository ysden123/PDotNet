using System.Text.Json;
using System.Text.Json.Nodes;

namespace PJson
{
    /// <summary>
    /// Demonstrates deserialization of a JSON string without using a predefined object class.
    /// </summary>
    /// <remarks>This class contains a method that parses a JSON string and dynamically accesses its
    /// properties using the <see cref="System.Text.Json.JsonDocument"/> and <see cref="System.Text.Json.JsonElement"/>
    /// classes. It showcases how to handle JSON data when the structure is not known at compile time.
    /// See more: <see href="https://rupen-anjaria.medium.com/working-with-json-in-c-using-system-text-json-9b61f95b551e">Working with JSON in C#: Using System.Text.Json</see>
    /// </remarks>
    internal class DeserializeWithoutObjectClass
    {
        private readonly string _sonString = @"{
            ""FirstName"": ""John"",
            ""LastName"": ""Doe"",
            ""Age"": 30,
            ""Email"": ""john.doe@example.com"",
            ""Address"": {
                ""Street"": ""123 Main St"",
                ""City"": ""Anytown"",
                ""ZipCode"": ""12345""
            },
            ""NikNames"": [""Johnny"", ""JD""]
        }";

        public void Test1()
        {
            Console.WriteLine("Test1: Deserialization without predefined object class");
            using JsonDocument doc = JsonDocument.Parse(_sonString);
            // Access to root element
            JsonElement root = doc.RootElement;

            // Access properties dynamically
            string firstName = root.GetProperty("FirstName").GetString() ?? string.Empty;
            Console.WriteLine($"FirstName: {firstName}");

            int age = root.GetProperty("Age").GetInt32();
            Console.WriteLine($"Age: {age}");

            // Access nested object
            JsonElement address = root.GetProperty("Address");
            string city = address.GetProperty("City").GetString() ?? string.Empty;
            Console.WriteLine($"City: {city}");

            // Access array
            int arrayLength = root.GetProperty("NikNames").GetArrayLength();
            Console.WriteLine($"arrayLength = {arrayLength}");
            List<string> nikNames = [];
            foreach (var item in root.GetProperty("NikNames").EnumerateArray())
            {
                nikNames.Add(item.GetString() ?? string.Empty);
            }
            Console.WriteLine("nikNames:");
            foreach (var name in nikNames)
            {
                Console.WriteLine($" - {name}");
            }

            // Access a property that may not exist
            try
            {
                JsonElement phoneNumber = root.GetProperty("PhoneNumber");
            }catch(KeyNotFoundException)
            {
                Console.WriteLine("PhoneNumber property does not exist.");
            }
        }
    }
}
