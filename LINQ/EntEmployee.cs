using System.Collections.Generic;

namespace LINQ
{
    public  class EntEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public  string Email { get; set; }

        public List<string> Programming { get; set; }

        public List<EntTechs> Tecnology { get; set; }

        public override string ToString()
        {
            return string.Format("Id:{0}, Name:{1}, Email:{2}", Id, Name, Email);
        }
    }

  
}
