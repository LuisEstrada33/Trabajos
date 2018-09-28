using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Recursividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch tiempo = Stopwatch.StartNew();
            int resultado = 1;
            Console.Write("Que numero factorial quiere saber: ");
            int variable;
            variable = int.Parse(Console.ReadLine());
            for (int contador = 1; contador < variable + 1; contador++)
                resultado = resultado * contador;
            Console.Write("El resultado de {0}! es: {1}", variable, resultado);
            Console.WriteLine("\nTiempo: " + tiempo.ElapsedMilliseconds.ToString() + " milisegundos");
            Console.ReadKey();
        }
    }
}
