using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_11Subquery
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un subquery es un query que esta contenido en la expresión lambda de otro query
            //El scope que tiene existe dentro de la expresión que lo contiene
            string[] postres = { "pay de manzana", "pastel de chocolate", "manzana caramelizada", "fresas con crema" };

            //Se odena alfabeticamente de acuerdo a la última palabra de cada elemento
            //Split divide en una collección a la cadena
            //Split().Last() es el subquery

            IEnumerable<string> resultados = postres.OrderBy(item => item.Split().Last());
            foreach (string elem in resultados)
                Console.WriteLine(elem);

            Console.WriteLine("-------Ejemplo2 Numeros que son menores al primero del arreglo");

            int[] numeros = { 19, 14, 56, 32, 11, 8, 45, 7, 18, 2, 17, 23 };
            IEnumerable<int> nums = numeros
                                    .Where(item => item < numeros.First());
            foreach (int elem in nums)
                Console.WriteLine(elem);

            int primerNumero = numeros.First();
            Console.WriteLine("El primer numero del arreglo es:{0}", primerNumero);

            Console.WriteLine("------Ejem 3 Numeros que son menor al primer numero par que se encuentre");

            IEnumerable<int> num2 = numeros
                                    .Where(item => item <= (numeros
                                                            .Where(item2 => item2 % 2 == 0)).First());
            int primerNumeroPar = numeros.Where(item2 => item2 % 2 == 0).First();
            Console.WriteLine("El primer numero par es:{0}", primerNumeroPar);

            foreach (int elem in num2)
                Console.WriteLine(elem);

            Console.ReadLine();
        }
    }
}
