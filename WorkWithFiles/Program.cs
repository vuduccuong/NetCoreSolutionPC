using System;
using System.IO;
using System.Reflection;

namespace WorkWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathSource = @"C:\VisualProject\NetCoreSolution\Tham chiếu và tham trị.txt";
            var path = Path.GetFullPath(pathSource);
            var currentPath = Directory.GetCurrentDirectory().Replace(@"\bin\Debug\net5.0",@"\");
            if (File.Exists(path))
            {
                File.Copy(path, Path.Combine(currentPath,"upload.txt"), true);
                Console.WriteLine("coppied!");
            }
            
        }
    }
}
