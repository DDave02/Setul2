using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
            Console.WriteLine("Dati numarul numerelor din secventa: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele secventei pe randuri diferite: ");
            int k = int.Parse(Console.ReadLine());
            int min = k, max = k;
            n--;
            while(n!=0)
            {
                if (k < min)
                    min = k;
                if (k > max)
                    max = k;
                n--;
                k = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Numarul minim din sir este {min} iar numarul maxim este {max}.");
        }
    }
}
