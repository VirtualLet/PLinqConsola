using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public  class Uso_Single
    {
        public void Single()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            Console.WriteLine("If the element is available at multiple places then both the methods will" +
                "throw an exception\n" +
                "If no element is available in the datasource-" +
                "single() will throe an exception\n");
            List<int> numbers = new List<int> { 9 };

            var selectMethod = numbers.Single();
            Console.WriteLine(selectMethod);

            numbers = new List<int> { 9, 1 };
            Console.WriteLine("\nsingle() con condicion");
            var selectMethodCondition = numbers.Single(x => x > 3);
            Console.WriteLine("Obtenn el unico elemento >3:{0}", selectMethodCondition);

        }
        public void SingleOrDefault()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            Console.WriteLine("If the element is available at multiple places then both the methods will" +
                "throw an exception\n" +
                "If no element is available in the datasource-" +
                "SingleOrDefault() will return default value of data source element\n");
            List<int> numbers = new List<int> { };

            var selectMethod = numbers.SingleOrDefault();
            Console.WriteLine(selectMethod);

            numbers = new List<int> { 9, 1, 3 };
            Console.WriteLine("\nSingleOrDefault() con condicion");
            var selectMethodCondition = numbers.SingleOrDefault(x => x > 13);
            Console.WriteLine("Obtenn el unico elemento >13:{0}", selectMethodCondition);
        }
    }
}
