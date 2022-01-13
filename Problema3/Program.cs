using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a.
            //Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 
            Console.WriteLine("Dati numarul numerelor din secventa: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numarul a carei pozitii este cautat: ");
            int a = int.Parse(Console.ReadLine());
            int poz = 0;
            Console.WriteLine("Dati numerele din secventa: ");
            int k = int.Parse(Console.ReadLine());
            bool afisat = false;
            n--;
            if(a==k)
                Console.WriteLine("Pozitia numaruli este: 0");
            else
            {
                while (n!=0)
                {
                    if(a==k)
                    {
                    Console.WriteLine($"Pozitia numarului este: {poz}");
                        afisat = true;
                    break;
                    }
                poz++;
                k = int.Parse(Console.ReadLine());
                n--;
                }
            if(afisat==false)
                {
                    Console.WriteLine("-1");
                }
            }
        }
    }
}
