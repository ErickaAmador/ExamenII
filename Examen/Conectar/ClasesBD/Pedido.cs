using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conectar.ClasesBD
{
    public class Pedido
    {
        public int Id { get; set; }
        public string IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }

        public Pedido()
        {
        }

        public Pedido(int id, string idCliente, DateTime fecha, decimal subtotal, decimal impuesto, decimal total)
        {
            Id = id;
            IdCliente = idCliente;
            Fecha = fecha;
            Subtotal = subtotal;
            Impuesto = impuesto;
            Total = total;
        }
    }
}
