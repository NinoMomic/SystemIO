using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite Vaše ime: ");
            string ime = Console.ReadLine();

            string datoteka = "ime.txt";

            if(File.Exists(datoteka))
            {
                if(!Directory.Exists("backup"))
                {
                    Directory.CreateDirectory("backup");
                }
                File.Copy(datoteka, "backup\\ime_"
                    + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")
                    + ".txt");
                File.Delete(datoteka);
            }
            File.WriteAllText(datoteka, ime);
            Console.ReadKey();
        }
    }
}
