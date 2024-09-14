using static System.Net.Mime.MediaTypeNames;

namespace PIO
{
    internal class Program()
    {
        public static void Main()
        {
            Console.WriteLine("==>Program.Main");

            //var dl = new DirList();
            //dl.ListDirs();

            //dl.ListEmptyDirs(@"d:\Photo\YSPhoto\Images\");

            //PathEx01.PlayWithFileName();

            //ConsoleEx1.OutputSameLine();
            //ConsoleEx1.OutputSameLineWithFormat();

            CreateDirs.CreateDirEx01();
        }
    }
}