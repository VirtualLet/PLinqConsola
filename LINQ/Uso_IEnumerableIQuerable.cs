using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public  class Uso_IEnumerableIQuerable
    {
        protected List<EntEmployee> ListEmployee()
        {
            List<EntEmployee> employees = new List<EntEmployee>
             {
                new EntEmployee {Id=1, Name="Leticia", Email="let@gmail.com"},
                new EntEmployee {Id=2, Name="Edith", Email="edi@gmail.com"},
                new EntEmployee {Id=3, Name="Manuel", Email="man@gmail.com"},
                new EntEmployee {Id=4, Name="Ale", Email="ale@gmail.com"},
                new EntEmployee {Id=5, Name="Leticia", Email="tom@gmail.com"}
             };
            return employees;
        }
        public void UsoIEnumerable()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            List<EntEmployee> employees = ListEmployee();             

            IEnumerable<EntEmployee> query = from obj in employees
                                          where obj.Id == 1
                                          select obj;

            foreach (var item in query) { Console.WriteLine(item.ToString()); }

        }

        public void UsoIQuerable()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            List<EntEmployee> employees = ListEmployee();

            IQueryable<EntEmployee> query = employees.AsQueryable().Where(x => x.Id == 2);

            foreach (var item in query) { Console.WriteLine(item.ToString()); }

        }

      
    }
}
