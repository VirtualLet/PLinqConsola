using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Uso_SelectMany:DataMethod
    {
        public void SelectManyEjem1()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            List<string> strList = new List<string> { "Leticia", "BuCor" };
            Console.WriteLine("-----selectMethod\n");
            var selectMethod = strList.SelectMany(x => x).ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----selectQuery\n");
            var selectQuery = (from elem in strList
                               from ch in elem
                               select ch).ToList();


            foreach (var item in selectQuery)
            {
                Console.WriteLine(item);
            }
        }

        public void SelectManyEjem2()
        {

            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            var dataSource = ListEmployeConList();

            Console.WriteLine("-----selectMethod\n");
           var selectMethod= dataSource.SelectMany(x => x.Programming).ToList();

            foreach(var item in selectMethod)
            {
                Console.WriteLine("Programming - {0}",item);
            }

            Console.WriteLine("\n----SelectQuery\n");

            var selectQuery = (from data in dataSource
                               from item in data.Programming
                               select item).ToList();

            foreach (var item in selectQuery)
            {
                Console.WriteLine("Programming - {0}", item);
            }

        }

        public void SelectManyEjem3()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            var dataSource = new List<EntEmployee>()
            {
                new EntEmployee(){ Id=1, Name="Leticia", Email="let@gmail", Tecnology= 
                new List<EntTechs>(){
                                   new EntTechs(){ Technology= "c#" },
                                   new EntTechs(){ Technology="PHP"},
                                   new EntTechs(){ Technology="JAVA"}
                } },
                new EntEmployee(){ Id=2, Name="Kim", Email="Kim@gmail", Tecnology= 
                new List<EntTechs>(){
                                   new EntTechs(){ Technology= "linq" },
                                   new EntTechs(){ Technology="MVC"},
                                   new EntTechs(){ Technology="ASP.NET"}
                } },
                new EntEmployee(){ Id=3, Name="Harry", Email="Harry@gmail", Tecnology=
                new List<EntTechs>(){
                                   new EntTechs(){ Technology= "SQL" },
                                   new EntTechs(){ Technology="Oracle"},
                                   new EntTechs(){ Technology="MySql"}
                }},
                new EntEmployee(){Id=4, Name="Reto",Email="Reto@gmail", Tecnology= new List<EntTechs>() },
                new EntEmployee(){Id=5, Name="Plato",Email="Plato@gmail", Tecnology= new List<EntTechs>() }
            };

            var selectMethod = dataSource.SelectMany(emp => emp.Tecnology).ToList();

            var selectQuery = (from data in dataSource
                               from item in data.Tecnology
                               select item).ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine("Technology - {0}", item.Technology);
            }
        }

    }
}