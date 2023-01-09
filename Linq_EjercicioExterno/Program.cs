using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_EjercicioExterno
{
    class Program
    {
        static List<CFactura> facturas;
        static List<CFactura> facturasFiltradas;
        static void Main(string[] args)
        {
            //GetFactura();
            GenerarFactura();
            SintaxisMetodo();          
            //SintaxisConsulta();

            Console.ReadLine();
        }

        public static void SintaxisMetodo()
        {
            //cuando se realiza una consulta linq por defecto devuelve en un valor IEnumerable , al asignarlo a una lista como es el caso
            //Se tiene 2 opciones, convervitr el metodo de sintaxis a una lista con ToList() / cambiar Lis<CFactura> por IEnumerable<CFactura>
            Console.WriteLine("SINTAXIS DE METODO");
            Console.WriteLine("Encuentra facturas donde el total>200--\n");
            facturasFiltradas = facturas.Where(item=>item.Total>200).ToList();

            foreach(CFactura elem in facturasFiltradas)
            {
                Console.WriteLine(elem);
                foreach (CFacturaDetalle subElem in elem.Detalles)
                {
                    Console.WriteLine(subElem);
                }
                
            }

            Console.WriteLine("\n--Encuentra facturas tenga más de un detalle--\n");
            facturasFiltradas = facturas.Where(item => item.Detalles.Count > 1).ToList();

            foreach (CFactura elem in facturasFiltradas)
            {
                Console.WriteLine(elem);
                foreach (CFacturaDetalle subElem in elem.Detalles)
                {
                    Console.WriteLine(subElem);
                }
            }
        }

        public static void SintaxisConsulta()
        {
            Console.WriteLine("SINTAXIS DE CONSULTA");
            Console.WriteLine("Encuentra facturas donde el total>200--\n");
            facturasFiltradas = (from item in facturas
                                                 where item.Total > 200
                                                 select item).ToList();

            foreach (CFactura elem in facturasFiltradas)
            {
                Console.WriteLine(elem);
                foreach (CFacturaDetalle subElem in elem.Detalles)
                {
                    Console.WriteLine(subElem);
                }
               
            }

            Console.WriteLine("\n***************Encuentra facturas tenga más de un detalle--\n");
            facturasFiltradas = (from item in facturas
                                 where item.Detalles.Count > 1
                                 select item).ToList();
            foreach (CFactura elem in facturasFiltradas)
            {
                Console.WriteLine(elem);
                foreach (CFacturaDetalle subElem in elem.Detalles)
                {
                    Console.WriteLine(subElem);
                }
               
            }


        }


       public static void GenerarFactura()
        {

            facturas = new List<CFactura>
            {
                new CFactura(1,"Pedro","Carlos",DateTime.Now,1000,0,190,1190,
                            new List<CFacturaDetalle>{ new CFacturaDetalle(1,1,"Jabon",100,10)}
                            ),
                 new CFactura(2,"Luis","Linda",DateTime.Now,200,30,50,220,
                            new List<CFacturaDetalle>{ new CFacturaDetalle(2,2,"Fruta",200,10),
                                                       new CFacturaDetalle(3,2,"Fruta",150,5)}
                            )
            };
        }
            
        public static void GetFactura()
        {
            //List<CFactura> facturas;
            facturas = new List<CFactura> {
                  new CFactura
                  {
                      NumFactura = 1,
                      Cliente = "Pedro",
                      Empleado = "Carlos",
                      Fecha = DateTime.Now,
                      Subtotal = 1000,
                      Iva = 190,
                      Descuento = 0,
                      Total = 1190,
                      Detalles=new List<CFacturaDetalle>
                      {
                          new CFacturaDetalle
                          {
                              IdDetalle=1,
                              NumFactura=1,                                
                              Producto="Jabón",
                              ValorUnitario=70,
                              Cantidad=10
                          },
                          new CFacturaDetalle
                          {
                              IdDetalle=2,
                              NumFactura=1,
                              Producto="Detergente",
                              ValorUnitario=30,
                              Cantidad=10
                          }
                      }
                     
                  },
                   new CFactura
                  {
                      NumFactura = 2,
                      Cliente = "Luis",
                      Empleado = "Linda",
                      Fecha = DateTime.Now,
                      Subtotal = 200,
                      Iva = 20,
                      Descuento = 5,
                      Total = 215,
                       Detalles=new List<CFacturaDetalle>
                      {
                          new CFacturaDetalle
                          {
                                NumFactura=2,
                                IdDetalle=2,
                                 Producto="Fruta",
                                 ValorUnitario=20,
                                 Cantidad=10
                          }
                      }
                  }
             };
        }
    }
}
