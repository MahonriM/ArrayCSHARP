using System;

namespace Arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            Llenarnumeros(ref numeros);
            MostrarNumeros(ref numeros);
            //Pausa
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();

        }
        static void Llenarnumeros(ref int[] numeros)
        {
            for (int i = 0; i <= numeros.GetUpperBound(0); i++)
            {
                Console.Write("Introduce el dato{0}", i + 1);
                numeros[i] = int.Parse(Console.ReadLine());
            }
        }
        static void MostrarNumeros(ref int[] numeros)
        {
            for (int i = 0; i <= numeros.GetUpperBound(0); i++)
            {
                Console.Write(numeros[i]);
                numeros[i] = int.Parse(Console.ReadLine());
            }
        }

    }
}
