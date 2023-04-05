using System;
using System.Linq;
using System.Reflection;

namespace LINQ
{
    public class Uso_Reverse:DataMethod
    {
        public void ReverseEjemp()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            var dataSource =ArregloInt();
            var selectMethod = dataSource.Reverse();

            var selectQuery = (from data in dataSource
                               select data).Reverse();

            foreach(var item in selectMethod)
            {
                Console.WriteLine(item);
            }
        }

        public void ReverseEjempString()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            var dataSource =ListString();
            dataSource.Reverse();

            foreach (var item in dataSource) { Console.WriteLine(item); }
        }

        public void ReverseEjemAsEnumerable()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            var dataSource = ListString();
           
            var dataSourceIe = dataSource.AsEnumerable().Reverse();
            foreach (var item in dataSourceIe) { Console.WriteLine(item); }
        }

        public void ReverseEjemAsQueryable()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            var dataSource =ListString();

            var dataSourceIe = dataSource.AsQueryable().Reverse();
            foreach (var item in dataSourceIe) { Console.WriteLine(item); }
        }

    }
}
