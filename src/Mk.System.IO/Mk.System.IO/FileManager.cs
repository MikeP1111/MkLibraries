using System.IO;

namespace Mk.System.IO
{
    public static class FileManager
    {
        public static void SaveFile(string content, string path, string fileName)
        {
            File.WriteAllText(path + fileName, content);
        }

        public static string ReadFile(string filePath)
        {
            if (File.Exists(filePath))
                return File.ReadAllText(filePath);
            return string.Empty;
        }
    }
}
