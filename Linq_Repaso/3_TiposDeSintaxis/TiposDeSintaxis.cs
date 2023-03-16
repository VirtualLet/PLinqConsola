using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Repaso._3_TiposDeSintaxis
{
  public  class TiposDeSintaxis
    {
        private  List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        public void MetodoSintaxis()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            //DataSource.ContionMethod().SelectionMethod()
           
            var methodSintaxis = list.Where(obj => obj > 5);

            foreach (var item in methodSintaxis) { Console.WriteLine(item); };
        }

        public void QuerySintaxis()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            /* (FROM object IN dataSource
             * WHERE condition
             * SELECT object).METHOD()             */

            var querySyntaxis = from obj in list
                                where obj > 5
                                select obj;

            foreach (var item in querySyntaxis) { Console.WriteLine(item); };
            
        }

        public void MixSintaxis()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
                       
            var mixedSyntaxis = (from obj in list
                                 select obj).Max();

            Console.WriteLine("valor maximo: {0}",mixedSyntaxis);

        }

    }
}
