using Linq_Repaso.Entities;
using Linq_Repaso.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Repaso._4_IEnumerable_IQuerable
{
  public  class UsoIEnumerableIQuerable:DataMethod
    {
       
        public void UsoIEnumerable()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            List<Employee> employees = new List<Employee>
             {
                 new Employee{Id=1, Name="Laura"},
                 new Employee{Id=2,Name="Leonor"}
             };

            IEnumerable<Employee> query = from obj in employees
                                          where obj.Id == 1
                                          select obj;

            foreach (var item in query) { Console.WriteLine(item.ToString()); }

        }

        public void UsoIQuerable()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            List<Employee> employees = ListEmployee();

            IQueryable<Employee> query = employees.AsQueryable().Where(x => x.Id == 2);

            foreach (var item in query) { Console.WriteLine(item.ToString()); }

        }
    }
}
