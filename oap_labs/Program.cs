using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oap_labs
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //ExceptionTest();
                //ExceptionTest2();
                //ExceptionTest3();
                //ExceptionTest4();
                //ExceptionTest5();
                //ExceptionTest6();
                //ExceptionTest7();
                //ExceptionTest8();
                //ExceptionTest9();
                //ExceptionTest10();
                Console.ReadKey();
            }
            static void ExceptionTest()
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in drives)
                {
                    Console.WriteLine($"Название: {drive.Name}");
                    Console.WriteLine($"Тип: {drive.DriveType}");
                    if (drive.IsReady)
                    {
                        Console.WriteLine($"Объем диска: {drive.TotalSize}");
                        Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
                        Console.WriteLine($"Метка: {drive.VolumeLabel}");
                    }
                    Console.WriteLine();
                }
            }
            static void ExceptionTest2()
            {
                string dirName = "C:\\";
                if (Directory.Exists(dirName))
                {
                    Console.WriteLine("Подкаталоги:");
                    string[] dirs = Directory.GetDirectories(dirName);
                    foreach (string s in dirs)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Файлы:");
                    string[] files = Directory.GetFiles(dirName);
                    foreach (string s in files)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            static void ExceptionTest3()
            {
                string path = @"C:\SomeDir";
                string subpath = @"program\avalon";
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }
                dirInfo.CreateSubdirectory(subpath);
            }
            static void ExceptionTest4()
            {
                string dirName = "C:\\Program Files";
                DirectoryInfo dirInfo = new DirectoryInfo(dirName);
                Console.WriteLine($"Название каталога: {dirInfo.Name}");
                Console.WriteLine($"Полное название каталога: {dirInfo.FullName}");
                Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");
                Console.WriteLine($"Корневой каталог: {dirInfo.Root}");
            }
            static void ExceptionTest5()
            {
                string dirName = @"C:\SomeFolder";
                try
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(dirName);
                    dirInfo.Delete(true);
                    Console.WriteLine("Каталог удален");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            static void ExceptionTest6()
            {
                string oldPath = @"C:\SomeFolder";
                string newPath = @"C:\SomeDir";
                DirectoryInfo dirInfo = new DirectoryInfo(oldPath);
                if (dirInfo.Exists && Directory.Exists(newPath) == false)
                {
                    dirInfo.MoveTo(newPath);
                }
            }
            static void ExceptionTest7()
            {
                string path = @"C:\apache\hta.txt";
                FileInfo fileInf = new FileInfo(path);
                if (fileInf.Exists)
                {
                    Console.WriteLine("Имя файла: {0}", fileInf.Name);
                    Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
                    Console.WriteLine("Размер: {0}", fileInf.Length);
                }
            }
            static void ExceptionTest8()
            {
                string path = @"C:\apache\hta.txt";
                FileInfo fileInf = new FileInfo(path);
                if (fileInf.Exists)
                {
                    fileInf.Delete();

                }
            }
            static void ExceptionTest9()
            {
                string path = @"C:\apache\hta.txt";
                string newPath = @"C:\SomeDir\hta.txt";
                FileInfo fileInf = new FileInfo(path);
                if (fileInf.Exists)
                {
                    fileInf.MoveTo(newPath);
                    
                }
            }
            static void ExceptionTest10()
            {
                string path = @"C:\apache\hta.txt";
                string newPath = @"C:\SomeDir\hta.txt";
                FileInfo fileInf = new FileInfo(path);
                if (fileInf.Exists)
                {
                    fileInf.CopyTo(newPath, true);
                    
                }
            }
        }


        }
        
    }
}