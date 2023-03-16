using Linq_Repaso.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Linq_Repaso._20_SetOperations
{
    public  class Except
    {
        public void ExceptEjem()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");
            Console.WriteLine("Except: Returns all the elements from one data source that do not exist in second data source\n");

            List<string> dataUno = new List<string> { "A", "B", "C", "D" };
            List<string> dataDos = new List<string> { "C", "D", "E", "F" };
            var selectMethod = dataUno.Except(dataDos).ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine(item);
            }
        }

        public void ExceptUsandoList()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");

            List<StudentSimple> studentsUno = new List<StudentSimple> { new StudentSimple { Id = 1, Name = "Let" } ,
                                                                     new StudentSimple { Id = 2, Name = "Mat" },
                                                                     new StudentSimple { Id = 3, Name = "Let" },
                                                                     new StudentSimple { Id = 3, Name = "Leticia" },
                                                                     new StudentSimple { Id = 4, Name = "Mat" }
            };

            List<StudentSimple> studentsDos = new List<StudentSimple> { new StudentSimple { Id = 1, Name = "Let" } ,
                                                                     new StudentSimple { Id = 2, Name = "Mat" },
                                                                     new StudentSimple { Id = 5, Name = "Let" },
                                                                     new StudentSimple { Id = 6, Name = "Mat" }
            };

            var selectMethod = studentsUno.Select(x => x.Name).Except(studentsDos.Select(x => x.Name)).ToList();
            foreach (var item in selectMethod)
            {
                Console.WriteLine("Name:{0}", item);
            }
        }

        public void ExceptUsandoAnonimoFuncion()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");
            Console.WriteLine("Para usar Except con clases podemos usar Funciones anonimas o implementar IEqualityComparer " +
                "Aqui usarameos funciones anonimas\n");


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

            var selectMethod = studentsUno.Select(x => new { x.Id, x.Name }).Except(studentsDos.Select(y => new { y.Id, y.Name }));
            foreach (var item in selectMethod)
            {
                Console.WriteLine("Id:{0} Name:{1}", item.Id, item.Name);
            }
        }


        public void ExceptUsandoIEqualityComparer()
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

            // var selectMethod = studentsUno.Except(studentsDos).ToList();//Para usarlo con clases se requiere implementar IEqualityComparer

            var comparer = new StudentComparer();
            var selectMethod = studentsUno.Except(studentsDos, comparer).ToList();

            var selectQuery = (from data in studentsUno
                               select data).Except(studentsUno, comparer).ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine("Id:{0} Name:{1}", item.Id, item.Name);
            }

            Console.WriteLine("---");
            var selectMethodDos = studentsDos.Except(studentsUno, comparer);

            foreach (var item in selectMethodDos)
            {
                Console.WriteLine("Id:{0} Name:{1}", item.Id, item.Name);
            }

        }

    }
}
