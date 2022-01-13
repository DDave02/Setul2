using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    class Problema
    {
        static void Main(string[] args)
        {
            //Calculati suma si produsul numerelor de la 1 la n. 
            Console.WriteLine("Dati numarul n: ");
            int suma = 0, produs = 1, n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                produs *= i;
                suma += i;
            }
            Console.WriteLine($"Suma numerelor pana la {n} este: {suma}");

            if (produs >= 0)
                Console.WriteLine($"Produsul numerelor pana la {n} este: {produs}");
            else
                Console.WriteLine("Produsul nu poate fi calculat in tipul de variabila int");

        }
    }
}
