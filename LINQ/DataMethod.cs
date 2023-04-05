using System.Collections.Generic;

namespace LINQ
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
        protected List<EntEmployee> ListEmployeConList()
        {
            var dataSource = new List<EntEmployee>()
            {
                new EntEmployee(){ Id=1, Name="Leticia", Email="let@gmail", Programming= new List<string>(){"c#","PHP","Java"}},
                new EntEmployee(){ Id=2, Name="Kim", Email="Kim@gmail", Programming= new List<string>(){"linq","MVC","ASP.NET"}},
                new EntEmployee(){ Id=3, Name="Harry", Email="Harry@gmail", Programming= new List<string>(){"SQL","Oracle","MySql"}}
            };

            return dataSource;
        }

        protected List<EntEmployee> ListEmployeeConListEnt()
        {
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

            return dataSource;
        }

        protected List<EntStudent> ListStudent()
        {
            List<EntStudent> student = new List<EntStudent>
            {
                new EntStudent{ StudentId=1, FullName="Leticia"},
                new EntStudent{ StudentId=2, FullName="John"},
                new EntStudent{ StudentId=3, FullName="Edith"}
            };
            return student;
        }

        protected EntStudent[] ArregloStudent()
        {
            EntStudent[] students =
            {
                new EntStudent{ FullName="Leticia",Marks=90},
                new EntStudent{ FullName="John",Marks=80},
                new EntStudent{ FullName="Lee", Marks=75}
            };
            return students;
        }

        protected EntStudent[] ArregloStudentConList()
        {
            EntStudent[] students =
            {
                new EntStudent{ FullName="Leticia",Marks=90, 
                    Subject=new List<EntSubject>{ 
                                             new EntSubject { SubjectName="Math", SubjectMarks=75 },
                                             new EntSubject { SubjectName="English", SubjectMarks=85 },
                                             new EntSubject { SubjectName="Art", SubjectMarks=60 }
                    } },
                new EntStudent{ FullName="John",Marks=80,
                    Subject=new List<EntSubject>{
                                             new EntSubject { SubjectName="Math", SubjectMarks=89 },
                                             new EntSubject { SubjectName="English", SubjectMarks=91 },
                                             new EntSubject { SubjectName="Art", SubjectMarks=90 }
                    } },
                new EntStudent{ FullName="Lee", Marks=75,
                     Subject=new List<EntSubject>{
                                             new EntSubject { SubjectName="Math", SubjectMarks=60 },
                                             new EntSubject { SubjectName="English", SubjectMarks=92 },
                                             new EntSubject { SubjectName="Art", SubjectMarks=70 }
                    } }
            };
            return students;
        }
    }
}
