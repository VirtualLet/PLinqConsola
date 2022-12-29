using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_02EjecucionDiferedaInmediata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabajando con tipos implicitos, ejecución diferida, inmediata");

            int[] numeros = { 2, 5, 4, 7, 11, 6, 3, 9, 8 };

            //se realiza el query y se usa un tipo implicito por medio de var
            var valores = from item in numeros
                          where item % 2 == 0
                          select item;
            foreach(int item in valores)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------Ejecución diferida-------");
            //La expresión de query no se evalua hasta que se itera sobre el arreglo
            //Se puede usar el mismo query y siempre obtenemos el resultado actualizado

            //Modificamos el arreglo
            numeros[1] = 10;

            foreach (int item in valores)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----Ejecución inmediata-----");
            //Se ejecuta el query en el momento exacto  cuando se define

            //Se guarda el resultado como un arreglo
            int[] arrayValores = (from item in numeros where item % 2 == 0 select item).ToArray<int>();

            List<int> listValores = (from item in numeros where item % 2 == 0 select item).ToList<int>();

            //Se muestran los resultados
            Console.WriteLine("------Se muestra el arreglo");
            foreach (int item in arrayValores)
            {
                Console.WriteLine(item);
            }

            numeros[1] = 12;
            Console.WriteLine("------Se actualiza después de la modificación");
            foreach (int item in arrayValores)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------Se muesta la lista");

            foreach (int item in listValores)
            {
                Console.WriteLine(item);
            }





            Console.ReadLine();
        }
    }
}
