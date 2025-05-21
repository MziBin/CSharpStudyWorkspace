using System.IO;
using Newtonsoft.Json;

namespace MultiLanguageDemo2JSON.Common
{
    public static class JsonHelper
    {
        public static T ReadJsonFile<T>(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return default;
            }

            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
