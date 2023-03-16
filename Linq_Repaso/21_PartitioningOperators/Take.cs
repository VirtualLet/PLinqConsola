using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Repaso._21_PartitioningOperators
{
  public  class Take
    {
        public void TakeEjemp()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            Console.WriteLine("Take operator is used to get first n number of records from a dataSource\n" +
                "where n i an integer which is passed in Take method\n" +
                "Take method will not make any change in element position\n");
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var selectMethod = numbers.Take(5).ToArray();
            var selectMix = (from data in numbers
                             select data).Take(4).ToList();
            foreach(var item in selectMethod)
            {
                Console.WriteLine(item);
            }
        }

        public void TakeEjempConWhere()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            int[] numbers = new int[] { 1, 2, 3, 4, 5,2, 6, 7, 8, 9, 10 };

            Console.WriteLine(" toma los 5 primeros elementos que cumplan con la condicion de que el elemento sea >3 \n");

            var selectMethod = numbers.Where(x=>x>3).Take(5).ToArray();

            var selectMix = (from data in numbers
                             where data > 3
                             select data).Take(5).ToList();
            foreach (var item in selectMethod)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--Cuando se coloca la instruccion despues de take,cambia el resultado porque " +
                "se esta diciendo que tome los primeros 5 elementos de la colección y despues a estos " +
                "5 elementos le aplique la condicion de obtener solo los que sean > 3 \n");

            var selectMethodDos = numbers.Take(5).Where(x => x > 3).ToArray();
            foreach (var item in selectMethodDos)
            {
                Console.WriteLine(item);
            }
        }
    }
}
