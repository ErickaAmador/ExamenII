namespace Examen
{
    partial class FrmPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NombreTextBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdmaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cantidad = new System.Windows.Forms.Label();
            this.CantidadTextBox1 = new System.Windows.Forms.TextBox();
            this.CodigoTextBox2 = new System.Windows.Forms.TextBox();
            this.DescripcionTextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DetalledataGridView1 = new System.Windows.Forms.DataGridView();
            this.FechadateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SubTotalTextBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ISVtextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NombreTextBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.IdmaskedTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1019, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENTE";
            // 
            // NombreTextBox1
            // 
            this.NombreTextBox1.Location = new System.Drawing.Point(540, 39);
            this.NombreTextBox1.Name = "NombreTextBox1";
            this.NombreTextBox1.Size = new System.Drawing.Size(435, 26);
            this.NombreTextBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre: ";
            // 
            // IdmaskedTextBox1
            // 
            this.IdmaskedTextBox1.Location = new System.Drawing.Point(147, 39);
            this.IdmaskedTextBox1.Mask = "####-####-#####";
            this.IdmaskedTextBox1.Name = "IdmaskedTextBox1";
            this.IdmaskedTextBox1.Size = new System.Drawing.Size(225, 26);
            this.IdmaskedTextBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Cantidad);
            this.groupBox2.Controls.Add(this.CantidadTextBox1);
            this.groupBox2.Controls.Add(this.CodigoTextBox2);
            this.groupBox2.Controls.Add(this.DescripcionTextBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1019, 93);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PRODUCTO";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Location = new System.Drawing.Point(336, 45);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(86, 20);
            this.Cantidad.TabIndex = 7;
            this.Cantidad.Text = "Cantidad:";
            // 
            // CantidadTextBox1
            // 
            this.CantidadTextBox1.Location = new System.Drawing.Point(439, 45);
            this.CantidadTextBox1.Name = "CantidadTextBox1";
            this.CantidadTextBox1.Size = new System.Drawing.Size(180, 26);
            this.CantidadTextBox1.TabIndex = 6;
            this.CantidadTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadTextBox1_KeyPress);
            // 
            // CodigoTextBox2
            // 
            this.CodigoTextBox2.Location = new System.Drawing.Point(147, 42);
            this.CodigoTextBox2.Name = "CodigoTextBox2";
            this.CodigoTextBox2.Size = new System.Drawing.Size(113, 26);
            this.CodigoTextBox2.TabIndex = 5;
            this.CodigoTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigoTextBox2_KeyPress);
            // 
            // DescripcionTextBox1
            // 
            this.DescripcionTextBox1.Location = new System.Drawing.Point(748, 39);
            this.DescripcionTextBox1.Name = "DescripcionTextBox1";
            this.DescripcionTextBox1.Size = new System.Drawing.Size(227, 26);
            this.DescripcionTextBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(648, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cod. Producto:";
            // 
            // DetalledataGridView1
            // 
            this.DetalledataGridView1.AllowUserToAddRows = false;
            this.DetalledataGridView1.AllowUserToDeleteRows = false;
            this.DetalledataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DetalledataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView1.Enabled = false;
            this.DetalledataGridView1.Location = new System.Drawing.Point(12, 421);
            this.DetalledataGridView1.Name = "DetalledataGridView1";
            this.DetalledataGridView1.ReadOnly = true;
            this.DetalledataGridView1.RowHeadersWidth = 62;
            this.DetalledataGridView1.RowTemplate.Height = 28;
            this.DetalledataGridView1.Size = new System.Drawing.Size(1019, 331);
            this.DetalledataGridView1.TabIndex = 6;
            // 
            // FechadateTimePicker1
            // 
            this.FechadateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker1.Location = new System.Drawing.Point(833, 215);
            this.FechadateTimePicker1.Name = "FechadateTimePicker1";
            this.FechadateTimePicker1.Size = new System.Drawing.Size(155, 26);
            this.FechadateTimePicker1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(757, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Subtotal:";
            // 
            // SubTotalTextBox1
            // 
            this.SubTotalTextBox1.Location = new System.Drawing.Point(99, 350);
            this.SubTotalTextBox1.Name = "SubTotalTextBox1";
            this.SubTotalTextBox1.Size = new System.Drawing.Size(101, 26);
            this.SubTotalTextBox1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "ISV: ";
            // 
            // ISVtextBox
            // 
            this.ISVtextBox.Location = new System.Drawing.Point(266, 351);
            this.ISVtextBox.Name = "ISVtextBox";
            this.ISVtextBox.Size = new System.Drawing.Size(101, 26);
            this.ISVtextBox.TabIndex = 13;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(522, 350);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(101, 26);
            this.TotalTextBox.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Total A Pagar:";
            // 
            // AgregarButton
            // 
            this.AgregarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AgregarButton.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarButton.Location = new System.Drawing.Point(452, 272);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(180, 40);
            this.AgregarButton.TabIndex = 16;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = false;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1046, 764);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.ISVtextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SubTotalTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FechadateTimePicker1);
            this.Controls.Add(this.DetalledataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmPedidos";
            this.Text = "FormPedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox IdmaskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox DescripcionTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CodigoTextBox2;
        private System.Windows.Forms.TextBox CantidadTextBox1;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.DataGridView DetalledataGridView1;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SubTotalTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ISVtextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AgregarButton;
    }
}