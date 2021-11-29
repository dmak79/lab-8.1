using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab8._1  //вывод на консоль подкаталогов в заданной директории
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = "E:\\ITMO_BIM_2021-2022\\";

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.ReadKey();
            }
        }
    }
}
