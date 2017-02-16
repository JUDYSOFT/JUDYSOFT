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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botonListaClientesGenerarFactura = new System.Windows.Forms.Button();
            this.txtBoxClienteGenerarFactura = new System.Windows.Forms.TextBox();
            this.lblClienteGenerarFactura = new System.Windows.Forms.Label();
            this.lblAtendidoPorGenerarFactura = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefonoGenerarFactura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccionGenerarFactura = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidClienteGenerarFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonNuevaFacturaGenerarFactura = new System.Windows.Forms.Button();
            this.botonListaProductosGenerarFactura = new System.Windows.Forms.Button();
            this.BotonAniadir = new System.Windows.Forms.Button();
            this.BotonEliminarGenerarfactura = new System.Windows.Forms.Button();
            this.BotonFacturarGenerarFactura = new System.Windows.Forms.Button();
            this.BotonSalirGenerarFactura = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxTAX = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalGenerarFactura = new System.Windows.Forms.TextBox();
            this.txtImpuestoGenerarFactura = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSubtotalGenerarFactura = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DGVGenerarFactura = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCodigoGenerarFactura = new Libreria.ErrorTxtBox();
            this.txtDescripcionGenerarFactura = new Libreria.ErrorTxtBox();
            this.txtValUniGenerarFactura = new Libreria.ErrorTxtBox();
            this.txtCantidadGenerarFactura = new Libreria.ErrorTxtBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGenerarFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.botonListaClientesGenerarFactura);
            this.panel2.Controls.Add(this.txtBoxClienteGenerarFactura);
            this.panel2.Controls.Add(this.lblClienteGenerarFactura);
            this.panel2.Controls.Add(this.lblAtendidoPorGenerarFactura);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtTelefonoGenerarFactura);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDireccionGenerarFactura);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtidClienteGenerarFactura);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(9, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 129);
            this.panel2.TabIndex = 48;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // botonListaClientesGenerarFactura
            // 
            this.botonListaClientesGenerarFactura.Location = new System.Drawing.Point(210, 70);
            this.botonListaClientesGenerarFactura.Name = "botonListaClientesGenerarFactura";
            this.botonListaClientesGenerarFactura.Size = new System.Drawing.Size(98, 22);
            this.botonListaClientesGenerarFactura.TabIndex = 32;
            this.botonListaClientesGenerarFactura.Text = "Lista de Clientes";
            this.botonListaClientesGenerarFactura.UseVisualStyleBackColor = true;
            this.botonListaClientesGenerarFactura.Click += new System.EventHandler(this.botonListaClientesGenerarFactura_Click);
            // 
            // txtBoxClienteGenerarFactura
            // 
            this.txtBoxClienteGenerarFactura.BackColor = System.Drawing.Color.Moccasin;
            this.txtBoxClienteGenerarFactura.Location = new System.Drawing.Point(91, 101);
            this.txtBoxClienteGenerarFactura.Name = "txtBoxClienteGenerarFactura";
            this.txtBoxClienteGenerarFactura.ReadOnly = true;
            this.txtBoxClienteGenerarFactura.Size = new System.Drawing.Size(217, 20);
            this.txtBoxClienteGenerarFactura.TabIndex = 31;
            // 
            // lblClienteGenerarFactura
            // 
            this.lblClienteGenerarFactura.AutoSize = true;
            this.lblClienteGenerarFactura.Location = new System.Drawing.Point(6, 97);
            this.lblClienteGenerarFactura.Name = "lblClienteGenerarFactura";
            this.lblClienteGenerarFactura.Size = new System.Drawing.Size(79, 13);
            this.lblClienteGenerarFactura.TabIndex = 30;
            this.lblClienteGenerarFactura.Text = "Nombre Cliente";
            // 
            // lblAtendidoPorGenerarFactura
            // 
            this.lblAtendidoPorGenerarFactura.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAtendidoPorGenerarFactura.Location = new System.Drawing.Point(88, 42);
            this.lblAtendidoPorGenerarFactura.Name = "lblAtendidoPorGenerarFactura";
            this.lblAtendidoPorGenerarFactura.Size = new System.Drawing.Size(200, 16);
            this.lblAtendidoPorGenerarFactura.TabIndex = 28;
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
            // txtTelefonoGenerarFactura
            // 
            this.txtTelefonoGenerarFactura.BackColor = System.Drawing.Color.Moccasin;
            this.txtTelefonoGenerarFactura.Location = new System.Drawing.Point(437, 94);
            this.txtTelefonoGenerarFactura.Name = "txtTelefonoGenerarFactura";
            this.txtTelefonoGenerarFactura.ReadOnly = true;
            this.txtTelefonoGenerarFactura.Size = new System.Drawing.Size(199, 20);
            this.txtTelefonoGenerarFactura.TabIndex = 25;
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
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Moccasin;
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
            // txtDireccionGenerarFactura
            // 
            this.txtDireccionGenerarFactura.BackColor = System.Drawing.Color.Moccasin;
            this.txtDireccionGenerarFactura.Location = new System.Drawing.Point(437, 67);
            this.txtDireccionGenerarFactura.Name = "txtDireccionGenerarFactura";
            this.txtDireccionGenerarFactura.ReadOnly = true;
            this.txtDireccionGenerarFactura.Size = new System.Drawing.Size(197, 20);
            this.txtDireccionGenerarFactura.TabIndex = 21;
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
            // txtidClienteGenerarFactura
            // 
            this.txtidClienteGenerarFactura.BackColor = System.Drawing.Color.Moccasin;
            this.txtidClienteGenerarFactura.Location = new System.Drawing.Point(91, 73);
            this.txtidClienteGenerarFactura.Name = "txtidClienteGenerarFactura";
            this.txtidClienteGenerarFactura.ReadOnly = true;
            this.txtidClienteGenerarFactura.Size = new System.Drawing.Size(113, 20);
            this.txtidClienteGenerarFactura.TabIndex = 19;
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Documento Identidad Cliente:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.botonNuevaFacturaGenerarFactura);
            this.panel1.Controls.Add(this.botonListaProductosGenerarFactura);
            this.panel1.Controls.Add(this.BotonAniadir);
            this.panel1.Controls.Add(this.BotonEliminarGenerarfactura);
            this.panel1.Controls.Add(this.BotonFacturarGenerarFactura);
            this.panel1.Controls.Add(this.BotonSalirGenerarFactura);
            this.panel1.Location = new System.Drawing.Point(513, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 279);
            this.panel1.TabIndex = 47;
            // 
            // botonNuevaFacturaGenerarFactura
            // 
            this.botonNuevaFacturaGenerarFactura.Location = new System.Drawing.Point(40, 13);
            this.botonNuevaFacturaGenerarFactura.Name = "botonNuevaFacturaGenerarFactura";
            this.botonNuevaFacturaGenerarFactura.Size = new System.Drawing.Size(99, 52);
            this.botonNuevaFacturaGenerarFactura.TabIndex = 46;
            this.botonNuevaFacturaGenerarFactura.Text = "Nueva Factura";
            this.botonNuevaFacturaGenerarFactura.UseVisualStyleBackColor = true;
            this.botonNuevaFacturaGenerarFactura.Click += new System.EventHandler(this.botonNuevaFacturaGenerarFactura_Click);
            // 
            // botonListaProductosGenerarFactura
            // 
            this.botonListaProductosGenerarFactura.Location = new System.Drawing.Point(22, 153);
            this.botonListaProductosGenerarFactura.Name = "botonListaProductosGenerarFactura";
            this.botonListaProductosGenerarFactura.Size = new System.Drawing.Size(142, 39);
            this.botonListaProductosGenerarFactura.TabIndex = 45;
            this.botonListaProductosGenerarFactura.Text = "Lista de Servicios/Productos";
            this.botonListaProductosGenerarFactura.UseVisualStyleBackColor = true;
            this.botonListaProductosGenerarFactura.Click += new System.EventHandler(this.botonListaProductosGenerarFactura_Click);
            // 
            // BotonAniadir
            // 
            this.BotonAniadir.Location = new System.Drawing.Point(22, 85);
            this.BotonAniadir.Name = "BotonAniadir";
            this.BotonAniadir.Size = new System.Drawing.Size(143, 29);
            this.BotonAniadir.TabIndex = 3;
            this.BotonAniadir.Text = "Agregar Servicio/Producto";
            this.BotonAniadir.UseVisualStyleBackColor = true;
            this.BotonAniadir.Click += new System.EventHandler(this.BotonAniadirGenerarFactura_Click);
            // 
            // BotonEliminarGenerarfactura
            // 
            this.BotonEliminarGenerarfactura.Location = new System.Drawing.Point(22, 120);
            this.BotonEliminarGenerarfactura.Name = "BotonEliminarGenerarfactura";
            this.BotonEliminarGenerarfactura.Size = new System.Drawing.Size(143, 27);
            this.BotonEliminarGenerarfactura.TabIndex = 4;
            this.BotonEliminarGenerarfactura.Text = "Eliminar Servicio/Producto";
            this.BotonEliminarGenerarfactura.UseVisualStyleBackColor = true;
            this.BotonEliminarGenerarfactura.Click += new System.EventHandler(this.BotonEliminarGenerarfactura_Click);
            // 
            // BotonFacturarGenerarFactura
            // 
            this.BotonFacturarGenerarFactura.Location = new System.Drawing.Point(22, 198);
            this.BotonFacturarGenerarFactura.Name = "BotonFacturarGenerarFactura";
            this.BotonFacturarGenerarFactura.Size = new System.Drawing.Size(143, 23);
            this.BotonFacturarGenerarFactura.TabIndex = 2;
            this.BotonFacturarGenerarFactura.Text = "Facturar";
            this.BotonFacturarGenerarFactura.UseVisualStyleBackColor = true;
            this.BotonFacturarGenerarFactura.Click += new System.EventHandler(this.BotonFacturarGenerarFactura_Click);
            // 
            // BotonSalirGenerarFactura
            // 
            this.BotonSalirGenerarFactura.Location = new System.Drawing.Point(22, 227);
            this.BotonSalirGenerarFactura.Name = "BotonSalirGenerarFactura";
            this.BotonSalirGenerarFactura.Size = new System.Drawing.Size(140, 25);
            this.BotonSalirGenerarFactura.TabIndex = 44;
            this.BotonSalirGenerarFactura.Text = "Salir";
            this.BotonSalirGenerarFactura.UseVisualStyleBackColor = true;
            this.BotonSalirGenerarFactura.Click += new System.EventHandler(this.BotonSalirGenerarFactura_Click_1);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.comboBoxTAX);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtTotalGenerarFactura);
            this.panel3.Controls.Add(this.txtImpuestoGenerarFactura);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtSubtotalGenerarFactura);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.DGVGenerarFactura);
            this.panel3.Location = new System.Drawing.Point(9, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 312);
            this.panel3.TabIndex = 49;
            // 
            // comboBoxTAX
            // 
            this.comboBoxTAX.BackColor = System.Drawing.Color.Moccasin;
            this.comboBoxTAX.FormattingEnabled = true;
            this.comboBoxTAX.Items.AddRange(new object[] {
            "12%",
            "14%"});
            this.comboBoxTAX.Location = new System.Drawing.Point(274, 230);
            this.comboBoxTAX.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTAX.Name = "comboBoxTAX";
            this.comboBoxTAX.Size = new System.Drawing.Size(92, 21);
            this.comboBoxTAX.TabIndex = 8;
            this.comboBoxTAX.SelectedIndexChanged += new System.EventHandler(this.comboBoxTAX_SelectedIndexChanged);
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
            // txtTotalGenerarFactura
            // 
            this.txtTotalGenerarFactura.BackColor = System.Drawing.Color.Moccasin;
            this.txtTotalGenerarFactura.Location = new System.Drawing.Point(372, 272);
            this.txtTotalGenerarFactura.Name = "txtTotalGenerarFactura";
            this.txtTotalGenerarFactura.ReadOnly = true;
            this.txtTotalGenerarFactura.Size = new System.Drawing.Size(100, 20);
            this.txtTotalGenerarFactura.TabIndex = 6;
            // 
            // txtImpuestoGenerarFactura
            // 
            this.txtImpuestoGenerarFactura.BackColor = System.Drawing.Color.Moccasin;
            this.txtImpuestoGenerarFactura.Location = new System.Drawing.Point(372, 231);
            this.txtImpuestoGenerarFactura.Name = "txtImpuestoGenerarFactura";
            this.txtImpuestoGenerarFactura.ReadOnly = true;
            this.txtImpuestoGenerarFactura.Size = new System.Drawing.Size(100, 20);
            this.txtImpuestoGenerarFactura.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(214, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Impuestos";
            // 
            // txtSubtotalGenerarFactura
            // 
            this.txtSubtotalGenerarFactura.BackColor = System.Drawing.Color.Moccasin;
            this.txtSubtotalGenerarFactura.Location = new System.Drawing.Point(372, 192);
            this.txtSubtotalGenerarFactura.Name = "txtSubtotalGenerarFactura";
            this.txtSubtotalGenerarFactura.ReadOnly = true;
            this.txtSubtotalGenerarFactura.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotalGenerarFactura.TabIndex = 2;
            this.txtSubtotalGenerarFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Subtotal";
            // 
            // DGVGenerarFactura
            // 
            this.DGVGenerarFactura.AllowUserToAddRows = false;
            this.DGVGenerarFactura.AllowUserToDeleteRows = false;
            this.DGVGenerarFactura.AllowUserToResizeColumns = false;
            this.DGVGenerarFactura.AllowUserToResizeRows = false;
            this.DGVGenerarFactura.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGVGenerarFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGenerarFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cantidad,
            this.Descripción,
            this.ValorUnitario,
            this.ValorTotal});
            this.DGVGenerarFactura.Location = new System.Drawing.Point(9, 12);
            this.DGVGenerarFactura.Name = "DGVGenerarFactura";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVGenerarFactura.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVGenerarFactura.Size = new System.Drawing.Size(465, 174);
            this.DGVGenerarFactura.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 53;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 63;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.Width = 132;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtCodigoGenerarFactura
            // 
            this.txtCodigoGenerarFactura.BackColor = System.Drawing.Color.Moccasin;
            this.txtCodigoGenerarFactura.Location = new System.Drawing.Point(63, 138);
            this.txtCodigoGenerarFactura.Name = "txtCodigoGenerarFactura";
            this.txtCodigoGenerarFactura.ReadOnly = true;
            this.txtCodigoGenerarFactura.Size = new System.Drawing.Size(43, 20);
            this.txtCodigoGenerarFactura.TabIndex = 53;
            this.txtCodigoGenerarFactura.Validar = true;
            // 
            // txtDescripcionGenerarFactura
            // 
            this.txtDescripcionGenerarFactura.BackColor = System.Drawing.Color.Moccasin;
            this.txtDescripcionGenerarFactura.Location = new System.Drawing.Point(177, 138);
            this.txtDescripcionGenerarFactura.Name = "txtDescripcionGenerarFactura";
            this.txtDescripcionGenerarFactura.ReadOnly = true;
            this.txtDescripcionGenerarFactura.Size = new System.Drawing.Size(116, 20);
            this.txtDescripcionGenerarFactura.TabIndex = 52;
            this.txtDescripcionGenerarFactura.Validar = true;
            // 
            // txtValUniGenerarFactura
            // 
            this.txtValUniGenerarFactura.BackColor = System.Drawing.Color.Moccasin;
            this.txtValUniGenerarFactura.Location = new System.Drawing.Point(299, 138);
            this.txtValUniGenerarFactura.Name = "txtValUniGenerarFactura";
            this.txtValUniGenerarFactura.ReadOnly = true;
            this.txtValUniGenerarFactura.Size = new System.Drawing.Size(79, 20);
            this.txtValUniGenerarFactura.TabIndex = 51;
            this.txtValUniGenerarFactura.Validar = true;
            // 
            // txtCantidadGenerarFactura
            // 
            this.txtCantidadGenerarFactura.BackColor = System.Drawing.Color.Moccasin;
            this.txtCantidadGenerarFactura.Location = new System.Drawing.Point(112, 138);
            this.txtCantidadGenerarFactura.Name = "txtCantidadGenerarFactura";
            this.txtCantidadGenerarFactura.Size = new System.Drawing.Size(59, 20);
            this.txtCantidadGenerarFactura.TabIndex = 45;
            this.txtCantidadGenerarFactura.Validar = true;
            // 
            // FormGenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(709, 501);
            this.Controls.Add(this.txtCodigoGenerarFactura);
            this.Controls.Add(this.txtDescripcionGenerarFactura);
            this.Controls.Add(this.txtValUniGenerarFactura);
            this.Controls.Add(this.txtCantidadGenerarFactura);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormGenerarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGenerarFactura";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGenerarFactura_FormClosing);
            this.Load += new System.EventHandler(this.FormGenerarFactura_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGenerarFactura)).EndInit();
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
        private System.Windows.Forms.Button BotonEliminarGenerarfactura;
        private System.Windows.Forms.Button BotonFacturarGenerarFactura;
        private System.Windows.Forms.Button BotonSalirGenerarFactura;
        private System.Windows.Forms.TextBox txtidClienteGenerarFactura;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTelefonoGenerarFactura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtDireccionGenerarFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVGenerarFactura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotalGenerarFactura;
        private System.Windows.Forms.TextBox txtImpuestoGenerarFactura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSubtotalGenerarFactura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAtendidoPorGenerarFactura;
        private System.Windows.Forms.TextBox txtBoxClienteGenerarFactura;
        private System.Windows.Forms.Label lblClienteGenerarFactura;
        private Libreria.ErrorTxtBox txtCantidadGenerarFactura;
        private Libreria.ErrorTxtBox txtValUniGenerarFactura;
        private Libreria.ErrorTxtBox txtDescripcionGenerarFactura;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Libreria.ErrorTxtBox txtCodigoGenerarFactura;
        private System.Windows.Forms.Button botonListaClientesGenerarFactura;
        private System.Windows.Forms.Button botonListaProductosGenerarFactura;
        private System.Windows.Forms.Button botonNuevaFacturaGenerarFactura;
        private System.Windows.Forms.ComboBox comboBoxTAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
    }
}