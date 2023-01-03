using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_12QueryProgresivo
{
    class Program
    {
        static void Main(string[] args)
        {
            //En el progressive query el query que se realia se hace en varios pasos
            //Esto permite meter logica antes de obtener el resultado final

            //Se crea un arreglo sobre el cual trabajar
            string[] postres = { "pay de manzana", "pay de pera", "pastel de chocolate", "manzana caramelizada", "fresas con crema" };

            IEnumerable<string> resultado;
            bool mayusculas = false;
            var manzanas = postres.Where(item => item.Contains("manzana"));
            var ordenadas = manzanas.OrderBy(item => item);

            if (mayusculas)
                resultado = ordenadas.Select(item => item.ToUpper());
            else
                resultado = ordenadas;

            foreach (string elem in resultado)
                Console.WriteLine(elem);

            Console.WriteLine("------INTO-");
            /*Into se puede interpretar de dos formas, aqui se ve en una continuación de query
             * sólo se puede usar después de select o group
             * Digamos que reinicia el query permitiendo tener otros where, orderby y select
             * !!Cuidado con into las variables de rango salen de ambito, item no sera conocido
             * por el query de pays
             */
            IEnumerable<string> encontrados = from item in postres
                                              where item.Contains("manzana")
                                              orderby item
                                              select item
                                            into pays
                                              where pays.Contains("pay")
                                              select pays;

            foreach (string elem in encontrados)
                Console.WriteLine(elem);

            Console.WriteLine("----Wrapping");
            /*Envolve Queries -wrapping
             * Es otra opción de como podemos trabajar con el query
             * No confundir esta tecnica con los subqueryes que colocan el query en la expresion lambda
             */

            IEnumerable<string> miPay = from item in
                                            (
                                             from item1 in postres
                                             where item1.Contains("manzana")
                                             orderby item1
                                             select item1
                                             )
                                        where item.Contains("pay")
                                        select item;
            foreach (string elem in miPay)
                Console.WriteLine(elem);

            Console.WriteLine("---Realizando mismo ejemplo pero con la forma de query progresivo");

            IEnumerable<string> resPay;
            var manz = postres.Where(item => item.Contains("manzana"));
            var pay = manz.Where(item => item.Contains("pay"));
            resPay = pay.Select(item => item);

            foreach (string elem in resPay)
                Console.WriteLine(elem);

            Console.WriteLine("-----let");
            //let nos permite colocar una nueva variable junto con la de rango

            //Este ejemplo comentado devuelve nada porque
            //el primer contains se aplica a una colección 
            //y el segundo Contains se esta aplicando a una cadena,
            //lo que hace que busque exactamente la palabra "pay" solamente,
            //let fruta="pay de manzana", "manzana caramelizada"
            //where fruta.Contains("pay")= busca si contiene la palabra exacta "pay"
            //, y ... "pay de manzana"!= "pay" por eso no devuelve datos.

            //IEnumerable<string> prueba = from item in postres
            //                             let fruta = (
            //                                 from item1 in postres
            //                                 where item1.Contains("manzana")
            //                                 orderby item1
            //                                 select item1
            //                                 )
            //                             where fruta.Contains("pay")
            //                             select item;

            //para que funciones se debe cambiar a 
            //item= "pay de manzana", "pay de pera", "pastel de chocolate", "manzana caramelizada", "fresas con crema"
            //let fruta="pay de manzana", "manzana caramelizada"
            //fruta.Contains(item)="pay de manzana", "manzana caramelizada"
            //item.Contains("pay")= "pay de manzana", "pay de pera",
            //fruta.Contains(item) && item.Contains("pay")="pay de manzana"

            IEnumerable<string> prueba = from item in postres
                                         let fruta = (
                                             from item1 in postres
                                             where item1.Contains("manzana")
                                             orderby item1
                                             select item1
                                             )
                                         where fruta.Contains(item) && item.Contains("pay")
                                         select item;

            foreach (string elem in prueba)
                Console.WriteLine(elem);

            Console.WriteLine("---------------");

            var verfruta = (
                                             from item1 in postres
                                             where item1.Contains("manzana")
                                             select item1
                                             );
            var verpay=from item in verfruta
                       where item.Contains("pay")
                       select item;

            foreach (var ver in verfruta)
                Console.WriteLine(ver);

            Console.WriteLine("-----");

            foreach (var ver in verpay)
                Console.WriteLine(ver);

            Console.WriteLine("------Ejem LET");
            double[] precios = { 500, 300, 450, 250 };
            double interes = 2.5;
            var valores = from item in precios
                          let precioInteres = item * interes
                          where precioInteres <= 800
                          select new { item, precioInteres };

            foreach(var elem in valores)
                Console.WriteLine(elem);


            Console.ReadLine();
        }
    }
}
