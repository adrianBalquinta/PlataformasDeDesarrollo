﻿using System;

namespace Clase_01_09_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int intentos = 0;
            int eleccion = 0;
            Random random = new Random();
            int secreto = random.Next(10);

            do
            {

                Console.WriteLine("Intente adivinar el número. Tiene 3 intentos.");
                eleccion = int.Parse(Console.ReadLine());

                intentos++;

            } while (eleccion != secreto && intentos < 3);


            if(eleccion == secreto)
            {
                Console.WriteLine("Adivinaste el numero es: "+secreto);

            }
            else 
            {

                Console.WriteLine("Perdiste. Elegiste: "+eleccion+". El numero es: "+secreto);

            }







        }
    }
}
