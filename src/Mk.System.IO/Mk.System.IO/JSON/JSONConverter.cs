using System.IO;
using Newtonsoft.Json;

namespace Mk.System.IO.JSON
{
    public static class JSONConverter
    {
        public static string SerializeObject<T>(T value)
        {
            return JsonConvert.SerializeObject(value);
        }

        public static T DeserializeObject<T>(string filePath)
        {
            
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<T>(json);
            }
            return default;
        }
    }
}
