using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conectar;
using Conectar.Acceso;
using Conectar.ClasesBD;

namespace Examen
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void AceptarButton1_Click(object sender, EventArgs e)
        {
            UsuariosAcceso usuariosAcceso = new UsuariosAcceso();
            Usuarios usuarios = new Usuarios();

            usuarios = usuariosAcceso.Login(UsuarioTextBox1.Text, ClaveTextBox1.Text);

           

            if (usuarios == null) 
            {
                MessageBox.Show("Datos Erroneos");
            }
            
         
            FormMenu formMenu = new FormMenu(); 
            formMenu.Show();
            this.Hide();    
        }
    }
}
