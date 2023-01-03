using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_09SintaxisFluida
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Sintaxis fluida
             * Sequencia es un objeto que implementa a IEnumerable<T>
             * Element es cada item en la secuencia
             * Query operator es un método que transforma una secuencia
             * Acepta una secuencia de entrada y da una secuencia de salida
             * Se tienen cerca de 40 operadores para LINQ, esto forma parte de los
             * standars query operators
             * El query es una expresion que cuando se enumera transforma a la secuencia
             * usando los operadores
             */
            Console.WriteLine("Sintaxis fluida");

            //Se crea un arreglo
            int[] numeros = { 1, 5, 4, 7, 6, 3, 5, 9, 8, 11 };

            Console.WriteLine("---Numeros pares");
            //Se usan expresiones lambda como argumento , n es el argumento de entrada
            IEnumerable<int> pares = numeros.Where(n => n % 2 == 0);

            //Se muestran los resultados
            foreach(int num in pares)
                Console.WriteLine(num);

            Console.WriteLine("--Uso de Contains para obtener palabra manzana");

            string[] postres = { "pay de manzana", "pastel de chocolate", "manzanas caramelizada", "fresas con crema" };

            IEnumerable<string> encontrados = postres.Where(item => item.Contains("manzana"));
            foreach(string elem in encontrados)
                Console.WriteLine(elem);

            Console.WriteLine("----Uso de encadenadores de operadores, se van adicionando operadores");

            IEnumerable<string> manzanas = postres
                                        .Where(item => item.Contains("manzana"))
                                        .OrderBy(item => item.Length)
                                        .Select(item => item.ToUpper());
            foreach(string elem in manzanas)
                Console.WriteLine(elem);

    
            Console.ReadLine();
        }


    }
}
