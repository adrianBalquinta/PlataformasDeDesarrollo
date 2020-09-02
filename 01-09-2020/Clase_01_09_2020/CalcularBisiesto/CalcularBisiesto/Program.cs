using System;

namespace CalcularBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int anyoNacimiento = 0;
            bool respuesta = false;


                IngresarDatos("Ingrese su año de nacimiento: ", out anyoNacimiento);




                if (EsAnyoBisiesto(anyoNacimiento) == true)
                {
                    Console.WriteLine("Es un año bisiesto");
                }
                else
                {
                    Console.WriteLine("No es un año bisiesto");
                }

            



            static void IngresarDatos(string mensaje,out int anyo)
            {
                Console.WriteLine(mensaje);

                anyo = int.Parse(Console.ReadLine());

                
            }

            static bool EsAnyoBisiesto(int anyo)
            {
                
                if((anyo % 4)== 0 && (anyo % 100) != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }


         
        }
    }
}
