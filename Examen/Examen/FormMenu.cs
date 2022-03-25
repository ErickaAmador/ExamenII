using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen
{
    public partial class FormMenu : Syncfusion.Windows.Forms.Office2010Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        FormProducto frmProductos = null; //ACA
        FrmPedidos formPedidos = null;

        private void ProductostoolStripButton1_Click(object sender, EventArgs e)
        {

            if(frmProductos == null)
            {
                frmProductos = new FormProducto();
                frmProductos.MdiParent = this;
                frmProductos.FormClosed += FrmProductos_FormClosed; //Se pueda volver a abrir 
                frmProductos.Show();
            }
            else
            {
                frmProductos.Activate();
            }

            

        }

        private void FrmProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmProductos = null;
        }



        private void PedidostoolStripButton2_Click(object sender, EventArgs e)
        {
            if (formPedidos == null)
            {
                formPedidos = new FrmPedidos();
                formPedidos.MdiParent = this;
                formPedidos.FormClosed += FormPedidos_FormClosed;
                formPedidos.Show();
            }
            else
            {
                formPedidos.Activate();
            }
        }

        private void FormPedidos_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPedidos = null; 
        }
    }
}
