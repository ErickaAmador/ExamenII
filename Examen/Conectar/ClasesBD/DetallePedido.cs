using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conectar.ClasesBD
{
    public class DetallePedido
    {
        public int  Id { get; set; }
        public int IdPedido { get; set; }
        public string CodigoProducto { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set ; }
        public decimal Total { get; set; }

        public DetallePedido()
        {
        }

        public DetallePedido(int id, int idPedido, string codigoProducto, string nombre, int cantidad, decimal precio, decimal total)
        {
            Id = id;
            IdPedido = idPedido;
            CodigoProducto = codigoProducto;
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
            Total = total;
        }
    }
}
