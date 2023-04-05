using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Uso_ElementAt
    {
        public void ElementAt()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            Console.WriteLine("Element operations are used to return one specific record" +
                "Element operations can be used on a single data source or on a query of" +
                "multiple data source   \n");
            Console.WriteLine("If the elements is not available at given index-" +
                "ElementAt will throw an exception \n");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 10 };

            for(int i=0; i<numbers.Count; i++)
            {
                Console.WriteLine("[{0}]{1}",i,numbers[i]);
            }

            var selectMethod = numbers.ElementAt(2);

            Console.WriteLine("ElementAt(2):{0}",selectMethod);


        }

        public void ElementAtOrDefault()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            Console.WriteLine("If the elements is not available at given index-" +
                "ElementAtOrDefault will return null \n");


            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 10 };

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("[{0}]{1}", i, numbers[i]);
            }

            var selectMethod = numbers.ElementAtOrDefault(12);

            Console.WriteLine("ElementAt(2):{0}", selectMethod);
            Console.WriteLine("----Con String---\n");

            List<string> letras = new List<string> { "a", "b", "c", "d", "e" };
            for (int i = 0; i < letras.Count; i++)
            {
                Console.WriteLine("[{0}]{1}", i, letras[i]);
            }

            var selectMethodConString = letras.ElementAtOrDefault(12);

            var selectQueryConString = (from data in letras
                                        select data).ElementAtOrDefault(12);

            Console.WriteLine("ElementAt(2):{0}", selectMethodConString);

        }

        public void ElementOrDefaulEjemConCondicion()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 10 };

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("[{0}]{1}", i, numbers[i]);
            }

            var selectMethod = numbers.Where(x=> x>4).ElementAtOrDefault(1);

            Console.WriteLine("ElementAt(1):{0}", selectMethod);
        }

    }
}
