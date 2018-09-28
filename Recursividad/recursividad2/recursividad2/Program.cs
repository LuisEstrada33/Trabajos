using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Recursividad
{
    class Program

    {

        static int Factorial(int variable)
        {

            if (variable == 0)
                return 1;
            return variable * Factorial(variable - 1);

        }
        static void Main(string[] args)
        {
            Stopwatch tiempo = Stopwatch.StartNew();
            Console.Write("Que numero factorial quiere ver: ");
            int variable = int.Parse(Console.ReadLine());
            Factorial(variable);
            Console.WriteLine("El resultado de {0}! es: {1}", variable, Factorial(variable));
            Console.WriteLine("\nTiempo: " + tiempo.ElapsedMilliseconds.ToString() + " milisegundos");
            Console.ReadKey();
        }
    }
}

