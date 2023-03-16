using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Repaso._21_PartitioningOperators
{
  public  class TakeWhile
    {

        public void TakeWhileEjem()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            Console.WriteLine("TakeWhile operator is used to get all records from a data source until a" +
                "specified condition is true\n" +
                "Once the condition is failed TakeWhile will not validate rest elements Even if the " +
                "condition is true for remaining elements.\n");

            int[] numbers = new int[] { 1, 2, 3, 8, 9, 4, 5, 6, 7,10 };

            //muestra solo los elementos que cumplen la condicion hasta que encuentra un elemento que no lo cumpla
            //y si  despues del elemento que no cumple la condicon existiera elementos que si cumplen como en este caso
            //los ignorara y solo mostrara los primeros
            var selectMethod = numbers.TakeWhile(x => x < 7).ToList();

            var selectQuery= (from data in numbers
                             select data).TakeWhile(x => x < 7).ToList();

            foreach (int item in selectMethod)
            {
                Console.WriteLine(item);
            }
        }

        public void TakeWhileConString()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            List<string> names = new List<string> { "Kim", "John", "Adam", "Joy", "Nitish","Let" };

            Console.WriteLine("Muestra los elementos que cumplan con que su longitud de caracteres" +
                "sea mayor que el numero de indice que ocupan, hasta que encuentre un elemento que no cumpla la condición" +
                "si despúes de este elemento existieran otros que si cumplen los ignorara y solo mostrara los primeros que " +
                "si cumplieron antes de encontrar uno que no ");

            var selectMethod = names.TakeWhile((name, index) => name.Length > index)
                                    .Select((name, index) => new { name, name.Length, index }).ToList();

            var selectQuery = (from data in names
                               select data).TakeWhile((name, index) => name.Length > index)
                                           .Select((name, index) => new { name, name.Length, index }).ToList();


            foreach (var item in selectMethod)
            {
                Console.WriteLine(item);
            }
        }

        
}
}
