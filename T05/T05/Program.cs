using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace T05
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Stopwatch tiempo = Stopwatch.StartNew();

           
            
            int suma=0;
            for(int x =0; x<=1000000; x++)
            {
                suma = suma + x;

            }
            Console.WriteLine("La suma es: " + suma);
            Console.Write("TIEMPO: " + tiempo.Elapsed.TotalMilliseconds.ToString() + " milisegundos");
            Console.ReadKey();
        }
    }
}
