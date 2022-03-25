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
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
        }

        string operacion = string.Empty;
        ProductosAcceso productosAcceso = new ProductosAcceso();

        private void NuevoButton1_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            Habibilitar();
        }

        private void Habibilitar()
        {
            CodigoTextBox.Enabled = true;
            NombreTextBox.Enabled = true;
            PrecioTextBox.Enabled = true;
            ExistenciaTextBox.Enabled = true;   

            GuardarButton.Enabled = true;
            NuevoButton1.Enabled = false;
            ModificarButton.Enabled = false;
        }


        private void Deshabibilitar()
        {
            CodigoTextBox.Enabled = false;
            NombreTextBox.Enabled = false;
            PrecioTextBox.Enabled = false;
            ExistenciaTextBox.Enabled = false;

            GuardarButton.Enabled = false;
            NuevoButton1.Enabled = true;
            ModificarButton.Enabled = true;
        }


        private void Limpiar()
        {
            CodigoTextBox.Clear();
            NombreTextBox.Clear();
            PrecioTextBox.Clear();
            ExistenciaTextBox.Clear();

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrEmpty(CodigoTextBox.Text))
                {
                    errorProvider1.SetError(CodigoTextBox, "Ingrese el código");
                    CodigoTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(NombreTextBox.Text))
                {
                    errorProvider1.SetError(CodigoTextBox, "Ingrese el nombre");
                    NombreTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(PrecioTextBox.Text))
                {
                    errorProvider1.SetError(PrecioTextBox, "Ingrese el precio");
                    PrecioTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(ExistenciaTextBox.Text))
                {
                    errorProvider1.SetError(ExistenciaTextBox, "Ingrese la existencia");
                    ExistenciaTextBox.Focus();
                    return;
                }



                Productos productos = new Productos();
                productos.Codigo = CodigoTextBox.Text;
                productos.Nombre = NombreTextBox.Text;
                productos.Precio = Convert.ToDecimal(PrecioTextBox.Text);
                productos.Existencia = Convert.ToInt32(ExistenciaTextBox.Text);

                if (operacion == "Nuevo")
                {
                    bool InsertoP = productosAcceso.InsertarProducto(productos);


                    if (InsertoP)
                    {
                        Deshabibilitar();
                        Limpiar();
                        ListarProductos();
                        MessageBox.Show("Producto insertado correctamente");
                    }
                }
                else if (operacion == "Modificar")
                {
                    bool ModificoP = productosAcceso.ModificarProducto(productos);
                    if (ModificoP)
                    {
                        
                        Limpiar();
                        Deshabibilitar();
                        ListarProductos();
                        MessageBox.Show("Producto modificado correctamente");
                    }
                }



            }
            catch (Exception)
            {

            }

            

          

        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            ListarProductos();
           // ProductosDataGridView1.DataSource = productosAcceso.ListarProductos();
        }

        private void ListarProductos()
        {
            ProductosDataGridView1.DataSource = productosAcceso.ListarProductos();
        }

        private void PrecioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Evitar el ingreso de letrs
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1 ))
            {
                e.Handled = true;
            }
        }

        private void ExistenciaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Evitar el ingreso de letrs
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";

            if (ProductosDataGridView1.SelectedRows.Count > 0)
            {
                CodigoTextBox.Text = ProductosDataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                NombreTextBox.Text = ProductosDataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                PrecioTextBox.Text = ProductosDataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                ExistenciaTextBox.Text = ProductosDataGridView1.CurrentRow.Cells["Existencia"].Value.ToString();

                Habibilitar();
                CodigoTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Debe de seleccionar un producto");
            }

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (ProductosDataGridView1.SelectedRows.Count > 0)
            {
                bool EliminoP = productosAcceso.EliminarProducto(ProductosDataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());

                if (EliminoP)
                {
                    ListarProductos();
                    MessageBox.Show("Producto Eliminado", "ATencion",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error en la eliminación", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Selecionar Producto", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
