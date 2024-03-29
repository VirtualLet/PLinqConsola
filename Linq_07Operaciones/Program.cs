﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_07Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("--------\n");
            //Operaciones();

            //Console.WriteLine("---------\n");
            //OperacionesBasicas();

            //Console.WriteLine("---------\n");
            OpereacionesRelacionadasConConjuntos();

            Console.ReadLine();
        }

        private static void Operaciones()
        {
            Console.WriteLine("count, reverse, orderby");
            List<CEstudiante> listEstudiantes = new List<CEstudiante>
            {
                new CEstudiante("ana","01","Mercadotecnia",1.0),
                new CEstudiante("luis","02","Programación",9.0),
                new CEstudiante("Susana","03","Inglés",9.5),
                new CEstudiante("Pablo","04","Programación",10.0),
                new CEstudiante("Alberto","05","Mercadotecnia",4)
            };

            Console.WriteLine("---Conteo");
            int cantidad = (from item in listEstudiantes
                            where item.Promedio > 5
                            select item).Count();

            Console.WriteLine("La cantidad de aprobados es: {0}", cantidad);

            Console.WriteLine("----Orden inverso");
            var aprobados = from item in listEstudiantes
                            where item.Promedio > 5
                            select item;

            foreach (CEstudiante item in aprobados)
                Console.WriteLine(item);
            Console.WriteLine("-----");
            foreach (CEstudiante item in aprobados.Reverse())
                Console.WriteLine(item);

            Console.WriteLine("---Ordenamiento");
            var ordenadosDes = from elem in listEstudiantes
                               orderby elem.Promedio descending
                               select elem;

            foreach (CEstudiante item in ordenadosDes)
                Console.WriteLine(item);

            Console.WriteLine("---Ascendente");
            var ordenadosAsc = from elem in listEstudiantes
                               orderby elem.Promedio ascending
                               select elem;

            foreach (CEstudiante item in ordenadosAsc)
                Console.WriteLine(item);
        }

        private static void OperacionesBasicas()
        {
            Console.WriteLine("Max,Min,Avarage,Sum");
            int[] numeros = { 2, 5, 9, 1, 6, 7, 8 };

            foreach (var item in numeros)
                Console.WriteLine(item);


            //Encontrando el maximo
            int maximo = (from elem in numeros select elem).Max();
            Console.WriteLine("El maximo es:{0}", maximo);

            //Encontando el minimo
            int minimo = (from elem in numeros select elem).Min();
            Console.WriteLine("El minimo es:{0}", minimo);

            //Encontrando el promedio
            double promedio = (from elem in numeros select elem).Average();
            Console.WriteLine("El promedio es:{0}", promedio);

            //Sumatoria
            int sumatoria = (from elem in numeros select elem).Sum();
            Console.WriteLine("La sumatoria es:{0}", sumatoria);
        }

        private static void OpereacionesRelacionadasConConjuntos()
        {
            Console.WriteLine("Except,Intersect,Union,Concat,Distinct");

            List<int> listConjunto1 = new List<int> { 2, 4, 6, 8, 9 };
            List<int> listConjunto2 = new List<int> { 2, 5, 6, 7, 9 };

            Console.WriteLine("---Except da la diferencia entre dos contenedores");

            var expt = (from item in listConjunto1 select item)
                    .Except(from item2 in listConjunto2 select item2);

            foreach(int elem in expt)
                Console.WriteLine(elem);

            Console.WriteLine("---Intersect muestra los comunes");
            var interseccion = (from item in listConjunto1 select item)
                  .Intersect(from item2 in listConjunto2 select item2);

            foreach (int elem in interseccion)
                Console.WriteLine(elem);

            Console.WriteLine("---Union");

            var union = (from item in listConjunto1 select item)
                .Union(from item2 in listConjunto2 select item2);

            foreach (int elem in union)
                Console.WriteLine(elem);

            Console.WriteLine("----Concat");
            var concatenacion = (from item in listConjunto1 select item)
                .Concat(from item2 in listConjunto2 select item2);

            foreach (int elem in concatenacion)
                Console.WriteLine(elem);

            Console.WriteLine("----Distinct");
          //Aqui no ha modificado concatenación, solo se aplica el filtro sobre el pero no lo cambia
            foreach (int elem in concatenacion.Distinct())
                Console.WriteLine(elem);


        }


    }
}
