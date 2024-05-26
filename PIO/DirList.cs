using System.IO;

namespace PIO
{
    internal class DirList
    {
        public DirList() { }

        private DirectoryInfo? DefineParentDirInfo(DirectoryInfo? di)
        {
            if (di != null)
            {
                return Directory.GetParent(di.FullName);
            }
            else
            {
                return null;
            }
        }

        public void ListDirs()
        {
            Console.WriteLine("==>DirList.ListDirs");
            var enumerationOptions = new EnumerationOptions();
            enumerationOptions.RecurseSubdirectories = true;
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine($"Current directory is : {currentDirectory}");

            var parentDir = Directory.GetParent(currentDirectory);
            parentDir = DefineParentDirInfo(parentDir);
            parentDir = DefineParentDirInfo(parentDir);
            parentDir = DefineParentDirInfo(parentDir);

            string? parent = (parentDir == null) ? null : parentDir.FullName;
            if (parent != null)
            {
                Console.WriteLine($"Parent directory is  : {parent}");
                var directories = Directory.EnumerateDirectories(parent, "*", enumerationOptions);
                foreach (var directory in directories)
                {
                    Console.WriteLine($"{directory}");
                }

                Console.WriteLine("List empty directories.");
                foreach (var directory in directories)
                {
                    if (!Directory.EnumerateFileSystemEntries(directory).Any())
                    {
                        Console.WriteLine($"Empty directory: {directory}");
                    }
                }
            }
        }

        public void ListEmptyDirs(string parent)
        {
            Console.WriteLine($"==>DirList.ListEmptyDirs ({parent})");

            var enumerationOptions = new EnumerationOptions();
            enumerationOptions.RecurseSubdirectories = true;

            var directories = Directory.EnumerateDirectories(parent, "*", enumerationOptions);

            Console.WriteLine($"List empty directories. Total number of directories is {directories.Count()}");
            foreach (var directory in directories)
            {
                if (!Directory.EnumerateFileSystemEntries(directory).Any())
                {
                    Console.WriteLine($"Empty directory: {directory}");
                }
            }
        }
    }
}
