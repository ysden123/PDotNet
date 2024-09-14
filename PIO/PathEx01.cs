using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIO
{
    internal class PathEx01
    {
        public static void PlayWithFileName()
        {
            Console.WriteLine("==>PlayWithFileName");

            var p = @"c:\work\file.txt";
            Console.WriteLine($"p: {p}");
            Console.WriteLine($"Path.GetDirectoryName(p): {Path.GetDirectoryName(p)}");
            Console.WriteLine($"Path.GetFullPath(p): {Path.GetFullPath(p)}");
            Console.WriteLine($"Path.GetFileName(p): {Path.GetFileName(p)}");
            Console.WriteLine($"Path.GetPathRoot(p): {Path.GetPathRoot(p)}");

            p = @"c:\work\sf1\file.txt";
            Console.WriteLine($"p: {p}");
            Console.WriteLine($"Path.GetDirectoryName(p1): {Path.GetDirectoryName(p)}");
            Console.WriteLine($"Path.GetFullPath(p): {Path.GetFullPath(p)}");
            Console.WriteLine($"Path.GetFileName(p): {Path.GetFileName(p)}");
            Console.WriteLine($"Path.GetPathRoot(p): {Path.GetPathRoot(p)}");

            var dir1 = @"c:\work\";
            var dir2 = @"sd\file.txt";
            Console.WriteLine($"dir1: {dir1}, dir2: {dir2}");
            Console.WriteLine($"Combined: {Path.Combine(dir1,dir2)}");

            dir1 = @"c:\work\\";
            dir2 = @"sd\file.txt";
            Console.WriteLine($"dir1: {dir1}, dir2: {dir2}");
            Console.WriteLine($"Combined: {Path.Combine(dir1,dir2)}");

            dir1 = @"c:\work";
            dir2 = @"sd\file.txt";
            Console.WriteLine($"dir1: {dir1}, dir2: {dir2}");
            Console.WriteLine($"Combined: {Path.Combine(dir1, dir2)}");

            var src = @"c:\work\s1\\";
            Console.WriteLine($"src:{src}, cleared:{src.Replace(@"\\", "")}");

            Console.WriteLine($"""{Path.Combine("path1", "path2", "path3")}""");
            Console.WriteLine($"""{Path.Combine("path1\\", "path2", "path3")}""");
            Console.WriteLine($"""{Path.Combine("path1", "\\path2", "path3")}""");
        }
    }
}
