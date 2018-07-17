using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {//создание файла
            Random rnd = new Random();

            //1
            // FileStream fs = new FileStream(@"\\dc\Студенты\ПКО\SMB-172.1\C#\Модуль 11\DanaFile.dat", FileMode.Create);

            //2
            //string FilePath = @"\\dc\Студенты\ПКО\SMB-172.1\C#\Модуль 11\DanaFile" + rnd.Next() + ".txt";
            //using (FileStream fs = new FileStream(FilePath, FileMode.Create))
            //{
            //}
            //FileStream fs2 = new FileStream(FilePath, FileMode.Create, FileAccess.Write);

            //3
            //string FilePath = @"\\dc\Студенты\ПКО\SMB-172.1\C#\Модуль 11\DanaFile" + rnd.Next() + ".txt";
            //using (FileStream fs = new FileStream(FilePath, FileMode.Create))
            //{
            //}
            //FileStream fs2 = new FileStream(FilePath, FileMode.Create, FileAccess.Write, FileShare.None);

            //4
            //string FilePath = @"\\dc\Студенты\ПКО\SMB-172.1\C#\Модуль 11\DanaFile" + rnd.Next() + ".txt";
            //using (FileStream fs4 = new FileStream(FilePath, FileMode.Create, FileAccess.Write, FileShare.Read))
            //{
            //    Console.WriteLine(FilePath);
            //    Thread.Sleep(60000000);
            //    var test = 5555;
            //}

            string FilePath = @"\\dc\Студенты\ПКО\SMB-172.1\C#\Модуль 11\DanaFile" + rnd.Next() + ".txt";
            Console.WriteLine(FilePath);

            /*FileInfo file = new FileInfo(FilePath);
            if (file.Exists)
            {
                //var fata = file.Open(FileMode.Open);
                Console.WriteLine("файл существует");
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length);
                Console.WriteLine(file.Extension);
                Console.WriteLine(file.DirectoryName);
                Console.WriteLine(file.CreationTime);
                Console.WriteLine(file.Attributes);
                file.MoveTo(@"\\dc\Студенты\ПКО\SMB-172.1\C#");
            }
            else
            {

                var fata = file.Open(FileMode.OpenOrCreate);
                Console.WriteLine();
         
             //   Console.WriteLine("файл НЕ существует. будет создан новый вый");

                FileStream f = file.Create();
                f.Close();
            }*/


            //  FilePath = @"\\dc\Студенты\ПКО\SMB-172.1\C#\Модуль 11\DanaFile" + rnd.Next() + ".txt";

            /* DirectoryInfo dir = new DirectoryInfo(".");
             dir.CreateSubdirectory("test");

             dir = new DirectoryInfo(FilePath + @"\newFolderDana");
             dir.Create();

             DirectoryInfo dr = new DirectoryInfo(@"\\dc\Студенты\ПКО\SMB-172.1\C#\Модуль 11");
             DirectoryInfo[]  drs = dr.GetDirectories();
             foreach (DirectoryInfo folder in drs)
             {
                 Console.WriteLine(folder.Name);
                 Console.WriteLine();

             }
             */


            //string way = @"\\dc\Студенты\ПКО\SMB-172.1\C#\Модуль 11\Konstantin\Konstantin_0.txt";
            //using (StreamReader sr = new StreamReader(way, System.Text.Encoding.Default))
            //{
            //    char[] arr = new char[4];
            //    sr.Read(arr, 0, 4);
            //    foreach (var item in arr)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //int i = 0;
            //using (StreamReader sr = new StreamReader(way, System.Text.Encoding.Default))
            //{
            //    string line;
            //    while ((line = sr.ReadLine()) != null)
            //        Console.WriteLine("{0} - {1}", i++, line);
            //}


            string way = @"\\dc\Студенты\ПКО\SMB-172.1\C#\Модуль 11\Konstantin";
            var w = File.Create(way + @"\Dana.txt");
            FileInfo file = new FileInfo(way);
            if (file.Exists)
            {
                using (StreamWriter sw = new StreamWriter(way))
                {
                    for (int q = 0; q < DateTime.Now.Hour; q++)
                    {
                        sw.WriteLine(q);
                    }
                }
            }
            else
            {
                Console.WriteLine("ups");
            }

        }
    }
}
