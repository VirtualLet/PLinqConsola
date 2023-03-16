using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Repaso.Entities
{
  public  class StudentDistinct:IEquatable<StudentDistinct>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Equals(StudentDistinct other)
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
