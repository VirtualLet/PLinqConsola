using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_EjercicioExterno
{
   public class CFactura
    {
        public CFactura()
        {
                
        }

        public CFactura(int numFactura, string cliente, string empleado, DateTime fecha, double subtotal, double descuento, double iva, double total, List<CFacturaDetalle> detalles)
        {
            NumFactura = numFactura;
            Cliente = cliente;
            Fecha = fecha;
            Empleado = empleado;
            Subtotal = subtotal;
            Descuento = descuento;
            Iva = iva;
            Total = total;
            Detalles = detalles;
        }

        public int NumFactura { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Empleado { get; set; }
        public double Subtotal { get; set; }
        public double Descuento { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }

        public List<CFacturaDetalle> Detalles { get; set; }

        public override string ToString()
        {
            string Factura= string.Format("NumFactura={0}\nCliente={1}\nFecha={2}\nEmpreado={3}\nSubtotal={4}\nDescuento={5}\nIva={6}\nTotal={7}",
                                                 NumFactura, Cliente, Fecha,Empleado,Subtotal,Descuento,Iva,Total);
          
            return Factura;

        }
    }
}
