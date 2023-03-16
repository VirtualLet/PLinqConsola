using Linq_Repaso.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Repaso.Metodos
{
 public abstract class DataMethod
    {

        protected List<int> ListInt()
        {
            var dataSource = new List<int>() { 1, 3, 4, 5, 6, 7, 8, 9, 10 };
            return dataSource;
        }
        protected List<string> ListString()
        {
            var dataSource = new List<string>() { "Tomy", "Leticia", "Eli", "Ponting", "Sachin" };
            return dataSource;
        }

        protected List<object> ListObject()
        {
            var dataSource = new List<object>() { "adam", "Let","laura","Ronaldo" ,1, 2, 3, 4 };
            return dataSource;
        }

        protected int[] ArregloInt()
        {
            var dataSource = new int[] { 1, 2, 3, 4, 5, 6, 8, 7 };
            return dataSource; 
        }

        protected List<Employee> ListEmployee()
        {
            List<Employee> employees = new List<Employee>
             {
                new Employee {Id=1, Name="Leticia", Email="let@gmail.com"},               
                new Employee {Id=2, Name="Edith", Email="edi@gmail.com"},
                new Employee {Id=3, Name="Manuel", Email="man@gmail.com"},
                new Employee {Id=4, Name="Ale", Email="ale@gmail.com"},
                new Employee {Id=5, Name="Leticia", Email="tom@gmail.com"}
             };
            return employees;
        }
        protected List<Employee> ListEmployeConList()
        {
            var dataSource = new List<Employee>()
            {
                new Employee(){ Id=1, Name="Leticia", Email="let@gmail", Programming= new List<string>(){"c#","PHP","Java"}},
                new Employee(){ Id=2, Name="Kim", Email="Kim@gmail", Programming= new List<string>(){"linq","MVC","ASP.NET"}},
                new Employee(){ Id=3, Name="Harry", Email="Harry@gmail", Programming= new List<string>(){"SQL","Oracle","MySql"}}
            };

            return dataSource;
        }

        protected List<Employee> ListEmployeeConListEnt()
        {
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

            return dataSource;
        }

        protected List<Student> ListStudent()
        {
            List<Student> student = new List<Student>
            {
                new Student{ StudentId=1, FullName="Leticia"},
                new Student{ StudentId=2, FullName="John"},
                new Student{ StudentId=3, FullName="Edith"}
            };
            return student;
        }

        protected Student[] ArregloStudent()
        {
            Student[] students =
            {
                new Student{ FullName="Leticia",Marks=90},
                new Student{ FullName="John",Marks=80},
                new Student{ FullName="Lee", Marks=75}
            };
            return students;
        }

        protected Student[] ArregloStudentConList()
        {
            Student[] students =
            {
                new Student{ FullName="Leticia",Marks=90, 
                    Subject=new List<Subject>{ 
                                             new Subject { SubjectName="Math", SubjectMarks=75 },
                                             new Subject { SubjectName="English", SubjectMarks=85 },
                                             new Subject { SubjectName="Art", SubjectMarks=60 }
                    } },
                new Student{ FullName="John",Marks=80,
                    Subject=new List<Subject>{
                                             new Subject { SubjectName="Math", SubjectMarks=89 },
                                             new Subject { SubjectName="English", SubjectMarks=91 },
                                             new Subject { SubjectName="Art", SubjectMarks=90 }
                    } },
                new Student{ FullName="Lee", Marks=75,
                     Subject=new List<Subject>{
                                             new Subject { SubjectName="Math", SubjectMarks=60 },
                                             new Subject { SubjectName="English", SubjectMarks=92 },
                                             new Subject { SubjectName="Art", SubjectMarks=70 }
                    } }
            };
            return students;
        }
    }
}
