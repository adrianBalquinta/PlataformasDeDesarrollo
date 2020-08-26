using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Bienvenido al Casino Virtual");
            //Console.WriteLine("*********************************");
            //Console.WriteLine("Elija un numero para del 1 al 10 para apostar en la maquina tragamoneda");
            //string valor = Console.ReadLine();
            //int numero = 1;
            //numero = int.Parse(valor);
            //string mensaje;

            //if (numero == 3)
            //{
            //    mensaje = "Te ganaste $10 pesos";

            //}
            //else if (numero == 6)
            //{

            //    mensaje = "Te ganaste $30 pesos";

            //}
            //else if (numero == 7)
            //{

            //    mensaje = "Te ganaste $80 pesos";

            //}
            //else
            //{
            //    mensaje = "Perdiste. Vuelva a apostar";



            //}
            ///* stack valores. Heap objetos referencia*/
            //Console.WriteLine(mensaje);




            //pedirle al usuario que ingrrese 10 numeros e irlos sumandi a medida que los ingresa, si la suma supera 50 no pedir mas numeros

            Console.WriteLine("Ingrese un numero");
            string valor = Console.ReadLine();
            int numero = 1;
            numero = int.Parse(valor);

            for (int i = 0; i < 10; i++)
            {

                if (numero >= 50)
                {
                    Console.WriteLine("Adios");
                    break;
                }
                else
                {
                    Console.WriteLine("Ingrese otro numero");
                    valor = Console.ReadLine();
                    numero += int.Parse(valor);
                }
            }


        }
    }
}
