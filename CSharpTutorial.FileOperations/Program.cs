using CSharpTutorial.FileOperations.Constants;
using CSharpTutorial.FileOperations.Domains.Storages;
using CSharpTutorial.FileOperations.Helpers;
using System;
using System.IO;

namespace CSharpTutorial.FileOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(App.DefaultDirectory, "Text.txt");

            FileHelper.WriteFile(filePath, "PC Opened");

            string fileData = FileHelper.ReadFile(filePath);
            Console.WriteLine(fileData);


            string directoryPath = Path.Combine(App.DefaultDirectory, "New");
            DirectoryHelper.CreateDirectory(directoryPath);
            DirectoryHelper.DeleteDirectory(directoryPath);

            string[] files = DirectoryHelper.GetDirectoryFiles(App.DefaultDirectory);

            Storage[] storages = StorageHelper.GetStorages(App.DefaultDirectory);

            Console.ReadKey();
        }
    }
}
