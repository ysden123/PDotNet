using Newtonsoft.Json;

namespace StulSoft.Json.Data
{
    internal record SimpleData(string? name, int? age)
    {
        public static SimpleData? FromJson(string json)
        {
            return JsonConvert.DeserializeObject<SimpleData>(json);
        }
    }
}
