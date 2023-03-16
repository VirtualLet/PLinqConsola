using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Repaso._21_PartitioningOperators
{
 public   class Skip
    {
        public void SkipEjem()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            Console.WriteLine("Skip operator is used to skip first n number of records from a data source and" +
                "sleect remaining elements as an output." +
                "where n is an integer which is passed in skip method \n");

            int[] numbers = new int[] { 0,1, 2, 8,3, 4, 5, 6, 7,12 , 9, 10 };

            Console.WriteLine("\n Muestra los elementos apartir de el numero de elementos indicados \n");
            var selectMethod = numbers.Skip(3).ToList();

            foreach(var item in selectMethod)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--Con condición: Obtiene los numeros > 4 y de la lista resultante, muestra solo los" +
                "números que esten apartir de la posición indicada  \n");
            var selectMethodDos = numbers.Where(x => x > 4).Skip(3).ToList();
            foreach (var item in selectMethodDos)
            {
                Console.WriteLine(item);
            }
        }

        public void SkipConString()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            List<string> names = new List<string> { "Kim", "John", "Adam", "Joy", "Nitish", "Let" };

            Console.WriteLine("\n Muestra los elementos apartir de el numero de elementos indicados \n");

            var selectMethod = names.Skip(2).ToList();
            var selectQuery = (from data in names
                               select data).Skip(2).ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine(item);
            }
        }
    }
}
