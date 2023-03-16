using Linq_Repaso.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Repaso._15_Reverse
{
    public class Reverse:DataMethod
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
