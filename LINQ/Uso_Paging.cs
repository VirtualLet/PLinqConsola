using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public   class Uso_Paging
    {
        List<EntStudentSimple> dataSource;
        public Uso_Paging()
        {
            dataSource = DataStudent();

        }
        public int PageTotal { get => dataSource.Count() / PagesPerView;  }
        public int PagesPerView { get=> 5; } 
     
        public int NumPageActual { get; set; }

        public List<EntStudentSimple> DataStudent()
        {
            var dataSource = new List<EntStudentSimple> {
                     new EntStudentSimple { Id = 1, Name = "Leticia" },
                     new EntStudentSimple { Id = 2, Name = "Raul" },
                     new EntStudentSimple { Id = 3, Name = "Samuel" },
                     new EntStudentSimple { Id = 4, Name = "Laura" },
                     new EntStudentSimple { Id = 5, Name = "Martha" },
                     new EntStudentSimple { Id = 6, Name = "Leornardo" },
                     new EntStudentSimple { Id = 7, Name = "Armando" },
                     new EntStudentSimple { Id = 8, Name = "Rodrigo" },
                     new EntStudentSimple { Id = 9, Name = "Rafael" },
                     new EntStudentSimple { Id = 10, Name = "Georgina" },
                     new EntStudentSimple { Id = 11, Name = "Lira" },
                     new EntStudentSimple { Id = 12, Name = "Leonor" },
                     new EntStudentSimple { Id = 13, Name = "Edith" },
                     new EntStudentSimple { Id = 14, Name = "Lino" },
                     new EntStudentSimple { Id = 15, Name = "Edgar" },
                     new EntStudentSimple { Id = 16, Name = "Eduardo" },
                     new EntStudentSimple { Id = 17, Name = "Lalo" },
                     new EntStudentSimple { Id = 18, Name = "Abigay" },
                     new EntStudentSimple { Id = 19, Name = "Zory" },
                     new EntStudentSimple { Id = 20, Name = "Ramon" }                   
            };

            return dataSource;
        }


        public void PagingIndex()
        {          
            var selectMethod = dataSource.Skip(NumPageActual * PagesPerView).ToList();
                
            var dos= selectMethod.Take(PagesPerView).ToList();
            Console.WriteLine("---PaginasSiguientes");
            foreach(var item in dos)
            {
                Console.WriteLine(item);
            }
        }
        public void Pagina()
        {
            var selectMethod = dataSource.Skip((NumPageActual - 1) * PagesPerView).ToList();
            var dos=selectMethod.Take(PagesPerView).ToList();
            Console.WriteLine("\n----Paginas");
            foreach (var item in dos)
            {
                Console.WriteLine(item);
            }
        }

          

}
}
