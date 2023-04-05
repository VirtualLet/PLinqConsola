using System;
using System.Linq;

namespace LINQ
{
    public  class Uso_Select:DataMethod
    {
       
        public void Operadores()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            var employee = ListEmployee();            

            var sintaxQuery = (from emp in employee
                              select emp).ToList();

            var sintaxMethod = employee.ToList();

            var sintaxMix = (from emp in employee
                                  select emp.Id+2).ToList();

            var basicPropMethod = employee.Select(emp => emp.Id).ToList();           

            foreach(var item in sintaxQuery)
            {
                Console.WriteLine(item);
            }
        }


        public void OperadoresSelect()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            var employee = ListEmployee();

            var selectQuery = (from emp in employee
                               select new EntStudent()
                               {
                                   StudentId  = emp.Id,
                                   StEmail = emp.Email,
                                   FullName=emp.Name
                               }).ToList();

            var selectMethod = employee.Select(item => new EntStudent
            {
                StudentId = item.Id,
                StEmail = item.Email,
                FullName = item.Name
            });

            foreach (var item in selectMethod)
            {
                Console.WriteLine(item);
            }
        }

        public void OperadorSelectAnonimo()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            var employee =ListEmployee();
            var selectQuery = (from emp in employee
                               select new 
                               {
                                   IdDefinido = emp.Id,
                                   EmailDefinido = emp.Email,
                                   NombreDefinido = emp.Name
                               }).ToList();

            var selectMethod = employee.Select(emp => new
            {
                IdDefinido = emp.Id,
                EmailDefinido = emp.Email,
                NombreDefinido = emp.Name
            }).ToList();

            foreach (var item in selectQuery)
            {
                Console.WriteLine($"Id={item.IdDefinido} , Email={item.EmailDefinido}, Nombre={item.NombreDefinido}");
            }
        }

        public void OperadorSelectConIndice()
        {
            Console.WriteLine("\n------" + System.Reflection.MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            var employee = ListEmployee();

            var selectMethod = employee.Select((emp, index) => new { Index = index, Nombre = emp.Name }).ToList();

            foreach (var item in selectMethod)
            {
                Console.WriteLine($"Id={item.Index} ,  Nombre={item.Nombre}");
            }

        }

    }
}
