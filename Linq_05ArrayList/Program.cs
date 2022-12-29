using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_05ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tips para el uso de ArrayList con Linq por medio de OfType<>
            //seleccionamos objetos de un tipo en particular que estan en un ArrayList

            ArrayList lista = new ArrayList();
            lista.AddRange(new object[] { "hola", 5, 6.7, false, 4, 2, "saludos", 3.5, 3 });

            //Obtenemos solo los enteros
            var enteros = lista.OfType<int>();
            Console.WriteLine("-----Muestra solo los enteros del arreglo-");
            foreach (int item in enteros)
                Console.WriteLine(item);

            Console.WriteLine("-----Muestra solo los strings del arreglo-");

            var palabras = lista.OfType<string>();
            foreach(string item in palabras)
                Console.WriteLine(item);

            Console.WriteLine("------");

            //Se crea un arrayList
           ArrayList aListEstudiantes = new ArrayList()
            {
                new CEstudiante("ana","01","Mercadotecnia",1.0),
                new CEstudiante("luis","02","Programación",9.0),
                new CEstudiante("Susana","03","Inglés",9.5),
                new CEstudiante("Pablo","04","Programación",10.0),
                new CEstudiante("Alberto","05","Mercadotecnia",4)
            };

            //Se transforma el ArrayList a un tipo que implemente a IEnumerable<T> para poder 
            //ser usaco con Linq
            var IEnumAListEstudiantes = aListEstudiantes.OfType<CEstudiante>();

            //Ahora si  se puede usar linq para encontrar a los abrobados
            var aprobados = from item in IEnumAListEstudiantes
                            where item.Promedio >= 8
                            select item;
            Console.WriteLine("----Aprobados");

            foreach(CEstudiante item in aprobados)
                Console.WriteLine(item);

            Console.WriteLine("--Proyección se necesita de tipos anonimos");
            List<CEstudiante> listEstudiantes = new List<CEstudiante>
            {
                new CEstudiante("ana","01","Mercadotecnia",1.0),
                new CEstudiante("luis","02","Programación",9.0),
                new CEstudiante("Susana","03","Inglés",9.5),
                new CEstudiante("Pablo","04","Programación",10.0),
                new CEstudiante("Alberto","05","Mercadotecnia",4)
            };

            //Aqui es donde se realiza la proyección con el tipo anonimo en el select
            var nombrePromedio = from item in listEstudiantes
                                 where item.Promedio>9
                                 select new { item.Nombre, item.Promedio };

            foreach(var item in nombrePromedio)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
