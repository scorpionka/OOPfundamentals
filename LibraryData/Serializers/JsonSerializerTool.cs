using System.IO;
using System.Text.Json;

namespace LibraryData.Serializers
{
    public static class JsonSerializerTool<T>
    {
        public static void SerializeDocument(T document, int id)
        {
            string path = @"C:\Library";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string fileName = $"{document.GetType().Name}_#{id}.json";
            path = Path.Combine(path, fileName);
            string jsonString = JsonSerializer.Serialize(document);
            File.WriteAllText(path, jsonString);
        }

        public static T DeserializeDocument(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
    }
}
