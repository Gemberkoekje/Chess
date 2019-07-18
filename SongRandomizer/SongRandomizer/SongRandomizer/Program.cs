using System;
using System.Collections.Generic;
using System.IO;

namespace SongRandomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random((int)DateTime.Now.Ticks);
            var folderPath = "E:\\";
            var folderPath2 = "C:\\Music\\";
            List<string> fileList = new List<string>();
            foreach (string file in Directory.EnumerateFiles(folderPath, "*.*"))
            {
                var justFile = file.Substring(3);
                Console.WriteLine(justFile);
                var newName = justFile;
                while (char.IsDigit(newName[0]))
                {
                    newName = newName.Substring(1);
                }
                File.Move(file, string.Format("{0}{1}", folderPath2, newName));
                fileList.Add(newName);
            }
            DirectoryInfo di = new DirectoryInfo(folderPath);
            foreach (FileInfo file in di.EnumerateFiles())
            {
                file.Delete();
            }
            int count = 1;
            while (fileList.Count > 0)
            {
                var oldsong = fileList[random.Next(fileList.Count)];
                var newsong = string.Format("{0:0000}{1}", count, oldsong);
                try
                {
                    File.Move(string.Format("{0}{1}", folderPath2, oldsong),
                        string.Format("{0}{1}", folderPath, newsong));
                    File.SetCreationTime(string.Format("{0}{1}", folderPath, newsong),DateTime.Now);
                    File.SetLastWriteTime(string.Format("{0}{1}", folderPath, newsong), DateTime.Now);
                }
                catch (Exception e)
                {

                }

                count++;
                fileList.Remove(oldsong);
                Console.WriteLine(newsong);
            }
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
