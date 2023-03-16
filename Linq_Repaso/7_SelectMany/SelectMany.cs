using Linq_Repaso.Entities;
using Linq_Repaso.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Repaso._7_SelectMany
{
    public class SelectMany:DataMethod
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

            var dataSource = new List<Employee>()
            {
                new Employee(){ Id=1, Name="Leticia", Email="let@gmail", Tecnology= 
                new List<Techs>(){
                                   new Techs(){ Technology= "c#" },
                                   new Techs(){ Technology="PHP"},
                                   new Techs(){ Technology="JAVA"}
                } },
                new Employee(){ Id=2, Name="Kim", Email="Kim@gmail", Tecnology= 
                new List<Techs>(){
                                   new Techs(){ Technology= "linq" },
                                   new Techs(){ Technology="MVC"},
                                   new Techs(){ Technology="ASP.NET"}
                } },
                new Employee(){ Id=3, Name="Harry", Email="Harry@gmail", Tecnology=
                new List<Techs>(){
                                   new Techs(){ Technology= "SQL" },
                                   new Techs(){ Technology="Oracle"},
                                   new Techs(){ Technology="MySql"}
                }},
                new Employee(){Id=4, Name="Reto",Email="Reto@gmail", Tecnology= new List<Techs>() },
                new Employee(){Id=5, Name="Plato",Email="Plato@gmail", Tecnology= new List<Techs>() }
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