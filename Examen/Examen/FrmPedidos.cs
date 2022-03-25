using Conectar.Acceso;
using Conectar.ClasesBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        ProductosAcceso productosAcceso = new ProductosAcceso();
        Pedido pedido = new Pedido();
        Productos productos;

        List<DetallePedido> detallePedidosLista = new List<DetallePedido>();

        decimal subtotal = decimal.Zero;
        decimal impuesto = decimal.Zero;
        decimal totalAPagar = decimal.Zero;

        private void Pedidos_Load(object sender, EventArgs e)
        {
            DetalledataGridView1.DataSource = detallePedidosLista;
        }

        private void CodigoTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                productos = new Productos();

                productos = productosAcceso.GetProductosCodigo(CodigoTextBox2.Text);

                DescripcionTextBox1.Text = productos.Nombre;
                CantidadTextBox1.Focus();
            }
            else
            {
                productos = null;
                DescripcionTextBox1.Clear();
                CantidadTextBox1.Clear();
            }


        }

        private void CantidadTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CantidadTextBox1.Text))
            {
                DetallePedido detallePedido = new DetallePedido();
                detallePedido.CodigoProducto = productos.Codigo;
                detallePedido.Nombre = productos.Nombre;
                detallePedido.Precio = productos.Precio;
                detallePedido.Cantidad = Convert.ToInt32(CantidadTextBox1.Text);
                detallePedido.Total = productos.Precio * Convert.ToInt32(CantidadTextBox1.Text);


                subtotal += detallePedido.Total;
                impuesto = subtotal * 0.15M;
                totalAPagar = subtotal + impuesto;

                detallePedidosLista.Add(detallePedido);
                DetalledataGridView1.DataSource = null;
                DetalledataGridView1.DataSource = detallePedidosLista;

            }
        }
    }
}
