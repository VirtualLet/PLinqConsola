using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //TiposDeSintaxis_3();
            IEnumerable_IQuereable_4();
            Select_5();
            SelectMany_7();
            FilteringOperators_8();
            SortingOperators_11();
            Reverse_15();
            QuantifierOperators_16();
            ContainsOperators_19();
            Distinct_21();
            Except_22();
            Intersect_23();
            Union_24();
            Take_26();
            TakeWhile_27();
            Skip_28();
            SkipWhile_29();
            PaginacionEjemplo_30();
            Join_31();
            ElementOperations_36();
            Console.ReadLine();
        }

        public void Informativo()
        {
            string.Format("LINQ: Linq Integrated Query \n" +
            "Es una forma concisa , simetrica y fuertemente tipificada de acceder a datos \n" +
            "Requisitos \n" +
            "C#, POO \n" +
            "Tipos implicitos, colecciones , expresiones lambda, métodos a extensión, tipos anonimos \n" +
            "LINQ to Objects -->Se usa para arreglos y colecciones \n" +
            "LINQ to XML--> Para manipular y hacer queries a documentos XML \n" +
            "Linq to Dataset-->Se usa con objetos DataSet de ADO.NET \n" +
            "Linq to Entities -->Para queries con el API de Entity Framework de ADO.NET \n" +
            "Parallel LINQ--> Para el procesamiento een paralelo de los datos que regresa un query \n");
            
        }

        public static void TiposDeSintaxis_3()
        {
            var tiposDeSintaxis = new Uso_TiposDeSintaxis();

            tiposDeSintaxis.QuerySintaxis();
            tiposDeSintaxis.MetodoSintaxis();
            tiposDeSintaxis.MixSintaxis();
        }

        public static void IEnumerable_IQuereable_4()
        {
            var entidad = new Uso_IEnumerableIQuerable();
            entidad.UsoIEnumerable();
            entidad.UsoIQuerable();
        }
        public static void Select_5()
        {
            var entidad = new Uso_Select();
            entidad.Operadores();
            entidad.OperadoresSelect();
            entidad.OperadorSelectAnonimo();
            entidad.OperadorSelectConIndice();
        }

        public static void SelectMany_7()
        {
            var entidad = new Uso_SelectMany();
            entidad.SelectManyEjem1();
            entidad.SelectManyEjem2();
            entidad.SelectManyEjem3();
        }

        public static void FilteringOperators_8()
        {
            var entidad = new Uso_Where();
            entidad.UsoWhere();
            entidad.UsoWhereEjem2();
            entidad.UsoWhereEjem3();
            var entidadType = new Uso_TypeOf();
            entidadType.UsoTypeOf();
        }

        public static void SortingOperators_11()
        {
            var entidad = new Uso_OrderBy();
            entidad.OrderByOpertors();
            entidad.OrderByOperatorsEjem2();
            entidad.OrderByOperatorsEjem3();
            entidad.OrderByDescendingEjemInt();
            entidad.OrderByDescendingEjemString();
            entidad.OrderByDescendingEjemClass();
            entidad.OrderBy_ThenBy();
        }

        public static void Reverse_15()
        {
            var entidad = new Uso_Reverse();
            entidad.ReverseEjemp();
            entidad.ReverseEjempString();
            entidad.ReverseEjemAsEnumerable();
            entidad.ReverseEjemAsQueryable();
        }

        public static void QuantifierOperators_16()
        {
            var entidad = new Uso_Quantifier();
            entidad.QuantifierAll();
            entidad.QuantifierAllEjempDos();
            entidad.QuantifierAny();
            entidad.QuantifierAnyEjemDos();
        }

        public static void ContainsOperators_19()
        {
            var entidad = new Uso_Contains();
            entidad.ContainsEjemUno();
            entidad.ContainsEjemDos();
            entidad.ContainsUsandoIEqualityComparer();
        }
        public static void Union_24()
        {
            var entidad = new Uso_Union();
            entidad.UnionEjem();
            entidad.UnionUsandoAnonimoFuncion();
            entidad.UnionUsandoIEqualityComparer();
        }
        public static void Intersect_23()
        {
            var entidad = new Uso_Intersect();
            entidad.IntersectConListstring();
            entidad.IntersectUsandoFuncionesAnonimas();
            entidad.IntersectUsandoIEqualityComparer();
        }
        public static void Except_22()
        {
            var entidad = new Uso_Except();
            entidad.ExceptEjem();
            entidad.ExceptUsandoList();
            entidad.ExceptUsandoAnonimoFuncion();
            entidad.ExceptUsandoIEqualityComparer();
        }
        public static void Distinct_21()
        {
            var entidad = new Uso_Distinct();
            entidad.DistinctEjem();
            entidad.DistinctUsandoIEquatable();
            entidad.DistinctUsandoIEqualityComparer();
        }

        public static void Skip_28()
        {
            var entidad = new Uso_Skip();
            entidad.SkipEjem();
            entidad.SkipConString();
        }
        public static void TakeWhile_27()
        {
            var entidad = new Uso_TakeWhile();
            entidad.TakeWhileEjem();
            entidad.TakeWhileConString();

        }
        public static void Take_26()
        {
            var entidad = new Uso_Take();
            entidad.TakeEjemp();
            entidad.TakeEjempConWhere();
        }
        public static void SkipWhile_29()
        {
            var entidad = new Uso_SkipWhile();
            entidad.SkipWhileEjem();
            entidad.SkipWhileConString();
        }
    
        public static void PaginacionEjemplo_30()
        {
            var entidad = new Uso_Paging();
            bool cumple = true;
            do
            {
                Console.WriteLine("\nDarme el num de Pag Actual");
                if (int.TryParse(Console.ReadLine(), out int numPagActual))
                {
                    entidad.NumPageActual = numPagActual;
                    entidad.Pagina();
                    entidad.PagingIndex();
                }
                else
                {
                    Console.WriteLine("Introducir un numero de pagina valido");
                    cumple = false;
                }
            } while (cumple);
        }

     
        public static void Join_31()
        {
            var entidad = new Uso_Join();
            entidad.InnerJoinCon2Tablas();
            entidad.InnerJoinCon3Tablas();

            entidad.GroupJoinEjem();

            entidad.LeftJoin();
        }
        public static void ElementOperations_36()
        {
            var entidad = new Uso_ElementAt();
            entidad.ElementAt();
            entidad.ElementAtOrDefault();
            entidad.ElementOrDefaulEjemConCondicion();

            var entidadFirst = new Uso_First();
            entidadFirst.First();
            entidadFirst.FirstEjemConPredicado();
            entidadFirst.FirstOrDefault();
            entidadFirst.FirstOrDefaulEjem();

            var entidadLast = new Uso_Last();
            entidadLast.Last();
            entidadLast.LastOrDefault();

            var entidadSingle = new Uso_Single();
            entidadSingle.Single();
            entidadSingle.SingleOrDefault();
        }

    }
}
