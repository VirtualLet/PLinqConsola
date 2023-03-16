using Linq_Repaso.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Repaso._20_SetOperations
{
 public  class Distinct
    {
        public void DistinctEjem()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");
            Console.WriteLine("Distinct: Removes duplicate values from data source");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 1, 2, 4, 5, 5, 5, 6 };
            var selectMethod = numbers.Distinct().ToList();

            var selectQuery = (from data in numbers
                               select data).Distinct().ToList();
            foreach (var item in selectMethod)
            {
                Console.WriteLine(item);
            }
        }

        public void DistinctUsandoIEquatable()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");
            Console.WriteLine("Para usar distinct una opcion es implementar en la clase la interfaz IEquatable \n");
            List<StudentDistinct> students = new List<StudentDistinct>()
            {
                new StudentDistinct(){ Id=1, Name="Leticia"},
                new StudentDistinct(){ Id=2, Name="Raul"},
                new StudentDistinct(){ Id=1, Name="Leticia"},
                new StudentDistinct(){ Id=2, Name="Raul"}
            };

            var selectMethod = students.Distinct().ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine("Id:{0} Name:{1}", item.Id, item.Name);
            }
        }

        public void DistinctUsandoIEqualityComparer()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");
            Console.WriteLine("Para usar distinct otra opcion es crear otra clase que implemente la interfaz IEqualityComparer \n");

            List<StudentSimple> students = new List<StudentSimple> { new StudentSimple { Id = 1, Name = "Let" } ,
                                                                     new StudentSimple { Id = 2, Name = "Mat" },
                                                                     new StudentSimple { Id = 2, Name = "Mat" }
            };
            //  var selectMethod = students.Distinct().ToList(); //No funciona porque se requiere usar la interfaz IEqualitycomparer

            var comparer = new StudentComparer();
            var selectMethod = students.Distinct(comparer).ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine("Id:{0} Name:{1}", item.Id, item.Name);
            }
        }

    }
}
