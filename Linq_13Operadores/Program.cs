using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_13Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //OperadoresDeFiltro();
            //OperadoresDeProyeccion();
            OperadoresDeJoin();
            //OperadoresAgrupamiento();
            //OperadoresDeElemento();
            //OperadoresDeAgregacion();
            //OperadoresCuantificadores();
           // OperadoresDeGeneracion();
            Console.ReadLine();
        }
        public static void Informativo()
        {
            string info = string.Format("  Hay 3 categorias para los operadore de queyr" +
                   "Secuencia a secuencia (Secuencia de entrada, secuencia de salida)" +
                   "Secuencia de entradam elemento sencillo o escalar" +
                    "Nada de entrada, secuencia de salida" +
                "Secuencia a secuencia" +
                "Filtro:Where, Take , TakeWhile, Skip, SkipWhile, Distinct" +
                "Proyección: Select, SelectMany" +
                "Union: Join, GroupJoin, Zip" +
                "Ordenamiento: OrderBy, ThenBy, Reverse" +
                "Agrupamiento:GroupBy" +
                "Operadores de conjuntos:Concat,Union, Intersect, Except" +
                "Conversión import: OfType, Cast" +
                "Conversión export:ToArray, ToDictionary, ToLookup, AsEnumerable, AsQueryable ");
        }
        public static void OperadoresDeFiltro()
        {
            string[] postres = { "pay de manzana", "pay de pera","pastel de chocolate", "manzana caramelizada", "fresas con crema" };
            Console.WriteLine("------Where-----\n");

            //n=elemento { "pay de manzana", "pastel de chocolate", "manzana caramelizada", "fresas con crema" }
            //i=indice          0               1                       2                       3
            IEnumerable<string> filtroporIndice = postres.Where((n, i) => i % 2 == 0);
            foreach(string elem in filtroporIndice)
                Console.WriteLine(elem);

            Console.WriteLine("\n------StartsWith-----\n");
            IEnumerable<string> empiezaCon = from item in postres
                                             where item.StartsWith("pay")
                                             select item;


          //IEnumerable<string> empiezaConn = postres.Where(item => item.StartsWith("pay"));

            foreach (string elem in empiezaCon)
                Console.WriteLine(elem);

            Console.WriteLine("\n------EndsWith-----\n");
            IEnumerable<string> finalizaCon = from item in postres
                                              where item.EndsWith("manzana")
                                              select item;
            foreach(string elem in finalizaCon)
                Console.WriteLine(elem);

            Console.WriteLine("\n-----TakeWhile------\n");
            //TakeWhile  enumera la secuencia de entrada y emite cada elemento
            //hasta que el predicado es falso e ignora el resto
            int[] numeros = { 1, 5, 7, 3, 5, 9, 8, 11, 2, 4 };
            var resultadoTakeWhile = numeros.TakeWhile(item => item < 8);
            foreach(int elem in resultadoTakeWhile)
                Console.WriteLine(elem);

            Console.WriteLine("\n-----SkipWhile------\n");
            //Skipwhile enumera la secuencia de entrada e ignora los elementos
            //hasta que le predicado es falso y emite el resto
            var resultadoSkipWhile = numeros.SkipWhile(item => item < 8);
            foreach(int elem in resultadoSkipWhile)
                Console.WriteLine(elem);        
        }

        public static void OperadoresDeProyeccion()
        {
            //Proyección
            //select transforma el elemento de entrada con la expresión lambda
            //selectMay transforma elemento lo aplana y concatena con los subsecuencias resultantes

            //Se ha usado Select con tipos anonimos o para tomar el elemento completamente
            string[] postres = { "pay de manzana", "pay de pera", "pastel de chocolate", "manzana caramelizada", "fresas con crema" };

            Console.WriteLine("\n----Proyección Indexada-------\n");

            Console.WriteLine("\n----Select-----\n");
            //En Select cada elemento de entrada produce un elemento de salida
            IEnumerable<string> resultadoSelect = postres.Select((item, indice) => "Indice " + indice + " para el postre" + item);
            foreach(string elem in resultadoSelect)
                Console.WriteLine(elem);

            Console.WriteLine("\n-----SelectMany------\n");
            //En SelectMany produce 0..n elementos
            IEnumerable<string> resultadoSelectMany = postres.SelectMany(item => item.Split());
            foreach(string elem in resultadoSelectMany)
                Console.WriteLine(elem);

            Console.WriteLine("Se compara el mismo ejemplo pero son solo select");
            IEnumerable<string[]> resultadoSelectComp = postres.Select(item => item.Split());

          //  Console.WriteLine(resultadoSelectComp.ToArray()[0][1]);

            foreach (string[] elem in resultadoSelectComp)
            {
                Console.WriteLine("-");
                foreach(string valor in elem)
                Console.WriteLine(valor);
            }

            Console.WriteLine("\n----Select con multiples varialbes de rango------\n");
            IEnumerable<string> resultadoRango = from item in postres
                                                 from item1 in item.Split()
                                                 select item1 + "===>" + item;
            foreach(string elem in resultadoRango)
                Console.WriteLine(elem);

            Console.WriteLine("---");

            IEnumerable<string> resultadoRangoDos = from item in postres
                                                    from item1 in postres
                                                    select "Yo quiero " + item + "y tu quieres " + item1;
            foreach(string elem in resultadoRangoDos)
                Console.WriteLine(elem);

        }

        public static void OperadoresDeJoin()
        {
            /*Union-Joining
             join une los elementos de dos colecciones en un solo conjunto
             GroupJoin es como Join pero da un resultado jerarquico
             Zip Enumera dos secuencias y aplica una función a cada par*/
            Console.WriteLine("\n----Join-------\n");
            List<CEstudiante> listEstudiante = new List<CEstudiante>
            {
                new CEstudiante("Ana",100),
                new CEstudiante("Mario",150),
                new CEstudiante("Susana",180)
            };

            List<CCurso> listCurso = new List<CCurso>
            {
                new CCurso("Programación",100),
                new CCurso("Orientado objetos",150),
                new CCurso("Programación",150),
                new CCurso("Programacion",180),
                new CCurso("UML",100),
                new CCurso("UML",150)
            };

            Console.WriteLine("----Con Query");
            var listadoQuery = from e in listEstudiante
                               from c in listCurso
                               where c.Id == e.Id
                               select e.Nombre + " esta en el curso" + c.Curso;

            foreach (string elem in listadoQuery)
                Console.WriteLine(elem);

            Console.WriteLine("----Con join");           

            var listadoJoin = from e in listEstudiante
                              join c in listCurso on e.Id equals c.Id
                              select e.Nombre + " esta en el curso" + c.Curso;

            foreach (string elem in listadoJoin)
                Console.WriteLine(elem);

            Console.WriteLine("------------Haciendo pruebasMias para hacerlo con sintaxis de método");
            var listadoJoinconMetodo = listEstudiante.AsEnumerable().Join(listCurso.AsEnumerable(),
               listE => listE.Id,
               listC => listC.Id,
               (listE, listC)=> new
               {
                   nombre = listE.Nombre,
                   curso = listC.Curso,
                   pertenece = listE.Nombre + " esta en el curso" + listC.Curso
               });

            foreach (var elem in listadoJoinconMetodo)
                Console.WriteLine(elem); 

           

            Console.WriteLine("\n-----Con groupJoin------\n");
            //Los resultados se obtienen en forma jerarquica
            //la sintaxis es la misma pero utilizamos into

            var listadoInto = from e in listEstudiante
                              join c in listCurso on e.Id equals c.Id
                              into tempListado
                              select new { estudiante = e.Nombre, tempListado };

            foreach(var elem in listadoInto)
            {
                Console.WriteLine(elem.estudiante);

                foreach(var elem2 in elem.tempListado)
                {
                    Console.WriteLine(elem2);
                }
            }              

            Console.WriteLine("\n-----Con Zip------\n");
            //regresa una secuencia que aplica una función a cada par
            string[] postres = { "pay de manzana", "pay de pera", "pastel de chocolate", "manzana caramelizada", "fresas con crema" };
            string[] helados = { "chocolate", "vainilla", "fresa", "limon" };
            IEnumerable<string> resultadoZip = postres.Zip(helados, (p, h) => p + "-> con helado de " + h);

            foreach(string elem in resultadoZip)
                Console.WriteLine(elem);

            Console.WriteLine("\n------Con OrderBy-----\n");
            //Ordenamiento
            //OrderBy, ThenBy Ordena en orden ascendente
            //OrderByDescending, ThenByDescending Ordena en orden descendete
            //Reverse Regresa en el orden inverso
            int[] numeros = { 1, 5, 7, 3, 5, 9, 8, 11, 2, 4 };

            IEnumerable<int> numOrderAsc = numeros.OrderBy(item => item);
            Console.WriteLine("--Orden ascendente");
            foreach(int elem in numOrderAsc)
                Console.WriteLine(elem);

            Console.WriteLine("\n-----Con OrderBy Descending------\n");
            IEnumerable<int> numOrderDesc = numeros.OrderByDescending(item => item);
            foreach (int elem in numOrderDesc)
                Console.WriteLine(elem);

            Console.WriteLine("\n------Ordenar cadenas----------\n");

            string[] palabras = { "hola", "piedra", "pato", "pastel", "carros", "auto" };

            Console.WriteLine("--Ordena por longitud de cadena y por orden ascendente dependiendo de la longitud de cadena");
            IEnumerable<string> palabrasOrdenadas = palabras.OrderBy(item => item.Length).ThenBy(item => item);
            foreach (string elem in palabrasOrdenadas)
                Console.WriteLine(elem);

            Console.WriteLine("--Ordena de forma ascendente");
            IEnumerable<string> palabrasOrd = palabras.OrderBy(item => item);
            foreach(string elem in palabrasOrd)
                Console.WriteLine(elem);
          
        }

        public static void OperadoresAgrupamiento()
        {
            //GroupBy, First, FirstOrDefault,Single, SingleOrDefault
            Console.WriteLine("\n----GroupBy: Agrupa una secuencia en subsecuencias----\n");

            string[] archivos = System.IO.Directory.GetFiles(@"H:\CURSOS\SENAExcel\DocApoyo");

            Console.WriteLine("----Archivos obtenidos por GetFiles-----\t\n");
            foreach(string elem in archivos)
                Console.WriteLine(elem);

            //Agrupados basados en la extensión
            //Adentro de () colocamos el criterio de agrupamiento

            var archivoAgrupado = archivos.GroupBy(item => System.IO.Path.GetExtension(item));
            
            Console.WriteLine("----Resultado agrupado-----\t\n");
            foreach(IGrouping<string,string> elem in archivoAgrupado)
            {
                //Aqui se usa la llave de agrupamiento
                Console.WriteLine("Archivos de extensión {0}",elem.Key);
                foreach(string valor in elem)
                    Console.WriteLine("\t {0}",valor);
            }

            /////////////////////////////////////
            ///Conguntos: Concat, Union, Instersect, Except
            ///

            /////////////////////////////////////
            ///Conversion
            ///OfType: Convierte de IEnumerable a IEnumerable<T>, desecha los elementos erroneos
            ///Cast: Convierte de IEnumerable a IEnumerable<T>, lanza excepción con los elementos erroneos
            ///ToArray Convierte de IEnumerable a IEnumerable<T> a T[]
            ///ToList: Convierte de IEnumerable a IEnumerable<T> a List<T>
            ///ToDictionary: Convierte de IEnumerable a IEnumerable<T> a Dictionary <TKey,TValue>
            ///ToLookup:Convierte de IEnumerable a IEnumerable<T> a ILookup<TKey, TElement>
            ///AsEnumerable: Hace downcast a  IEnumerable<T>
            ///AsQueryable: Hace cast o convierte a IQueryable<T>
            
            ///////////////////////////////////////
            ///De elemento
            ///First, FirstOrDefault    Regresa primer elemento de la secuencia
            ///Last, LastOrDefault      Regresa el último elemento de la secuencia
            ///Single, SingleorDefault  Equivalente a First, FirstOrDefault pero lanza un excepcion si hay ma de un elemento
            ///ElementAt, ElementAtOrDefault    Regresa el elemento de determinada posicion
            ///DefaultIfEmpy    Regresa al elemento de default is la secuencia no tiene elementos

        }
        public static void OperadoresDeElemento()
        {
            Console.WriteLine("---Operadores de elemento");

            int[] numeros = { 1, 5, 7, 3, 5, 9, 8, 11, 2, 4 };

            Console.WriteLine("---First:Obtiene el primer elemento");
            int primer = numeros.First();
            Console.WriteLine(primer);

            Console.WriteLine("---Primero que cumpla cierta información, pero si no lo encuentra marcara error");
            int primeroCondicion = numeros.First(item => item % 2 == 0);
            Console.WriteLine(primeroCondicion);

            Console.WriteLine("---Primero que cumpla o default, si no lo encuentra retornara el valor de  default del tipo en este caso entero=0");
            int primeroOrDefault = numeros.FirstOrDefault(item => item % 57 == 0);
            Console.WriteLine(primeroOrDefault);
        }

        public static void OperadoresDeAgregacion()
        {
            /*Agregación
             * Count, LongCount regresa la cantidad de elementos en la secuencia int, o int64
             * Mix Regresa el elemento menor de la secuencia
             * Max Regresa el elemento mayor de la secuencia
             * Sum Regresa la sumatoria de los elementos
             * Average Regresa el promedio de los elementos
             * Aggregate Hace una agregacion usando nuestro algoritmo
            */
            Console.WriteLine("--DeAgregacion---\n");
            int[] numeros = { 1, 5, 7, 3, 5, 9, 8, 11, 2, 4 };
            int sumatoria = numeros.Sum();
            Console.WriteLine("Sumatoria de numeros es:{0}",sumatoria);

            int[] numerosDos = { 1, 2, 3, 4, 5 };
            int agregados = numerosDos.Aggregate(0, (acumulador, itemNumerosDos) => acumulador + (itemNumerosDos * 2));
            //0+(1*2)=2+(2*2)=6+(3*2)=12+(4*2)=20+(5*2)=30
            Console.WriteLine("Usando Aggregate para ir sumando los acumulados: {0}",agregados);


        }

        public static void OperadoresCuantificadores()
        {
            /*Cuantificadores
             * Contains Regresa true si la secuencia contiene el elemento
             * Any  Regresa true si un elemento satisface al predicado
             * All  Regresa true si todos los elementos satisfacen al predicado
             * SequenciaEqual Regresa true si la segunda secuencia tiene elementos identicos a la de entrada
             */
            Console.WriteLine("----Cuantificadores----\n");
            int[] numeros = { 1, 5, 7, 3, 5, 9, 8, 11, 2, 4 };        
            int[] numerosDos = { 1, 2, 3, 4, 5 };
            bool todos = numerosDos.All(item => item < 10);
            Console.WriteLine("Todos los elementos del arreglo numerosDos son menores a diez:{0}",todos);

            bool iguales = numerosDos.SequenceEqual(numeros);
            Console.WriteLine("Los elementos del arreglo numeros es igual al del arreglo numerosDos: {0}",iguales);

        }

        public static void OperadoresDeGeneracion()
        {
            /*Generación 
             * Empty    Crea una secuencia vacia
             * Repeat   Crea una secuencia de elementos que se repiten
             * Range    Crea una secuencia de enteros
             */
            Console.WriteLine("----Generacion--\n");
            var vacia = Enumerable.Empty<int>();
            foreach(int elem in vacia)
                Console.WriteLine(elem);

            Console.WriteLine("-----Repeat----");
            var repetir = Enumerable.Repeat("hola", 5);
            //foreach(string elem in repetir)
            //    Console.WriteLine("{0}", elem);

            for(int i=0; i<repetir.Count(); i++)
                Console.WriteLine("[{0}] {1}", i,repetir.ElementAt(i));

            Console.WriteLine("----Rango----");
            var rango = Enumerable.Range(5, 15);//Inicio, elementos
            //foreach(int elem in rango)
            //    Console.WriteLine("{0}", elem);

            for (int i = 0; i < rango.Count(); i++)
                Console.WriteLine("[{0}] {1}", i, rango.ElementAt(i));

        }


        
    }
}
