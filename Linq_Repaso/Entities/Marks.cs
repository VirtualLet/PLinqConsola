using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Repaso.Entities
{
  public  class Marks
    {
        public int Id { get; set; }
        public int TrabajadorId { get; set; }
        public int TMarks { get; set; }


        public List<Marks> DataMarks()
        {
            var data = new List<Marks> { new Marks { Id=1, TrabajadorId=1, TMarks=80},
                                        new Marks { Id=2, TrabajadorId=2, TMarks=90},
                                        new Marks { Id=3, TrabajadorId=3, TMarks=95},
            };
            return data;
        }
    }
}
