using System;

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

            //Console.WriteLine(secreto);

            do
            {

                IngresarNumero("Intente adivinar el número. Tiene 3 intentos.", out eleccion);
                intentos++;

                

            } while (eleccion != secreto && intentos < 3);


            if(eleccion == secreto)
            {
               Console.WriteLine(Ganaste());

            }
            else 
            {

                Console.WriteLine(Perdiste(eleccion, ref secreto));

            }



            static void IngresarNumero(string mensaje,out int numeroElegido)
            {

                Console.WriteLine(mensaje);
                numeroElegido = int.Parse(Console.ReadLine());
               


            }


            static string Ganaste() 
            {
                string mensaje = "Ganaste";
                
                return mensaje;
            }

            static string Perdiste(int valorElegido, ref int secreto  )
            {
                string mensaje = "Perdiste. Eligiste: "+ valorElegido + "\nEl número era: "+ secreto;

                return mensaje;
            }


        }
    }
}
