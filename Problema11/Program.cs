using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 
            Console.WriteLine("Dati numarul de numere din secventa: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numerele din secventa pe randuri diferite: ");
            int k=0,inv=0,suma=0;
            while(n!=0)
            {
                k = int.Parse(Console.ReadLine());
                while(k!=0)
                {
                    inv = inv * 10 + k % 10;
                    k /= 10;
                }
                suma += inv;
                n--;
                inv = 0;
            }
            Console.WriteLine($"Suma inverselor numerelor din sir este: {suma} ");
        }
    }
}
