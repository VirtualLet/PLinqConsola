using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_10MasOperadores
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Uso de operadores: Take, Skip, Reverse, First, Last, ElementAt, Any");

            int[] numeros = { 1, 5, 4, 7, 6, 3, 5, 8, 11, 9 };
            Console.WriteLine("---Take: Toma el primer numero de elementos que se le indique");

            IEnumerable<int> desdeInicio = numeros.Take(5);
            foreach(int elem in desdeInicio)
                Console.WriteLine(elem);

            Console.WriteLine("--Skip:brinca determinado numero de elementos y de ahi seguira imprimiendo");
            IEnumerable<int> brinco = numeros.Skip(5);
            foreach(int elem in brinco)
                Console.WriteLine(elem);

            Console.WriteLine("--.Reverse:");
            IEnumerable<int> reversa = numeros.Reverse();
            foreach(int elem in reversa)
                Console.WriteLine(elem);

            Console.WriteLine("--First:");
            Console.WriteLine("El primer elemento es: {0}",numeros.First());

            Console.WriteLine("--Last");
            Console.WriteLine("El ultimo elemento es: {0}",numeros.Last());

            Console.WriteLine("--ElementAt: encontrar el elemento en determinado indice");
            Console.WriteLine("En el indice 3 se encuentra {0}",numeros.ElementAt(3));

            Console.WriteLine("--Contains:Verifica si contine determinado elemento");
            Console.WriteLine("Contiene el elemento 15? {0}",numeros.Contains(15));

            Console.WriteLine("--Any:Verifica si hay elementos");
            Console.WriteLine("Tiene elementos? {0}",numeros.Any());

            Console.WriteLine("Hay multiplos de 5? {0}",numeros.Any(item=>item%5==0));

            Console.WriteLine("---Cuidado con los cambios de valor entre la ejecución de los querys");

            int valor = 2;
            IEnumerable<int> resultados = numeros.Where(item => item % valor == 0);

            //valor=3;

            //Porque el query se ejecuta hasta que se muestran los resultados
            foreach(int elem in resultados)
                Console.WriteLine(elem);

            Console.ReadLine();
        }
    }
}
