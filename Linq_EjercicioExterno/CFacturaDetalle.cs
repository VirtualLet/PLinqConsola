using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_EjercicioExterno
{
    public class CFacturaDetalle
    {
        public CFacturaDetalle()
        {
                
        }
        public CFacturaDetalle(int idDetalle, int numFactura, string producto, int cantidad, double valorUnitario)
        {
            IdDetalle = idDetalle;
            NumFactura = numFactura;
            Producto = producto;
            Cantidad = cantidad;
            ValorUnitario = valorUnitario;
        }

        public int IdDetalle { get; set; }
        public int NumFactura { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public double ValorUnitario { get; set; }

        public override string ToString()
        {
            return string.Format("\n\tIdDetalle:{0}\n\tNumFactura:{1}\n\tProducto:{2}\n\tCantidad:{3}\n\tValorUnitario:{4}",
                IdDetalle, NumFactura, Producto, Cantidad, ValorUnitario);
        }
    }
}
