using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
   public class Uso_First
    {
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

            var selectMethodDos = numbers.First(x => x > 6);
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

            var selectMethodDos = numbers.FirstOrDefault(x => x > 12);
            Console.WriteLine("first:{0}", selectMethodDos);
        }

        public void FirstOrDefaulEjem()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            var trabajador = new EntTrabajador().DataTrabajador();
            var selectMethod = trabajador.FirstOrDefault(x => x.Name == "Alan5" && x.AddressId == 1);

            var selectMix = (from data in trabajador
                             select data).FirstOrDefault(x => x.Name == "Alan5" && x.AddressId == 1);


            if (selectMethod != null)
            {
                Console.WriteLine("{0},{1},{2}", selectMethod.Id, selectMethod.Name, selectMethod.AddressId);
            }
            else
            {
                Console.WriteLine("sin valores");
            }

            //foreach(var item in selectMethod)
            // {
            //     Console.WriteLine(item);
            // }
        }
    }
}
