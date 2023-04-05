using System;
using System.Linq;

namespace LINQ
{
    public  class Uso_Where:DataMethod
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

       
    }
}
