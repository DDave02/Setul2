using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
            Console.WriteLine("Dati numarul numerelor din secventa: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele secventei pe randuri diferite: ");
            int k0 = int.Parse(Console.ReadLine());
            int k1 = int.Parse(Console.ReadLine());
            n -= 2;
            bool cresc = true, descr=true;
            while (n != 0)
            {
                if (k0 > k1)
                    cresc = false;
                if (k0 < k1)
                    descr = false;
                k0 = k1;
                k1 = int.Parse(Console.ReadLine());
                n--;
            }
            if (cresc || descr)
                Console.WriteLine("Secventa de numere este monotona");
            else
                Console.WriteLine("Secventa de numere nu este monotona");
        }
    }
}
