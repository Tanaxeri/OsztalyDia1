using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyDia1
{
    class KonzolGUI
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nA program kezdődik...");

            Felhasznalo felhasznalo1 = new Felhasznalo(24, "Maci", "Játék", 1, "Medve");
            Console.WriteLine($"\nFelhasználó fiók");
            felhasznalo1.Nev();


            Edzo edzo1 = new Edzo(321, "Medve", "Maci");
            Console.WriteLine($"\nEdző fiók");
            edzo1.Nev();

            Console.WriteLine("\nA program vége!");
            Console.ReadKey();
        }
    }
}
