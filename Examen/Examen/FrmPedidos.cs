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
        PedidosAcceso pedidosAcceso = new PedidosAcceso();
       

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

                SubTotalTextBox1.Text = subtotal.ToString();
                ISVtextBox.Text = impuesto.ToString();  
                TotalTextBox.Text = totalAPagar.ToString(); 



                detallePedidosLista.Add(detallePedido);
                DetalledataGridView1.DataSource = null;
                DetalledataGridView1.DataSource = detallePedidosLista;

            }
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            pedido.IdCliente = IdmaskedTextBox1.Text;
            pedido.Fecha = FechadateTimePicker1.Value;
            pedido.Subtotal = Convert.ToDecimal(SubTotalTextBox1.Text);
            pedido.Impuesto = Convert.ToDecimal(ISVtextBox.Text); ;
            pedido.Total = Convert.ToDecimal(TotalTextBox.Text); ;


            int idPedido = 0;

            idPedido = pedidosAcceso.InsertarPedido(pedido);

            if (idPedido != 0) 
            { 
                foreach (var item in detallePedidosLista)
                {
                    item.IdPedido = idPedido;
                    pedidosAcceso.DetallePedido(item);
                }
            
            }


        }


    }
}
