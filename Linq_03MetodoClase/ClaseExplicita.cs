using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_03MetodoClase
{
    class ClaseExplicita
    {
        //Se crea el arreglo
        private static string[] postres = {"pay de manzana","pastel de chocolate","manzana caramelizada",
        "fresas con crema"};

        //Se crea el query, No puede usarse de forma implicita, Debe ser estatico
        private static IEnumerable<string> encontrados = from item in postres
                                                         where item.Contains("manzana")
                                                         orderby item
                                                         select item;
        //Todo se trabaja internamente
        public static IEnumerable<int> ObtenerNumerosPares()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 7, 8, 11 };
            IEnumerable<int> pares = from item in numeros
                                     where item % 2 == 0
                                     select item;
            return pares;
        }

        //Regrese el resultado del query
        public static IEnumerable<string> ObtenerPostres()
        {
            return encontrados;
        }
        //Este método regresa el resultado de un query inmediato
        public static int[] ObtenerNumerosImpares()
        {
            int[] numeros = { 1, 3, 5, 6, 7, 9, 10, 11 };
            var resultados = from item in numeros
                             where item % 2 != 0
                             select item;
            
            return resultados.ToArray();
        }








    }
}
