using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosEnteros
{
    public class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int suma = 0;
            int numero = 0;
            
            try
            {
                while (contador < 10)

               Console.WriteLine($"ingrese el numero {contador + 1}:");
                numero = Convert.ToInt32( Console.ReadLine() );

                suma += numero;
                contador++;

                double promedio = (double)suma / contador;

                Console.WriteLine($"la suma de los 10 numeros es: {suma}");
                Console.WriteLine($"el promedio aritmetico es: {promedio}");


            }
            catch (Exception)
            {
                Console.WriteLine("error: ingreso un valor no valido. por favor, ingrese numeros enteros:");
                
            }
        }
    }
}
