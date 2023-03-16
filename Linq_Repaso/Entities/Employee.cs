using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Repaso.Entities
{
  public  class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public  string Email { get; set; }

        public List<string> Programming { get; set; }

        public List<Techs> Tecnology { get; set; }

        public override string ToString()
        {
            return string.Format("Id:{0}, Name:{1}, Email:{2}", Id, Name, Email);
        }
    }

  
}
