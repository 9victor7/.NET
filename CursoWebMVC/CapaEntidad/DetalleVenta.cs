using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleVenta
    {
//        CREATE TABLE DETALLE_VENTA(
//IdDetalleVenta int primary key identity,
//IdVenta int references VENTA(IdVenta),
//IdProducto int references PRODUCTO(IdProducto),
//Cantidad int,
//Total decimal(10,2),

        public int IdDetalleVenta { get; set; }
        public int IdVenta { get; set;}
        public Producto oProducto { get; set;}
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public string IdTransaccion { get; set; }

        public List<DetalleVenta> oDetalleVenta { get; set; }
    }
}
