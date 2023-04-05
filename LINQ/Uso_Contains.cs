using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LINQ
{
    public   class Uso_Contains:DataMethod
    {
        public void ContainsEjemUno()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");
            List<string> students = ListString();
            var selectMethod = students.Contains("Eli");
            var selectQuery = (from std in students
                               select std).Contains("Eli");

            Console.WriteLine("Contiene la palabra Eli? {0}", selectMethod);
        }

        public void ContainsEjemDos()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");
            List<EntStudent> students = ListStudent();

            var estudiante = new EntStudent { StudentId = 1, FullName = "Leticia" };
            students.Add(estudiante);

            var selectMethod = students.Contains(estudiante);
            var selectQuery = (from data in students
                               select data).Contains(new EntStudent { StudentId = 1, FullName = "Leticia" });
            Console.WriteLine("Contiene al estudiante buscado?{0}",selectMethod);
        }

        public void ContainsUsandoIEqualityComparer()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");
            List<EntStudentSimple> students = new List<EntStudentSimple> { new EntStudentSimple { Id = 1, Name = "Let" } ,
                                                                           new EntStudentSimple { Id = 2, Name = "Mat" },
                                                                           new EntStudentSimple { Id = 3, Name = "Raul" }
            };

            var comparer = new EntStudentComparer();
            var selectMethod = students.Contains(new EntStudentSimple { Id = 2, Name = "Mat" }, comparer);


            var selectQuery=( from data in students
                             select data).Contains(new EntStudentSimple { Id = 2, Name = "Mat" }, comparer);

            Console.WriteLine("Contiene al estudiante buscado?{0}", selectMethod);
        }
    }
}
