using System;
using System.IO;

namespace CSharpTutorial.FileOperations.Helpers
{
    public class FileHelper
    {
        public static void WriteFile(string path, string content)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"{content} - {DateTime.Now:dd.MM.yyyy HH:mm:ss}");
            }
        }

        public static string ReadFile(string path)
        {
            if (!File.Exists(path))
                return null;

            using (StreamReader sr = new StreamReader(path))
            {
                return sr.ReadToEnd();
            }
        }
    }
}
