using System;
using System.Linq;
using System.Reflection;

namespace LINQ
{
    public class Uso_Quantifier:DataMethod
    {

        public void QuantifierAll()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo

            var dataSource = ArregloStudent();

            var selectMethod = dataSource.All(x => x.Marks > 70);

            var selectQuery = (from data in dataSource
                               select data).All(x => x.Marks > 70);
            Console.WriteLine("Verifica se la condicion se cumple para toda la coleccion:{0}",selectMethod);

        }

        public void QuantifierAllEjempDos()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            var dataSource = ArregloStudentConList();

            var selectMethod = dataSource.Where(std => std.Subject.All(x => x.SubjectMarks > 70))
                                         .Select(std => std.FullName).ToList();

            var selectQuery = (from data in dataSource
                               where data.Subject.All(x => x.SubjectMarks > 70)
                               select data.FullName).ToList();

            Console.WriteLine("La condición se cumple? {0}", selectMethod.Count > 0);
            foreach (var elem in selectMethod)
            {
                Console.WriteLine("\nFullName:{0}", elem);
                //Console.WriteLine("\nFullName:{0}, Mark:{1}",elem.FullName,elem.Marks);
                //for (int i=0; i< elem.Subject.Count; i++)
                // {
                //     Console.WriteLine("SubjectMarks:{0}, SubjectName:{1}",elem.Subject[i].SubjectMarks, elem.Subject[i].SubjectName);
                // }
            }           
        }

        public void QuantifierAny()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            var dataSource = ListInt();
            var selectMethod = dataSource.Any();

            Console.WriteLine("Muestra si la colección contiene elementos o no? {0}",selectMethod);
        }

        public void QuantifierAnyEjemDos()
        {
            Console.WriteLine("\n------" + MethodBase.GetCurrentMethod().Name + "------\n");//Obtiene el nombre del metodo
            var dataSource = ArregloStudent();
            var selectMethod = dataSource.Any(x => x.Marks > 80);
            Console.WriteLine("Muestra si se cumple la condición al menos para algun" +
                "elemento de la colección ? {0}", selectMethod);
        }
    }
}
