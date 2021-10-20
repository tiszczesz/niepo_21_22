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
            Console.WriteLine("\n===================================\n");
            File.WriteAllText("dane2.txt","Długi tekst do pliku\nNowa linia");
            File.WriteAllLines("dane.txt",GetContent());
            Console.WriteLine("Zapisano do pliku (chyba)");
        }

        public static List<string> GetContent() {
            return new List<string> {
                "ala ma kota",
                "to nowa linia tekstu",
                "to nowsza linia tekstu",
                "to najowsza linia tekstu2"
            };
        }

        public static void ReadFile(string path) {
            List<string> content = File.ReadAllLines(path).ToList();
            //string[] content2 = File.ReadAllLines(path);
            foreach (string line in content) {
                Console.WriteLine(line);
            }
        }
    }
}
