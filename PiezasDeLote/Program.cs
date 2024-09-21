using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiezasDeLote
{
    public class Program
    {
        static void Main(string[] args)
        {
            const double longitudMinima = 1,2;
            const  double longitudMaxima = 1,5;
            int cantidadPiezas = 0;
            int piezasAptas = 0;
            int contador = 0;

            try
            {
                Console.WriteLine("ingrese la cantidad de piezas en el lote: ");
                cantidadPiezas = Convert.ToInt32(Console.ReadLine());

                piezasAptas = 0;

                contador = 0;
                while (contador < cantidadPiezas)
                {
                    Console.WriteLine($"ingrese la longitud de la pieza {contador + 1} ( en metros): ");
                }

                double longitud = Convert.ToDouble(Console.ReadLine());

                if (longitud <= longitudMinima  && longitud <= longitudMaxima)
                {
                    piezasAptas++;
                }
                contador ++;

                Console.WriteLine($"la cantidad de piezas aptas para fabricar perfiles es: {piezasAptas}");

            }
            catch (Exception)
            {

               Console.WriteLine("error: ingreso un valor no valido. por favor, ingrese numeros:");
            }


        }
    }
}
