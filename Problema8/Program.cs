using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determianti al n-lea numar din sirul lui Fibonacci.
            //Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
            Console.WriteLine("Dati al catelea element din sirul Fibonacci doriti sa aflati: ");
            int n = int.Parse(Console.ReadLine());
            int f1 = 0, f2 = 1, f3 = 1,count;
            if(n==1)
                Console.WriteLine($"Acesta este {f1}");
            if(n==2)
                Console.WriteLine($"Acesta este {f2}");
            if (n == 3)
                Console.WriteLine($"Acesta este {f3}");
            for(count=3; count<=n;count++)
            {
                f3 = f2 + f3;
                f1 = f2;
                f2 = f3- f1;
                Console.WriteLine($"{f3}");
            }
            Console.WriteLine($"Termenul pe pozitia {n} este: {f3} ");
        }
    }
}
