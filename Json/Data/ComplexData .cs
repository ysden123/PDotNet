using Newtonsoft.Json;

namespace StulSoft.Json.Data
{
    /// <summary>
    /// Contains the general object.
    /// </summary>
    /// <param name="id">The ID</param>
    /// <param name="theObject">The object</param>
    internal record ComplexData(int? id, object? theObject)
    {
        public static ComplexData? FromJson(string json)
        {
            return JsonConvert.DeserializeObject<ComplexData>(json);
        }
    }
}
