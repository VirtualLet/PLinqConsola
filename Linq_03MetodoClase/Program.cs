using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_03MetodoClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Obtener números pares");
            IEnumerable<int> resultados = ClaseExplicita.ObtenerNumerosPares();
            foreach( int item in resultados)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---Obtener postres");

            IEnumerable<string> postres = ClaseExplicita.ObtenerPostres();
            foreach( string item in postres)
                Console.WriteLine(item);

            Console.WriteLine("----Obtener impares resultado de query inmediato");
            int[] impares = ClaseExplicita.ObtenerNumerosImpares();
            foreach(int item in impares)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
