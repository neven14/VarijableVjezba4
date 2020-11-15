using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varijable_vjezba_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string znak;

            Console.Write("Unesi znakove: ");

            znak = Console.ReadLine();

            string sVelika = znak.ToUpper();
            
            string sMala = znak.ToLower();

            string sPrvaTri = znak.Substring(0, 3);

            string sZadnjihPet = znak.Substring(znak.Length - 5);

            string s8_11 = znak.Substring(8,11);

 Console.WriteLine(sVelika);
 Console.WriteLine(sMala);
 Console.WriteLine(sPrvaTri);
 Console.WriteLine(sZadnjihPet);
 Console.WriteLine(s8_11);
 Console.ReadKey();
        }
    }
}
