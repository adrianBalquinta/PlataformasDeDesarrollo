using System;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Console.WriteLine("Ingrese un numero");
            string valor = Console.ReadLine();
            int numero = 1;
            numero = int.Parse(valor);
           */

            int eleccion = 0;
            int numero = 7;
            int intentos = 1;

            Console.WriteLine("Intente desifrar el número. Tenes 3 intentos");
            eleccion = int.Parse(Console.ReadLine());
           
            while (eleccion != numero && intentos < 3) 
            {
                Console.WriteLine("Intente desifrar el número");
                eleccion = int.Parse(Console.ReadLine());
                intentos++;
            }

            if(eleccion == numero)
            {
                Console.WriteLine("Adivinaste");
            }
            




        }
    }
}
