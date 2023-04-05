using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Uso_Last
    {
        public void Last()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            Console.WriteLine("Select last record from data source");
            Console.WriteLine("If the elements is not available at last index-" +
                "Last() will throw an exception");
            List<int> numbers = new List<int> { 3, 2, 1, 5, 6, 7, 8, 10, 6, 4 };

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("[{0}]{1}", i, numbers[i]);
            }

            var selectMethod = numbers.Last();
            Console.WriteLine("\n lastElement:{0}", selectMethod);

            var selectMethodCondicion = numbers.Last(x => x > 5);
            Console.WriteLine("\n lastElement que cumpla la condición:{0}", selectMethodCondicion);

        }

        public void LastOrDefault()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            Console.WriteLine("If the element is not available at last index-" +
                "LastOrDefault() will return default value of data source element");

            List<int> numbers = new List<int> { 3, 2, 1, 5, 6, 7, 8, 10, 6, 4 };

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("[{0}]{1}", i, numbers[i]);
            }

            var selectMethodCondicion = numbers.LastOrDefault(x => x > 12);

            var selectQuery = (from data in numbers
                               select data).LastOrDefault(x => x > 12);

            Console.WriteLine("\n lastElement que cumpla la condición:{0}", selectMethodCondicion);
        }
    }
}
