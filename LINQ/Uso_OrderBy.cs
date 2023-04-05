using Linq_Repaso.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Uso_OrderBy:DataMethod
    {
        public void OrderByOpertors()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            var dataSource =ListInt();
            var selectQuery = from data in dataSource
                              where data > 5
                              orderby data
                              select data;

            var selectMethod = dataSource.Where(x => x > 5)
                                        .OrderBy(x => x)
                                        .ToList();
            foreach (var item in selectQuery)
            {
                Console.WriteLine(item);
            }
        }

        public void OrderByOperatorsEjem2()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            var dataSource =ListString();
            var selectQuery = (from data in dataSource
                               where data.Length > 6
                               orderby data.Length
                               select data).ToList();

            var selectMethod = dataSource.Where(x => x.Length > 6).OrderBy(x => x).ToList();

            foreach (var item in selectQuery)
            {
                Console.WriteLine(item);
            }
        }

        public void OrderByOperatorsEjem3()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            var dataSource = ListEmployee();

            var selectQuery = (from data in dataSource
                               where data.Id > 2
                               orderby data.Name
                               select data).ToList();

            var selectMethod = dataSource.Where(x => x.Id > 2).OrderBy(x => x.Name).ToList();

            foreach (var item in selectQuery)
            {
                Console.WriteLine(item);
            }
        }

        public void OrderByDescendingEjemInt()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            var dataSource = ListInt();
            var selectMethod = dataSource.Where(x => x > 3).OrderByDescending(x => x).ToList();

            var selectQuery = (from data in dataSource
                               where data > 3
                               orderby data descending
                               select data).ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine(item);
            }
        }

        public void OrderByDescendingEjemString()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            var dataSource = ListString();
            var selectMethod = dataSource.OrderByDescending(x => x).ToList();

            var selectQuery = (from data in dataSource
                               orderby data descending
                               select data).ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine(item);
            }
        }

        public void OrderByDescendingEjemClass()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            var dataSource = ListEmployee();

            var selectMethod = dataSource.OrderByDescending(x => x.Email).ToList();

            var selectQuery = (from data in dataSource
                               orderby data.Email descending
                               select data).ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine(item);
            }
        }


        public void OrderBy_ThenBy()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            var dataSource = ListEmployee();

            var selectMethod = dataSource.OrderBy(x => x.Name).ThenBy(x => x.Email).ToList(); 

            foreach (var item in selectMethod)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---selectQuerydescending---");
            var selectQuery = (from data in dataSource
                               orderby data.Name descending, data.Email descending
                               select data).ToList();

            foreach (var item in selectQuery)
            {
                Console.WriteLine(item);
            }
        }
    }
}
