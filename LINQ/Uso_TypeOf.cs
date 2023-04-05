using System;
using System.Linq;

namespace LINQ
{
    public  class Uso_TypeOf : DataMethod
    {
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
            var selectMethod2 = dataSource.OfType<string>().Where(x => x.Length < 4).ToList();

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
