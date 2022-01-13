using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
            Console.WriteLine("Dati numarul numerelor din secventa: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati elementele secventei pe randuri diferite: ");
            int k0 = int.Parse(Console.ReadLine());
            int k1 = int.Parse(Console.ReadLine());
            n -= 2;
            bool cresc = true;
            while(n!=0)
            {
                if (k0 > k1)
                    cresc = false;
                k0 = k1;
                k1 = int.Parse(Console.ReadLine());
                n--;
            }    
            if(cresc)
                Console.WriteLine("Secventa de numere este in ordine crescatoare");
            else
                Console.WriteLine("Secventa de numere nu este in ordine crescatoare");
        }
    }
}
