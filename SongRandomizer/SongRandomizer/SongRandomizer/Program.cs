using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SongRandomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random((int)DateTime.Now.Ticks);
            var folderPath =  "E:\\";
            var folderPath2 = "C:\\Music\\";
            foreach (string file2 in Directory.EnumerateFiles(folderPath, "*.*"))
            {
                var justFile = file2.Substring(3);
                Console.WriteLine(justFile);
                var newName = justFile;
                while (char.IsDigit(newName[0]))
                {
                    newName = newName.Substring(1);
                }
                try
                {
                    File.Move(file2, string.Format("{0}{1}", folderPath2, newName));
                }
                catch (Exception e)
                {

                }
            }
            int count = 0;
            var dir = Directory.EnumerateFiles(folderPath2, "*.*");
            var count2 = dir.Count();
            var file = dir.ElementAt(random.Next(count2));
            while (count2 != 0)
            {
                var oldsong = file.Substring(9);
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

                Console.WriteLine(newsong);
                dir = Directory.EnumerateFiles(folderPath2, "*.*");
                count2 = dir.Count();
                count++;
                if(count2 != 0)
                    file = dir.ElementAt(random.Next(count2));
            }
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
