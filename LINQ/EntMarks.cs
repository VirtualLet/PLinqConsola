using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  LINQ
{
  public  class EntMarks
    {
        public int Id { get; set; }
        public int TrabajadorId { get; set; }
        public int TMarks { get; set; }


        public List<EntMarks> DataMarks()
        {
            var data = new List<EntMarks> { new EntMarks { Id=1, TrabajadorId=1, TMarks=80},
                                        new EntMarks { Id=2, TrabajadorId=2, TMarks=90},
                                        new EntMarks { Id=3, TrabajadorId=3, TMarks=95},
            };
            return data;
        }
    }
}
