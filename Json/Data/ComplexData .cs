using Newtonsoft.Json;

namespace StulSoft.Json.Data
{
    internal record ComplexData(int? id, object? theObject)
    {
        public static ComplexData? FromJson(string json)
        {
            return JsonConvert.DeserializeObject<ComplexData>(json);
        }
    }
}
