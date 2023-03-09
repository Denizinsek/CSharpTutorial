using CSharpTutorial.FileOperations.Domains.Storages;
using System.Collections.Generic;
using System.IO;

namespace CSharpTutorial.FileOperations.Helpers
{
    public class StorageHelper
    {
        public static Storage[] GetStorages(string path)
        {
            List<Storage> storages = new List<Storage>();
            string[] files = DirectoryHelper.GetDirectoryFiles(path);

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                string fileName = Path.GetFileNameWithoutExtension(file);

                storages.Add(new Storage(fileInfo.Directory.Name, fileName, fileInfo.Extension));
            }

            return storages.ToArray();
        }
    }
}
