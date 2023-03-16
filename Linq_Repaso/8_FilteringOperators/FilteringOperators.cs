using Linq_Repaso.Metodos;
using System;
using System.Linq;

namespace Linq_Repaso._8_FilteringOperators
{
    public  class FilteringOperators:DataMethod
    {
        public void UsoWhere()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            var dataSource = ListInt();

            var selectQuery = (from data in dataSource
                               where data <= 5 || data>9
                               select data).ToList();

            var selectMethod = dataSource.Where(x => x <= 5 || x>9).ToList();

            foreach(var item in selectQuery)
            {
                Console.WriteLine(item);
            }
        }

        public void UsoWhereEjem2()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            var dataSource = ListString();

            var selectQuery = (from data in dataSource
                               where data.Length==3 || data=="Tomy"
                               select data).ToList();

            var selectMethod = dataSource.Where(x => x.Length==3 || x=="Tomy").ToList();

            foreach (var item in selectQuery)
            {
                Console.WriteLine(item);
            }
        }

        public void UsoWhereEjem3()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            var dataSource =ListEmployeeConListEnt();

            var selectQuery = (from data in dataSource
                               where data.Tecnology.Count == 0 && data.Id==4
                               select data).ToList();

            var selectMethod = dataSource.Where(x => x.Tecnology.Count == 0 && x.Id==4).ToList();

            foreach( var item in selectQuery)
            {
                Console.WriteLine(item);
            }
        }

        public void UsoTypeOf()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            var dataSource = ListObject();

            Console.WriteLine("---selectMethod---\n");
            var selectMethod = dataSource.OfType<int>().ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---selectMethod2---\n");
            var selectMethod2 = dataSource.OfType<string>().Where(x=>x.Length<4).ToList();

            foreach (var item in selectMethod2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n---SelectQuery---\n");
            var selectQuery = (from data in dataSource
                               where data is string
                               select data).ToList();

            foreach (var item in selectQuery)
            {
                Console.WriteLine(item);
            }
        }
    }
}
