using Linq_Repaso.Entities;
using Linq_Repaso.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Repaso._19_ContainsOperators
{
 public   class Contains:DataMethod
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
            List<Student> students = ListStudent();

            var estudiante = new Student { StudentId = 1, FullName = "Leticia" };
            students.Add(estudiante);

            var selectMethod = students.Contains(estudiante);
            var selectQuery = (from data in students
                               select data).Contains(new Student { StudentId = 1, FullName = "Leticia" });
            Console.WriteLine("Contiene al estudiante buscado?{0}",selectMethod);
        }

        public void ContainsUsandoIEqualityComparer()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");
            List<StudentSimple> students = new List<StudentSimple> { new StudentSimple { Id = 1, Name = "Let" } ,
                                                                     new StudentSimple { Id = 2, Name = "Mat" },
                                                                     new StudentSimple { Id = 3, Name = "Raul" }
            };

            var comparer = new StudentComparer();
            var selectMethod = students.Contains(new StudentSimple { Id = 2, Name = "Mat" }, comparer);


            var selectQuery=( from data in students
                             select data).Contains(new StudentSimple { Id = 2, Name = "Mat" }, comparer);

            Console.WriteLine("Contiene al estudiante buscado?{0}", selectMethod);
        }
    }
}
