using System;
using System.Collections.Generic;
using System.Linq;
namespace Clase_29
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> par =numeros.Where(num => num % 2 == 0).OrderByDescending(n => n).ToList();

            foreach (var n in par)
                {
                    Console.WriteLine(n);
                }

            /*
             * 
             * List<int> listaDeNumeros = new List<int> { 1,2,3,4,5,6,7,8,9,10 };
            var numerosPar = listaDeNumeros.Where(n => n % 2 == 0).OrderByDescending(n => n);
            foreach (var n in numerosPar)
            {
                Console.WriteLine(n);
            }
             * 
             * 
             * */



        }
    }
}
