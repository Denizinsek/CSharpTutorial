using System.IO;

namespace CSharpTutorial.FileOperations.Helpers
{
    public class DirectoryHelper
    {
        public static void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }

        public static void DeleteDirectory(string path)
        {
            if (!Directory.Exists(path))
                return;

            Directory.Delete(path);
        }

        public static string[] GetDirectoryFiles(string path)
        {
            return Directory.GetFiles(path);
        }
    }
}
