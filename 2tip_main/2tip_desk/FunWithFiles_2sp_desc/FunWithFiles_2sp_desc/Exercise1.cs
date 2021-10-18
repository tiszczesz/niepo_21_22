using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FunWithFiles_2sp_desc
{
    public class Exercise1
    {
        public static void WorkWithDir() {
            string curDir = Directory.GetCurrentDirectory();
            string p = Environment.CurrentDirectory;
            var files = Directory.GetFiles(curDir);
            Console.WriteLine($"Aktualany katalog: {curDir}");
            Console.WriteLine($"Aktualany katalog: {p}");
            Console.WriteLine("Zbior plikow;");
            foreach (string f in files) {
                Console.WriteLine("\t"+f);
            }
            string path = Environment.GetFolderPath(
                 Environment.SpecialFolder.MyDocuments);

            string path2 = Environment.GetFolderPath(
                Environment.SpecialFolder.DesktopDirectory);
            Console.WriteLine(path);
            Console.WriteLine(path2);

        }
    }
}
