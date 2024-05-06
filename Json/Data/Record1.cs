using Newtonsoft.Json;

namespace StulSoft.Json.Data
{
    internal record Record1(string Name, int Age)
    {
        /// <summary>
        /// Creates the Record1 from a JSON
        /// </summary>
        /// <param name="json"></param>
        /// <returns>The record1 or null</returns>
        public static Record1? FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Record1>(json);
        }
    }
}
