using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LINQ
{
    public class Uso_Intersect
    {
        public void IntersectConListstring()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");
            Console.WriteLine("Intersect: Returns all the elements which exist in both the data source\n");
            List<string> dataUno = new List<string> { "A", "B", "C", "D" };
            List<string> dataDos = new List<string> { "C", "D", "E", "F" };

            var selectMethod = dataUno.Intersect(dataDos).ToList();
            var selectQuery = (from data in dataUno
                               select data).Intersect(dataDos).ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine(item);
            }
        }

        public void IntersectUsandoFuncionesAnonimas()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");
            List<EntStudentSimple> studentsUno = new List<EntStudentSimple> { new EntStudentSimple { Id = 1, Name = "Let" } ,
                                                                     new EntStudentSimple { Id = 2, Name = "Mat" },
                                                                     new EntStudentSimple { Id = 3, Name = "Let" },
                                                                     new EntStudentSimple { Id = 4, Name = "Mat" }
            };

            List<EntStudentSimple> studentsDos = new List<EntStudentSimple> { new EntStudentSimple { Id = 1, Name = "Let" } ,
                                                                     new EntStudentSimple { Id = 2, Name = "Mat" },
                                                                     new EntStudentSimple { Id = 5, Name = "Let" },
                                                                     new EntStudentSimple { Id = 6, Name = "Mat" }
            };

            //var selectMethod = studentsUno.Intersect(studentsDos).ToList(); Se requiere usar Funciones anonimas o implentar
            var selectMethod = studentsUno.Select(x => new { x.Id, x.Name }).
                Intersect(studentsDos.Select(y => new { y.Id, y.Name })).ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine("Id:{0} Name:{1}", item.Id, item.Name);
            }
        }

        public void IntersectUsandoIEqualityComparer()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");

            List<EntStudentSimple> studentsUno = new List<EntStudentSimple> { new EntStudentSimple { Id = 1, Name = "Let" } ,
                                                                     new EntStudentSimple { Id = 2, Name = "Mat" },
                                                                     new EntStudentSimple { Id = 3, Name = "Let" },
                                                                     new EntStudentSimple { Id = 4, Name = "Mat" }
            };

            List<EntStudentSimple> studentsDos = new List<EntStudentSimple> { new EntStudentSimple { Id = 1, Name = "Let" } ,
                                                                     new EntStudentSimple { Id = 2, Name = "Mat" },
                                                                     new EntStudentSimple { Id = 5, Name = "Let" },
                                                                     new EntStudentSimple { Id = 6, Name = "Mat" }
            };

            var comparer = new EntStudentComparer();

            var selectMethod = studentsUno.Intersect(studentsDos,comparer).ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine("Id:{0} Name:{1}", item.Id, item.Name);
            }
        }


    }
}
