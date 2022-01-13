using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa.
            //Se considera ca primul element din secventa este pe pozitia 0.
            Console.WriteLine("Dati numarul de numere din secventa: ");
            int n = int.Parse(Console.ReadLine());
            int poz = 0;
            Console.WriteLine("Dati elementele secventei pe randuri diferite: ");
            int k = int.Parse(Console.ReadLine());
            int numPoz = 0;
            n--;
            while(n!=0)
            {
                if (poz == k)
                    numPoz++;
                n--;
                poz++;
                k = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{numPoz} numar/numere au valoarea egala cu pozitia lor din secventa.");
        }
    }
}
