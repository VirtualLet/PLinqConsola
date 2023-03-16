using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Repaso._21_PartitioningOperators
{
public    class SkipWhile
    {

        public void SkipWhileEjem()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            Console.WriteLine("SkipWhile operator is used to skip all records from a data souce" +
                "until a condition is true and select remaining elements as an output \n");

            Console.WriteLine("Muestra todos los elementos restantes apartir de que encuentre el primer elemento" +
                "que deje de  cumplir con la condicion");
            int[] numbers = new int[] { 0,1, 2, 8, 3, 4, 5, 6, 7, 12, 9, 10 };

            var selectMethod = numbers.SkipWhile(x => x < 6).ToList();

            var selectQuery= (from data in numbers
                              select data).SkipWhile(x => x < 6).ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine(item);
            }
        }

        public void SkipWhileConString()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            List<string> names = new List<string> { "Kim", "John", "Adam", "Joy", "Nitish", "Let","lia" };

            Console.WriteLine("Muestra todos los elementos restantes apartir de que encuentre el primer elemento" +
               "que deje de  cumplir con la condicion, en este caso despues de obtener los resultados les asigna" +
               "el indice no de origen, sino como su fuera una coleccion nueva");
            var selectMethod = names.SkipWhile((valor, index) => valor.Length > index)
                                    .Select((valor, index) => new
                                    {
                                        nombre = valor,
                                        longitud = valor.Length,
                                        indice = index
                                    }).ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine(item);
            }
        }
    }
}
