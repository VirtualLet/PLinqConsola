using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq_01Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Query sencillo con arreglos y reflexión");
            EjemploConNumeros();
            EjemploConCadenas();
            Console.ReadLine();
        }

        public static void MuestraArreglo(Array arreglo)
        {
            for (int i=0; i< arreglo.Length; i++)
            {
                Console.WriteLine("[{0}]{1}",i,arreglo.GetValue(i));
            }         
            Console.WriteLine("---");
        }
        public static void EjemploConNumeros()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Se realiza el query
            IEnumerable<int> valores = from item in numeros
                                       where item > 3 && item < 8
                                       select item;
           
            Console.WriteLine("Muesta elementos del arreglo numeros");
            //Se muestran los resultados
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }
        }
        public static void EjemploConCadenas()
        {
            Console.WriteLine("EJEMPLO con cadenas");
            string[] postres = { "pay de manzana", "pastel de chocolate", "manzana caramelizada", "fresas con crema" };

            MuestraArreglo(postres);
            string palabraABuscar = "manzana";
            IEnumerable<string> encontrados = from item in postres
                                              where item.Contains(palabraABuscar)
                                              orderby item
                                              select item;

            Console.WriteLine("Muesta elementos que contengan la palabra {0}",palabraABuscar);
            foreach (var item in encontrados)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---");

            Console.WriteLine("SE HACE reflexion");
            InformacionResultadosReflexion(encontrados);

        }

        public static void InformacionResultadosReflexion(object pResultados)
        {
            Console.WriteLine("Tipo {0}",pResultados.GetType().Name);
            Console.WriteLine("Locación {0} ",pResultados.GetType().Assembly.GetName().Name);
        }

       
    }
}
