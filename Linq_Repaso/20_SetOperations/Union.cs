using Linq_Repaso.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Repaso._20_SetOperations
{
  public  class Union
    {

        public void UnionEjem()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");
            Console.WriteLine("Union: Returns all the elements that appear in either of two data source, except duplicate");

            List<string> dataUno = new List<string> { "A", "B", "C", "D" };
            List<string> dataDos = new List<string> { "C", "D", "E", "F" };

            var selectMethod = dataUno.Union(dataDos).ToList();
            foreach(var item in selectMethod)
            {
                Console.WriteLine(item);
            }
           
        }

        public void UnionUsandoAnonimoFuncion()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");

            List<StudentSimple> studentsUno = new List<StudentSimple> { new StudentSimple { Id = 1, Name = "Let" } ,
                                                                     new StudentSimple { Id = 2, Name = "Mat" },
                                                                     new StudentSimple { Id = 3, Name = "Let" },
                                                                     new StudentSimple { Id = 4, Name = "Mat" }
            };

            List<StudentSimple> studentsDos = new List<StudentSimple> { new StudentSimple { Id = 1, Name = "Let" } ,
                                                                     new StudentSimple { Id = 2, Name = "Mat" },
                                                                     new StudentSimple { Id = 5, Name = "Let" },
                                                                     new StudentSimple { Id = 6, Name = "Mat" }
            };

           // var selectMethod = studentsUno.Union(studentsDos).ToList();
           var selectMethod = studentsUno.Select(x => new { x.Id, x.Name }).Union(studentsDos.Select(y => new { y.Id, y.Name }));
            foreach (var item in selectMethod)
            {
                Console.WriteLine("Id:{0} Name:{1}", item.Id, item.Name);
            }
        }


        public void UnionUsandoIEqualityComparer()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");

            List<StudentSimple> studentsUno = new List<StudentSimple> { new StudentSimple { Id = 1, Name = "Let" } ,
                                                                     new StudentSimple { Id = 2, Name = "Mat" },
                                                                     new StudentSimple { Id = 3, Name = "Let" },
                                                                     new StudentSimple { Id = 4, Name = "Mat" }
            };

            List<StudentSimple> studentsDos = new List<StudentSimple> { new StudentSimple { Id = 1, Name = "Let" } ,
                                                                     new StudentSimple { Id = 2, Name = "Mat" },
                                                                     new StudentSimple { Id = 5, Name = "Let" },
                                                                     new StudentSimple { Id = 6, Name = "Mat" }
            };

            var comparer = new StudentComparer();

            var selectMethod = studentsUno.Union(studentsDos, comparer).ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine("Id:{0} Name:{1}", item.Id, item.Name);
            }
        }

    }
}
