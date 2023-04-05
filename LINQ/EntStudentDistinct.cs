using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
  public  class EntStudentDistinct:IEquatable<EntStudentDistinct>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Equals(EntStudentDistinct other)
        {
           if(object.ReferenceEquals(other, null)) { return false; }
           if (object.ReferenceEquals(this, other)) { return true; }

            return Id.Equals(other.Id) && Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            int idHashCode = Id.GetHashCode();
            int nameHashCode = Name.GetHashCode();

            return idHashCode ^ nameHashCode;
        }
    }

}
