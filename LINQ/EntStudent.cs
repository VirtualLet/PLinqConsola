using System.Collections.Generic;

namespace LINQ
{
    public class EntStudent
    {
        public int StudentId { get; set; }
        public string StEmail { get; set; }
        public string FullName { get; set; }
        public int Marks { get; set; }

        public List<EntSubject> Subject { get; set; }
        public override string ToString()
        {
            return $"StudentId={StudentId}, StEmail={StEmail}, FullName={FullName}";
        }
    }



}
