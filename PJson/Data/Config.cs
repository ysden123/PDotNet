using System.Text.Json;

namespace PJson.Data
{
    /// <summary>
    /// Contains an array of an objects.
    /// 
    /// Contains an example of overriding the ToString method.
    /// </summary>
    /// <param name="name">the name</param>
    /// <param name="records">the array of the records</param>
    internal record Config(string name, Record1[] records)
    {
        public static Config? FromJson(string json)
        {
            return JsonSerializer.Deserialize<Config>(json, TextJsonTests.options);
        }

        public override string ToString()
        {
            var result = "{";
            
            result += $"name = {name}, records = [";
            foreach (var record in records)
            {
                result += record;
                result += ", ";
            }
            result = result[0..^2];
            result += "]";

            result += "}";
            return result;
        }
    }
}
