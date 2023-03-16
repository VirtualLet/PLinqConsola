using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Repaso.Entities
{
   public class Student
    {
        public int StudentId { get; set; }
        public string StEmail { get; set; }
        public string FullName { get; set; }
        public int Marks { get; set; }

        public List<Subject> Subject { get; set; }
        public override string ToString()
        {
            return $"StudentId={StudentId}, StEmail={StEmail}, FullName={FullName}";
        }
    }

    public class StudentSimple
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id={Id}, Name={Name}";
        }
    }

    public class StudentComparer : IEqualityComparer<StudentSimple>
    {
        public bool Equals(StudentSimple x, StudentSimple y)
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


        public int GetHashCode(StudentSimple obj)
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
