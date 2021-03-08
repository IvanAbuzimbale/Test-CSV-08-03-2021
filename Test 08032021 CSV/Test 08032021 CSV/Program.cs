using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test_08032021_CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string datoteka = File.ReadAllText("C:/Users/ivanm/Documents/Primjer.csv");
            
            Console.WriteLine(datoteka.Replace(",", " "));
            File.Copy("C:/Users/ivanm/Documents/Primjer.csv", "C:/Users/ivanm/Documents/Primjer2.csv");
            
            Console.ReadKey();
        }
    }
}
