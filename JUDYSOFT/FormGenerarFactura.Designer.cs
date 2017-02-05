namespace JUDYSOFT
{
    partial class FormGenerarFactura
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.lblAtendidoPor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BotonAniadir = new System.Windows.Forms.Button();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.BotonFacturar = new System.Windows.Forms.Button();
            this.BotonSalir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidad = new Libreria.ErrorTxtBox();
            this.txtValUni = new Libreria.ErrorTxtBox();
            this.txtDescripcion = new Libreria.ErrorTxtBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCodigo = new Libreria.ErrorTxtBox();
            this.botonListaClientes = new System.Windows.Forms.Button();
            this.botonListaProductos = new System.Windows.Forms.Button();
            this.botonNuevaFactura = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.botonListaClientes);
            this.panel2.Controls.Add(this.txtBoxCliente);
            this.panel2.Controls.Add(this.lblCliente);
            this.panel2.Controls.Add(this.BotonBuscar);
            this.panel2.Controls.Add(this.lblAtendidoPor);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtTelefono);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDireccion);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtidCliente);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(9, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 134);
            this.panel2.TabIndex = 48;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtBoxCliente
            // 
            this.txtBoxCliente.Location = new System.Drawing.Point(85, 101);
            this.txtBoxCliente.Name = "txtBoxCliente";
            this.txtBoxCliente.Size = new System.Drawing.Size(197, 20);
            this.txtBoxCliente.TabIndex = 31;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(6, 97);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(79, 13);
            this.lblCliente.TabIndex = 30;
            this.lblCliente.Text = "Nombre Cliente";
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Location = new System.Drawing.Point(152, 70);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(75, 23);
            this.BotonBuscar.TabIndex = 29;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // lblAtendidoPor
            // 
            this.lblAtendidoPor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAtendidoPor.Location = new System.Drawing.Point(82, 39);
            this.lblAtendidoPor.Name = "lblAtendidoPor";
            this.lblAtendidoPor.Size = new System.Drawing.Size(200, 16);
            this.lblAtendidoPor.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "JUDY\'s PALACE HOSTAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "FACTURA #";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(437, 94);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(199, 20);
            this.txtTelefono.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Teléfono";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(437, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fecha";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(437, 67);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(197, 20);
            this.txtDireccion.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Dirección";
            // 
            // txtidCliente
            // 
            this.txtidCliente.Location = new System.Drawing.Point(85, 72);
            this.txtidCliente.Name = "txtidCliente";
            this.txtidCliente.Size = new System.Drawing.Size(61, 20);
            this.txtidCliente.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Atendido por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "idCliente:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.botonNuevaFactura);
            this.panel1.Controls.Add(this.botonListaProductos);
            this.panel1.Controls.Add(this.BotonAniadir);
            this.panel1.Controls.Add(this.BotonEliminar);
            this.panel1.Controls.Add(this.BotonFacturar);
            this.panel1.Controls.Add(this.BotonSalir);
            this.panel1.Location = new System.Drawing.Point(481, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 279);
            this.panel1.TabIndex = 47;
            // 
            // BotonAniadir
            // 
            this.BotonAniadir.Location = new System.Drawing.Point(22, 85);
            this.BotonAniadir.Name = "BotonAniadir";
            this.BotonAniadir.Size = new System.Drawing.Size(143, 29);
            this.BotonAniadir.TabIndex = 3;
            this.BotonAniadir.Text = "Agregar Servicio/Producto";
            this.BotonAniadir.UseVisualStyleBackColor = true;
            this.BotonAniadir.Click += new System.EventHandler(this.BotonAniadir_Click);
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Location = new System.Drawing.Point(22, 120);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(143, 27);
            this.BotonEliminar.TabIndex = 4;
            this.BotonEliminar.Text = "Eliminar Servicio/Producto";
            this.BotonEliminar.UseVisualStyleBackColor = true;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // BotonFacturar
            // 
            this.BotonFacturar.Location = new System.Drawing.Point(22, 198);
            this.BotonFacturar.Name = "BotonFacturar";
            this.BotonFacturar.Size = new System.Drawing.Size(143, 23);
            this.BotonFacturar.TabIndex = 2;
            this.BotonFacturar.Text = "Facturar";
            this.BotonFacturar.UseVisualStyleBackColor = true;
            // 
            // BotonSalir
            // 
            this.BotonSalir.Location = new System.Drawing.Point(22, 227);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(140, 25);
            this.BotonSalir.TabIndex = 44;
            this.BotonSalir.Text = "Salir";
            this.BotonSalir.UseVisualStyleBackColor = true;
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtSubtotal);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(9, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(466, 312);
            this.panel3.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(271, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Total";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(352, 272);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(352, 231);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(237, 230);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(88, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(163, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Impuestos";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(352, 192);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 2;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Subtotal";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cantidad,
            this.Descripción,
            this.ValorUnitario,
            this.ValorTotal});
            this.dataGridView1.Location = new System.Drawing.Point(9, 12);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(443, 174);
            this.dataGridView1.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 50;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 60;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.Width = 120;
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.HeaderText = "Valor Unitario";
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.Width = 93;
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "Valor Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.Width = 81;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(112, 138);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(59, 20);
            this.txtCantidad.TabIndex = 45;
            this.txtCantidad.Validar = true;
            // 
            // txtValUni
            // 
            this.txtValUni.Location = new System.Drawing.Point(299, 138);
            this.txtValUni.Name = "txtValUni";
            this.txtValUni.Size = new System.Drawing.Size(79, 20);
            this.txtValUni.TabIndex = 51;
            this.txtValUni.Validar = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(177, 138);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(116, 20);
            this.txtDescripcion.TabIndex = 52;
            this.txtDescripcion.Validar = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(63, 138);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(43, 20);
            this.txtCodigo.TabIndex = 53;
            this.txtCodigo.Validar = false;
            // 
            // botonListaClientes
            // 
            this.botonListaClientes.Location = new System.Drawing.Point(242, 70);
            this.botonListaClientes.Name = "botonListaClientes";
            this.botonListaClientes.Size = new System.Drawing.Size(98, 22);
            this.botonListaClientes.TabIndex = 32;
            this.botonListaClientes.Text = "Lista de Clientes";
            this.botonListaClientes.UseVisualStyleBackColor = true;
            // 
            // botonListaProductos
            // 
            this.botonListaProductos.Location = new System.Drawing.Point(22, 153);
            this.botonListaProductos.Name = "botonListaProductos";
            this.botonListaProductos.Size = new System.Drawing.Size(142, 39);
            this.botonListaProductos.TabIndex = 45;
            this.botonListaProductos.Text = "Lista de Servicios/Productos";
            this.botonListaProductos.UseVisualStyleBackColor = true;
            this.botonListaProductos.Click += new System.EventHandler(this.botonListaProductos_Click);
            // 
            // botonNuevaFactura
            // 
            this.botonNuevaFactura.Location = new System.Drawing.Point(40, 13);
            this.botonNuevaFactura.Name = "botonNuevaFactura";
            this.botonNuevaFactura.Size = new System.Drawing.Size(99, 52);
            this.botonNuevaFactura.TabIndex = 46;
            this.botonNuevaFactura.Text = "Nueva Factura";
            this.botonNuevaFactura.UseVisualStyleBackColor = true;
            this.botonNuevaFactura.Click += new System.EventHandler(this.botonNuevaFactura_Click);
            // 
            // FormGenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 501);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtValUni);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormGenerarFactura";
            this.Text = "FormGenerarFactura";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGenerarFactura_FormClosing);
            this.Load += new System.EventHandler(this.FormGenerarFactura_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BotonAniadir;
        private System.Windows.Forms.Button BotonEliminar;
        private System.Windows.Forms.Button BotonFacturar;
        private System.Windows.Forms.Button BotonSalir;
        private System.Windows.Forms.TextBox txtidCliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAtendidoPor;
        private System.Windows.Forms.TextBox txtBoxCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button BotonBuscar;
        private Libreria.ErrorTxtBox txtCantidad;
        private Libreria.ErrorTxtBox txtValUni;
        private Libreria.ErrorTxtBox txtDescripcion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Libreria.ErrorTxtBox txtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.Button botonListaClientes;
        private System.Windows.Forms.Button botonListaProductos;
        private System.Windows.Forms.Button botonNuevaFactura;
    }
}