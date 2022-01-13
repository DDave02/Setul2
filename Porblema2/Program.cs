using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porblema2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
            Console.WriteLine("Dati numarul de numere din secventa: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numerele pe randuri separate: ");
            int k = int.Parse(Console.ReadLine());
            int pozitiv = 0,negativ=0,zero=0;
            n--;
            while (n != 0)
            {
                n--;
                if (k > 0)
                    pozitiv++;
                else
                    if (k < 0)
                    negativ++;
                else zero++;
                k = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"In secventa sunt {pozitiv} numar/numere pozitive, {negativ} numar/numere negative si {zero} numar/numere egale cu 0.");
        }
    }
}
