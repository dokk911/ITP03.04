using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console0304Dz1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"E:\C#\FileLesson\FileLesson");

            if (directoryInfo.Exists)
            {
                GetDirectoryInfo(directoryInfo);
            }
            else
            {
                Console.WriteLine("Файл нe существует");
            }

            Console.ReadKey();
        }

        public static void GetDirectoryInfo(DirectoryInfo directoryInfo)
        {
            DirectoryInfo[] subDirectories = directoryInfo.GetDirectories();
            foreach (var item in subDirectories)
            {
                Console.WriteLine("Подпапки:");
                Console.WriteLine(item.Name);
                GetDirectoryInfo(item);
            }

            FileInfo[] files = directoryInfo.GetFiles();
            Console.WriteLine("Файлы:");
            foreach (var item in files)
            {
                if (item.Extension == ".txt" || item.Extension == ".png")
                    Console.WriteLine(item.Name);
            }
        }
    }
}
