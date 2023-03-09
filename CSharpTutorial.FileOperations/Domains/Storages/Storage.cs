namespace CSharpTutorial.FileOperations.Domains.Storages
{
    public class Storage
    {
        public string Directory { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }

        public Storage()
        {

        }

        public Storage(string directory, string name, string extension)
        {
            Directory = directory;
            Name = name;
            Extension = extension;
        }
    }
}
