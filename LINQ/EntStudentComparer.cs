using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
   public class EntStudentComparer : IEqualityComparer<EntStudentSimple>
    {
        public bool Equals(EntStudentSimple x, EntStudentSimple y)
        {
            if (object.ReferenceEquals(x, y))
            {
                return true;
            }

            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
            {
                return false;
            }

            return x.Id == y.Id && x.Name == y.Name;
        }


        public int GetHashCode(EntStudentSimple obj)
        {
            if (object.ReferenceEquals(obj, null))
            {
                return 0;
            }

            int idHasCode = obj.Id.GetHashCode();
            int nameHashCode = obj.Name == null ? 0 : obj.Name.GetHashCode();

            return idHasCode ^ nameHashCode;
        }
    }
}
