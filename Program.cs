 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_complementarios
{
    internal class Program
    {
        static void Serie(int i)
        {
            double termino;
            double resultado = 0.0;

            for(i = 1; i < 5; i++)
            {
                // realiza la division entre 2 elevado a i
                termino = (i / Math.Pow(2, i));

                // verifica si el indice es par, si es par resta el termino a la serie, si es impar suma el termino a la serie
                if(i % 2 == 0)
                {
                    resultado -= termino;
                }
                else
                {
                    resultado += termino;
                }
            }

            // imprime el resultado de la serie
            Console.WriteLine("\n\t El resultado es: " + resultado);

        }

        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("\t Resultado de la serie de suma y resta de (n/2^n)");

            Console.WriteLine("\n\t Favor digitar el valor de 'n' que se desea para realizar la serie");
            i = int.Parse(Console.ReadLine());
            Serie(i);

            Console.WriteLine("");


            Console.ReadKey();
        }
    }
}
