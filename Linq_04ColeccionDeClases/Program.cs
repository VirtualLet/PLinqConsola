using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_04ColeccionDeClases
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CEstudiante> lisEstudiantes = new List<CEstudiante>
            {
                new CEstudiante("ana","01","Mercadotecnia",1.0),
                new CEstudiante("luis","02","Programación",9.0),
                new CEstudiante("Susana","03","Inglés",9.5),
                new CEstudiante("Pablo","04","Programación",10.0),
                new CEstudiante("Alberto","05","Mercadotecnia",4)
            };

            //Se encuentra a los reprobados
            var reprobados = from item in lisEstudiantes
                             where item.Promedio <= 5.0
                             select item;

            Console.WriteLine("---Estudiantes reprobados <= 5:\n");
            foreach( CEstudiante item in reprobados)
                Console.WriteLine(item);

            Console.WriteLine("\n---Estudiantes reprobados--Mostrando sólo un atributo Nombre\n");
            foreach(CEstudiante item in reprobados)
                Console.WriteLine(item.Nombre);


            //Encontrando solo los nombres de los  de mercadotecnia
            Console.WriteLine("----Encontrando solo los nombres de mercadotecnia");
            var mercadotecnia = from item in lisEstudiantes
                                where item.Curso == "Mercadotecnia"
                                select item.Nombre;
            foreach(string item in mercadotecnia)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
