using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nProgram indul!!!!!!!!!!!!!!!");

            JelenlegiFelhasznalo jelenlegifelh = new JelenlegiFelhasznalo(3, 150000);
            Console.WriteLine("\nJelenlegi felhasználó!");
            jelenlegifelh.Nev();

            FelretettFelhasznalo felretettfelh = new FelretettFelhasznalo(3, 1500000);
            Console.WriteLine("\nFélretett felhasználó!");
            felretettfelh.Nev();

            Console.WriteLine("\nProgram vége!!");
            Console.ReadKey();
        }
    }
}
