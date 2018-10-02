using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finonacci1
{
    class Recursividad
    {
        public double Fibo(double n)
        {
            double a = 0;
            double b = 1;
            for (double i = 0; i < n; i++)
            {
                double temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
    class Iterativo
    {
        public void FibonacciCiclo()
        {
            
            int a, b, n, i, aux; 
            Console.WriteLine("¿Cuantos números ibonacci quieres?");
            n = int.Parse(Console.ReadLine());
            a = 0;
            b = 1; 
            for (i = 0; i < n; i++)
            {
                aux = a;
                a = b; 
                b = aux + a;
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Recursividad");
            Console.WriteLine("2-Iterativo");
            Console.Write("Elija la opcion: ");
            int Swit = int.Parse(Console.ReadLine());
            switch(Swit)
            {
                case 1:
                    Console.WriteLine("Cuantos numeros quiere? ");
                    int numeros = int.Parse(Console.ReadLine());
                    Recursividad Recu = new Recursividad();
                    for (int i = 0; i < numeros; i++)
                    {
                        Console.WriteLine(Recu.Fibo(i));
                    }
                    Recu.Fibo(numeros);
                    break;
                case 2:
                    Iterativo Ite = new Iterativo();
                    Ite.FibonacciCiclo();
                    break;
                default:
                    Console.WriteLine("<<Presione un enter para salir>>");
                    Console.ReadKey();
                    break;
            }
            
            

            

        }
    }
}
