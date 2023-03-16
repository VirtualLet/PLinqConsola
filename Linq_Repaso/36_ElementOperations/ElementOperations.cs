using Linq_Repaso.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Repaso._36_ElementOperations
{
public class ElementOperations
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

        public void First()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            Console.WriteLine("Select first record from data source" +
                "If the elements is not available at first index-" +
                "first will throe an exception\n");

            List<int> numbers = new List<int> { 3, 2, 3, 4, 5, 6, 7, 8, 10 };

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("[{0}]{1}", i, numbers[i]);
            }

            var selectMethod = numbers.First();
            Console.WriteLine("first:{0}", selectMethod);

            Console.WriteLine("\nfirst con condicion where \n");

            var selectMethodDos = numbers.Where(x => x > 6).First();
            Console.WriteLine("first:{0}", selectMethodDos);

        }

        public void FirstEjemConPredicado()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            List<int> numbers = new List<int> { 3, 2, 3, 4, 5, 6, 7, 8, 10 };

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("[{0}]{1}", i, numbers[i]);
            }

            var selectMethodDos = numbers.First(x=>x>6);
            Console.WriteLine("first:{0}", selectMethodDos);
        }


        public void FirstOrDefault()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            Console.WriteLine("If the elements is not available at first index-" +
                "But FirstOrDefault will return default value of data source element");

            List<int> numbers = new List<int> { 3, 2, 3, 4, 5, 6, 7, 8, 10 };

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("[{0}]{1}", i, numbers[i]);
            }

            var selectMethodDos = numbers.FirstOrDefault(x => x> 12);
            Console.WriteLine("first:{0}", selectMethodDos);
        }

        public void FirstOrDefaulEjem()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            var trabajador = new Trabajador().DataTrabajador();
            var selectMethod = trabajador.FirstOrDefault(x => x.Name == "Alan5" && x.AddressId == 1);

            var selectMix= (from data in trabajador
                           select data).FirstOrDefault(x => x.Name == "Alan5" && x.AddressId == 1);


            if (selectMethod != null)
            {
                Console.WriteLine("{0},{1},{2}", selectMethod.Id, selectMethod.Name, selectMethod.AddressId);
            }
            else {
                Console.WriteLine("sin valores");
            }

           //foreach(var item in selectMethod)
           // {
           //     Console.WriteLine(item);
           // }
        }
        public void Last()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            Console.WriteLine("Select last record from data source");
            Console.WriteLine("If the elements is not available at last index-" +
                "Last() will throw an exception");
            List<int> numbers = new List<int> { 3, 2, 1, 5, 6, 7, 8, 10,6,4 };

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("[{0}]{1}", i, numbers[i]);
            }

            var selectMethod = numbers.Last();
            Console.WriteLine("\n lastElement:{0}",selectMethod);

            var selectMethodCondicion = numbers.Last(x => x > 5);
            Console.WriteLine("\n lastElement que cumpla la condición:{0}",selectMethodCondicion);

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
        public void Single()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            Console.WriteLine("If the element is available at multiple places then both the methods will" +
                "throw an exception\n" +
                "If no element is available in the datasource-" +
                "single() will throe an exception\n");
            List<int> numbers = new List<int> {9 };

            var selectMethod = numbers.Single();
            Console.WriteLine(selectMethod);

             numbers = new List<int> { 9,1 };
            Console.WriteLine("\nsingle() con condicion");
            var selectMethodCondition = numbers.Single(x => x > 3);
            Console.WriteLine("Obtenn el unico elemento >3:{0}",selectMethodCondition);

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

            numbers = new List<int> { 9, 1,3 };
            Console.WriteLine("\nSingleOrDefault() con condicion");
            var selectMethodCondition = numbers.SingleOrDefault(x => x > 13);
            Console.WriteLine("Obtenn el unico elemento >13:{0}", selectMethodCondition);
        }
    }
}
