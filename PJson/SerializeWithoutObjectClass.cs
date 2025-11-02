using System.Text.Json;

namespace PJson
{
    /// <summary>
    /// Provides functionality to serialize a dictionary into a JSON string without requiring a predefined object class.
    /// </summary>
    /// <remarks>This class demonstrates the serialization of a dictionary containing key-value pairs into a
    /// JSON string using the <see cref="System.Text.Json.JsonSerializer"/>. It is useful for scenarios where the
    /// structure of the data is not known at compile time.</remarks>
    internal class SerializeWithoutObjectClass
    {
        public static void Test1()
        {
            Console.WriteLine("Test1: Deserialization without predefined object class");
            string json = JsonSerializer.Serialize(new Dictionary<string, object?>
            {
                { "FirstName", "John" },
                { "LastName", "Doe" },
                { "Age", 30 },
                { "Email", "tom@google.com" }
            });

            Console.WriteLine(json);
        }
    }
}
