using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculadora calcu = new Calculadora();


            Console.WriteLine(calcu.Sumar(10, 10.50));
            Console.WriteLine(calcu.Dividir(10, 3));
            Console.WriteLine(calcu.Multiplicar(10, 10));
            Console.WriteLine(calcu.Restar(100, 50));
            Console.WriteLine(calcu.Dividir(10, 0));


        }
    }
}
