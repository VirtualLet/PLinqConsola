using Linq_Repaso._11_Sortingoperators;
using Linq_Repaso._15_Reverse;
using Linq_Repaso._16_QuantifierOperators;
using Linq_Repaso._19_ContainsOperators;
using Linq_Repaso._20_SetOperations;
using Linq_Repaso._21_PartitioningOperators;
using Linq_Repaso._3_TiposDeSintaxis;
using Linq_Repaso._30_Paging;
using Linq_Repaso._31_JoinOperations;
using Linq_Repaso._36_ElementOperations;
using Linq_Repaso._4_IEnumerable_IQuerable;
using Linq_Repaso._5_Operators;
using Linq_Repaso._7_SelectMany;
using Linq_Repaso._8_FilteringOperators;
using System;

namespace Linq_Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            // TiposDeSintaxis_3();
            // IEnumerable_IQuereable_5();
            // Operators_5();
            // SelectMany_7();
            //FilteringOperators_8();
            //SortingOperators_11();
            // Reverse_15();
            //QuantifierOperators_16();
            //ContainsOperators_19();          
            //Distinct_21();
            //Except_22();
            //Intersect_23();
            //Union_24();
            //Take_26();
            //TakeWhile_27();
            //Skip_28();
            // SkipWhile_29();
            //Paging_30();
            //Join_31();
            ElementOperations_36();
            Console.ReadLine();
        }

        public static void ElementOperations_36()
        {
            var entidad = new ElementOperations();
            entidad.ElementAt();
            entidad.ElementAtOrDefault();
            entidad.ElementOrDefaulEjemConCondicion();
            entidad.First();
            entidad.FirstEjemConPredicado();
            entidad.FirstOrDefault();
            entidad.FirstOrDefaulEjem();
            entidad.Last();
            entidad.LastOrDefault();
            entidad.Single();
            entidad.SingleOrDefault();
        }

        public  static void Join_31()
        {
            var entidad = new Join();
            entidad.InnerJoinCon2Tablas();
            entidad.InnerJoinCon3Tablas();
            entidad.GroupJoinEjem();
            entidad.LeftJoin();
        }
        public static void Paging_30()
        {
            var entidad = new Paging();
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

        public static void SkipWhile_29()
        {
            var entidad = new SkipWhile();
            entidad.SkipWhileEjem();
            entidad.SkipWhileConString();
        }
        public static void Skip_28()
        {
            var entidad = new Skip();
            entidad.SkipEjem();
            entidad.SkipConString();
        }
        public static void TakeWhile_27()
        {
            var entidad = new TakeWhile();
            entidad.TakeWhileEjem();
            entidad.TakeWhileConString();

        }
        public static void Take_26()
        {
            var entidad = new Take();
            entidad.TakeEjemp();
            entidad.TakeEjempConWhere();
        }
        public static void Union_24()
        {
            var entidad = new Union();
            entidad.UnionEjem();
            entidad.UnionUsandoAnonimoFuncion();
            entidad.UnionUsandoIEqualityComparer();
        }
        public static void Intersect_23()
        {
            var entidad =new  Intersect();
            entidad.IntersectConListstring();
            entidad.IntersectUsandoFuncionesAnonimas();
            entidad.IntersectUsandoIEqualityComparer();
        }
        public static void Except_22()
        {
            var entidad = new Except();
            entidad.ExceptEjem();
            entidad.ExceptUsandoList();
            entidad.ExceptUsandoAnonimoFuncion();
            entidad.ExceptUsandoIEqualityComparer();
        }
        public static void Distinct_21()
        {
            var entidad = new Distinct();
            entidad.DistinctEjem();
            entidad.DistinctUsandoIEquatable();
            entidad.DistinctUsandoIEqualityComparer();
        }
        public static void ContainsOperators_19()
        {
            var entidad = new Contains();
            entidad.ContainsEjemUno();
            entidad.ContainsEjemDos();
            entidad.ContainsUsandoIEqualityComparer();
           
        }
        public static void QuantifierOperators_16()
        {
           
            var entidad = new QuantifierOperations();
            entidad.QuantifierAll();
            entidad.QuantifierAllEjempDos();
            entidad.QuantifierAny();
            entidad.QuantifierAnyEjemDos();
        }
        public static void Reverse_15()
        {
            var entidad = new Reverse();
            entidad.ReverseEjemp();
            entidad.ReverseEjempString();
            entidad.ReverseEjemAsEnumerable();
            entidad.ReverseEjemAsQueryable();
        }
        public static void SortingOperators_11()
        {
            var entidad = new SortingOperator();
            entidad.OrderByOpertors();
            entidad.OrderByOperatorsEjem2();
            entidad.OrderByOperatorsEjem3();
            entidad.OrderByDescendingEjemInt();
            entidad.OrderByDescendingEjemString();
            entidad.OrderByDescendingEjemClass();
            entidad.OrderBy_ThenBy();
        }
        public static void FilteringOperators_8()
        {
            var entidad = new FilteringOperators();
            entidad.UsoWhere();
            entidad.UsoWhereEjem2();
            entidad.UsoWhereEjem3();
            entidad.UsoTypeOf();
        }
        public static void SelectMany_7()
        {
            var entidad = new SelectMany();
            entidad.SelectManyEjem1();
            entidad.SelectManyEjem2();
            entidad.SelectManyEjem3();
        }
        public static void Operators_5()
        {
            var entidad = new Operators();
            entidad.Operadores();
            entidad.OperadoresSelect();
            entidad.OperadorSelectAnonimo();
            entidad.OperadorSelectConIndice();
        }
        public static void IEnumerable_IQuereable_4()
        {
            var entidad = new UsoIEnumerableIQuerable();
            entidad.UsoIEnumerable();
            entidad.UsoIQuerable();
        }
        public static void TiposDeSintaxis_3()
        {
           var tiposDeSintaxis = new TiposDeSintaxis();

            tiposDeSintaxis.QuerySintaxis();
            tiposDeSintaxis.MetodoSintaxis();
            tiposDeSintaxis.MixSintaxis();           
        }      
    }
 }
