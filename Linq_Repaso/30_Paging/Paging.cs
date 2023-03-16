using Linq_Repaso.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Repaso._30_Paging
{
 public   class Paging
    {
        List<StudentSimple> dataSource;
        public Paging()
        {
            dataSource = DataStudent();

        }
        public int PageTotal { get => dataSource.Count() / PagesPerView;  }
        public int PagesPerView { get=> 5; } 
     
        public int NumPageActual { get; set; }

        public List<StudentSimple> DataStudent()
        {
            var dataSource = new List<StudentSimple> {
                     new StudentSimple { Id = 1, Name = "Leticia" },
                     new StudentSimple { Id = 2, Name = "Raul" },
                     new StudentSimple { Id = 3, Name = "Samuel" },
                     new StudentSimple { Id = 4, Name = "Laura" },
                     new StudentSimple { Id = 5, Name = "Martha" },
                     new StudentSimple { Id = 6, Name = "Leornardo" },
                     new StudentSimple { Id = 7, Name = "Armando" },
                     new StudentSimple { Id = 8, Name = "Rodrigo" },
                     new StudentSimple { Id = 9, Name = "Rafael" },
                     new StudentSimple { Id = 10, Name = "Georgina" },
                     new StudentSimple { Id = 11, Name = "Lira" },
                     new StudentSimple { Id = 12, Name = "Leonor" },
                     new StudentSimple { Id = 13, Name = "Edith" },
                     new StudentSimple { Id = 14, Name = "Lino" },
                     new StudentSimple { Id = 15, Name = "Edgar" },
                     new StudentSimple { Id = 16, Name = "Eduardo" },
                     new StudentSimple { Id = 17, Name = "Lalo" },
                     new StudentSimple { Id = 18, Name = "Abigay" },
                     new StudentSimple { Id = 19, Name = "Zory" },
                     new StudentSimple { Id = 20, Name = "Ramon" }                   
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
