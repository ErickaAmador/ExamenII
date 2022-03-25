namespace Examen
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsuarioTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AceptarButton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ClaveTextBox1 = new System.Windows.Forms.TextBox();
            this.CancelarButton2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsuarioTextBox1
            // 
            this.UsuarioTextBox1.Font = new System.Drawing.Font("High Tower Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTextBox1.Location = new System.Drawing.Point(160, 99);
            this.UsuarioTextBox1.Name = "UsuarioTextBox1";
            this.UsuarioTextBox1.Size = new System.Drawing.Size(398, 31);
            this.UsuarioTextBox1.TabIndex = 0;
            this.UsuarioTextBox1.Text = "EAMADOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario: ";
            // 
            // AceptarButton1
            // 
            this.AceptarButton1.Font = new System.Drawing.Font("High Tower Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceptarButton1.Location = new System.Drawing.Point(160, 225);
            this.AceptarButton1.Name = "AceptarButton1";
            this.AceptarButton1.Size = new System.Drawing.Size(155, 56);
            this.AceptarButton1.TabIndex = 2;
            this.AceptarButton1.Text = "Aceptar ";
            this.AceptarButton1.UseVisualStyleBackColor = true;
            this.AceptarButton1.Click += new System.EventHandler(this.AceptarButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código: ";
            // 
            // ClaveTextBox1
            // 
            this.ClaveTextBox1.Font = new System.Drawing.Font("High Tower Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaveTextBox1.Location = new System.Drawing.Point(160, 153);
            this.ClaveTextBox1.Name = "ClaveTextBox1";
            this.ClaveTextBox1.PasswordChar = '*';
            this.ClaveTextBox1.Size = new System.Drawing.Size(398, 31);
            this.ClaveTextBox1.TabIndex = 3;
            this.ClaveTextBox1.Text = "2699";
            // 
            // CancelarButton2
            // 
            this.CancelarButton2.Font = new System.Drawing.Font("High Tower Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton2.Location = new System.Drawing.Point(403, 225);
            this.CancelarButton2.Name = "CancelarButton2";
            this.CancelarButton2.Size = new System.Drawing.Size(155, 56);
            this.CancelarButton2.TabIndex = 5;
            this.CancelarButton2.Text = "Cancelar";
            this.CancelarButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Acceso Usuarios";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(596, 339);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelarButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClaveTextBox1);
            this.Controls.Add(this.AceptarButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsuarioTextBox1);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsuarioTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AceptarButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClaveTextBox1;
        private System.Windows.Forms.Button CancelarButton2;
        private System.Windows.Forms.Label label3;
    }
}

