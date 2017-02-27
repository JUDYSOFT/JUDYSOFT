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
            this.lblCodCli = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
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
            this.panel2.Controls.Add(this.lblCodCli);
            this.panel2.Controls.Add(this.labID);
            this.panel2.Controls.Add(this.lblid);
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
            this.panel2.Location = new System.Drawing.Point(12, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 158);
            this.panel2.TabIndex = 48;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblCodCli
            // 
            this.lblCodCli.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCodCli.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCodCli.Location = new System.Drawing.Point(425, 56);
            this.lblCodCli.Name = "lblCodCli";
            this.lblCodCli.Size = new System.Drawing.Size(64, 23);
            this.lblCodCli.TabIndex = 35;
            this.lblCodCli.Visible = false;
            // 
            // labID
            // 
            this.labID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labID.Location = new System.Drawing.Point(422, 89);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(67, 23);
            this.labID.TabIndex = 34;
            this.labID.Visible = false;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblid.Location = new System.Drawing.Point(431, 86);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 17);
            this.lblid.TabIndex = 33;
            this.lblid.Visible = false;
            // 
            // botonListaClientesGenerarFactura
            // 
            this.botonListaClientesGenerarFactura.Location = new System.Drawing.Point(280, 86);
            this.botonListaClientesGenerarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.botonListaClientesGenerarFactura.Name = "botonListaClientesGenerarFactura";
            this.botonListaClientesGenerarFactura.Size = new System.Drawing.Size(131, 27);
            this.botonListaClientesGenerarFactura.TabIndex = 32;
            this.botonListaClientesGenerarFactura.Text = "Lista de Clientes";
            this.botonListaClientesGenerarFactura.UseVisualStyleBackColor = true;
            this.botonListaClientesGenerarFactura.Click += new System.EventHandler(this.botonListaClientesGenerarFactura_Click);
            // 
            // txtBoxClienteGenerarFactura
            // 
            this.txtBoxClienteGenerarFactura.BackColor = System.Drawing.Color.Moccasin;
            this.txtBoxClienteGenerarFactura.Location = new System.Drawing.Point(121, 124);
            this.txtBoxClienteGenerarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxClienteGenerarFactura.Name = "txtBoxClienteGenerarFactura";
            this.txtBoxClienteGenerarFactura.ReadOnly = true;
            this.txtBoxClienteGenerarFactura.Size = new System.Drawing.Size(288, 22);
            this.txtBoxClienteGenerarFactura.TabIndex = 31;
            // 
            // lblClienteGenerarFactura
            // 
            this.lblClienteGenerarFactura.AutoSize = true;
            this.lblClienteGenerarFactura.Location = new System.Drawing.Point(8, 119);
            this.lblClienteGenerarFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClienteGenerarFactura.Name = "lblClienteGenerarFactura";
            this.lblClienteGenerarFactura.Size = new System.Drawing.Size(105, 17);
            this.lblClienteGenerarFactura.TabIndex = 30;
            this.lblClienteGenerarFactura.Text = "Nombre Cliente";
            // 
            // lblAtendidoPorGenerarFactura
            // 
            this.lblAtendidoPorGenerarFactura.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAtendidoPorGenerarFactura.Location = new System.Drawing.Point(117, 52);
            this.lblAtendidoPorGenerarFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAtendidoPorGenerarFactura.Name = "lblAtendidoPorGenerarFactura";
            this.lblAtendidoPorGenerarFactura.Size = new System.Drawing.Size(267, 20);
            this.lblAtendidoPorGenerarFactura.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "JUDY\'s PALACE HOSTAL";
            // 
            // txtTelefonoGenerarFactura
            // 
            this.txtTelefonoGenerarFactura.BackColor = System.Drawing.Color.Moccasin;
            this.txtTelefonoGenerarFactura.Location = new System.Drawing.Point(625, 112);
            this.txtTelefonoGenerarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoGenerarFactura.Name = "txtTelefonoGenerarFactura";
            this.txtTelefonoGenerarFactura.ReadOnly = true;
            this.txtTelefonoGenerarFactura.Size = new System.Drawing.Size(264, 22);
            this.txtTelefonoGenerarFactura.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Teléfono";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Moccasin;
            this.dateTimePicker1.Location = new System.Drawing.Point(625, 52);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fecha";
            // 
            // txtDireccionGenerarFactura
            // 
            this.txtDireccionGenerarFactura.BackColor = System.Drawing.Color.Moccasin;
            this.txtDireccionGenerarFactura.Location = new System.Drawing.Point(625, 82);
            this.txtDireccionGenerarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionGenerarFactura.Name = "txtDireccionGenerarFactura";
            this.txtDireccionGenerarFactura.ReadOnly = true;
            this.txtDireccionGenerarFactura.Size = new System.Drawing.Size(261, 22);
            this.txtDireccionGenerarFactura.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Dirección";
            // 
            // txtidClienteGenerarFactura
            // 
            this.txtidClienteGenerarFactura.BackColor = System.Drawing.Color.Moccasin;
            this.txtidClienteGenerarFactura.Location = new System.Drawing.Point(121, 90);
            this.txtidClienteGenerarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtidClienteGenerarFactura.Name = "txtidClienteGenerarFactura";
            this.txtidClienteGenerarFactura.ReadOnly = true;
            this.txtidClienteGenerarFactura.Size = new System.Drawing.Size(149, 22);
            this.txtidClienteGenerarFactura.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Atendido por:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 34);
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
            this.panel1.Location = new System.Drawing.Point(684, 207);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 342);
            this.panel1.TabIndex = 47;
            // 
            // botonNuevaFacturaGenerarFactura
            // 
            this.botonNuevaFacturaGenerarFactura.Location = new System.Drawing.Point(53, 16);
            this.botonNuevaFacturaGenerarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.botonNuevaFacturaGenerarFactura.Name = "botonNuevaFacturaGenerarFactura";
            this.botonNuevaFacturaGenerarFactura.Size = new System.Drawing.Size(132, 64);
            this.botonNuevaFacturaGenerarFactura.TabIndex = 46;
            this.botonNuevaFacturaGenerarFactura.Text = "Nueva Factura";
            this.botonNuevaFacturaGenerarFactura.UseVisualStyleBackColor = true;
            this.botonNuevaFacturaGenerarFactura.Click += new System.EventHandler(this.botonNuevaFacturaGenerarFactura_Click);
            // 
            // botonListaProductosGenerarFactura
            // 
            this.botonListaProductosGenerarFactura.Location = new System.Drawing.Point(29, 188);
            this.botonListaProductosGenerarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.botonListaProductosGenerarFactura.Name = "botonListaProductosGenerarFactura";
            this.botonListaProductosGenerarFactura.Size = new System.Drawing.Size(189, 48);
            this.botonListaProductosGenerarFactura.TabIndex = 45;
            this.botonListaProductosGenerarFactura.Text = "Lista de Servicios/Productos";
            this.botonListaProductosGenerarFactura.UseVisualStyleBackColor = true;
            this.botonListaProductosGenerarFactura.Click += new System.EventHandler(this.botonListaProductosGenerarFactura_Click);
            // 
            // BotonAniadir
            // 
            this.BotonAniadir.Location = new System.Drawing.Point(29, 105);
            this.BotonAniadir.Margin = new System.Windows.Forms.Padding(4);
            this.BotonAniadir.Name = "BotonAniadir";
            this.BotonAniadir.Size = new System.Drawing.Size(191, 36);
            this.BotonAniadir.TabIndex = 3;
            this.BotonAniadir.Text = "Agregar Servicio/Producto";
            this.BotonAniadir.UseVisualStyleBackColor = true;
            this.BotonAniadir.Click += new System.EventHandler(this.BotonAniadirGenerarFactura_Click);
            // 
            // BotonEliminarGenerarfactura
            // 
            this.BotonEliminarGenerarfactura.Location = new System.Drawing.Point(29, 148);
            this.BotonEliminarGenerarfactura.Margin = new System.Windows.Forms.Padding(4);
            this.BotonEliminarGenerarfactura.Name = "BotonEliminarGenerarfactura";
            this.BotonEliminarGenerarfactura.Size = new System.Drawing.Size(191, 33);
            this.BotonEliminarGenerarfactura.TabIndex = 4;
            this.BotonEliminarGenerarfactura.Text = "Eliminar Servicio/Producto";
            this.BotonEliminarGenerarfactura.UseVisualStyleBackColor = true;
            this.BotonEliminarGenerarfactura.Click += new System.EventHandler(this.BotonEliminarGenerarfactura_Click);
            // 
            // BotonFacturarGenerarFactura
            // 
            this.BotonFacturarGenerarFactura.Location = new System.Drawing.Point(29, 244);
            this.BotonFacturarGenerarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.BotonFacturarGenerarFactura.Name = "BotonFacturarGenerarFactura";
            this.BotonFacturarGenerarFactura.Size = new System.Drawing.Size(191, 28);
            this.BotonFacturarGenerarFactura.TabIndex = 2;
            this.BotonFacturarGenerarFactura.Text = "Facturar";
            this.BotonFacturarGenerarFactura.UseVisualStyleBackColor = true;
            this.BotonFacturarGenerarFactura.Click += new System.EventHandler(this.BotonFacturarGenerarFactura_Click);
            // 
            // BotonSalirGenerarFactura
            // 
            this.BotonSalirGenerarFactura.Location = new System.Drawing.Point(29, 279);
            this.BotonSalirGenerarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.BotonSalirGenerarFactura.Name = "BotonSalirGenerarFactura";
            this.BotonSalirGenerarFactura.Size = new System.Drawing.Size(187, 31);
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
            this.panel3.Location = new System.Drawing.Point(12, 207);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(652, 383);
            this.panel3.TabIndex = 49;
            // 
            // comboBoxTAX
            // 
            this.comboBoxTAX.BackColor = System.Drawing.Color.Moccasin;
            this.comboBoxTAX.FormattingEnabled = true;
            this.comboBoxTAX.Items.AddRange(new object[] {
            "12%",
            "14%"});
            this.comboBoxTAX.Location = new System.Drawing.Point(365, 283);
            this.comboBoxTAX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTAX.Name = "comboBoxTAX";
            this.comboBoxTAX.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTAX.TabIndex = 8;
            this.comboBoxTAX.SelectedIndexChanged += new System.EventHandler(this.comboBoxTAX_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 343);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "Total";
            // 
            // txtTotalGenerarFactura
            // 
            this.txtTotalGenerarFactura.BackColor = System.Drawing.Color.Moccasin;
            this.txtTotalGenerarFactura.Location = new System.Drawing.Point(496, 335);
            this.txtTotalGenerarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalGenerarFactura.Name = "txtTotalGenerarFactura";
            this.txtTotalGenerarFactura.ReadOnly = true;
            this.txtTotalGenerarFactura.Size = new System.Drawing.Size(132, 22);
            this.txtTotalGenerarFactura.TabIndex = 6;
            // 
            // txtImpuestoGenerarFactura
            // 
            this.txtImpuestoGenerarFactura.BackColor = System.Drawing.Color.Moccasin;
            this.txtImpuestoGenerarFactura.Location = new System.Drawing.Point(496, 284);
            this.txtImpuestoGenerarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtImpuestoGenerarFactura.Name = "txtImpuestoGenerarFactura";
            this.txtImpuestoGenerarFactura.ReadOnly = true;
            this.txtImpuestoGenerarFactura.Size = new System.Drawing.Size(132, 22);
            this.txtImpuestoGenerarFactura.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(285, 293);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Impuestos";
            // 
            // txtSubtotalGenerarFactura
            // 
            this.txtSubtotalGenerarFactura.BackColor = System.Drawing.Color.Moccasin;
            this.txtSubtotalGenerarFactura.Location = new System.Drawing.Point(496, 236);
            this.txtSubtotalGenerarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubtotalGenerarFactura.Name = "txtSubtotalGenerarFactura";
            this.txtSubtotalGenerarFactura.ReadOnly = true;
            this.txtSubtotalGenerarFactura.Size = new System.Drawing.Size(132, 22);
            this.txtSubtotalGenerarFactura.TabIndex = 2;
            this.txtSubtotalGenerarFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 240);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
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
            this.DGVGenerarFactura.Location = new System.Drawing.Point(12, 15);
            this.DGVGenerarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.DGVGenerarFactura.Name = "DGVGenerarFactura";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVGenerarFactura.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVGenerarFactura.Size = new System.Drawing.Size(620, 214);
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
            this.txtCodigoGenerarFactura.Location = new System.Drawing.Point(84, 170);
            this.txtCodigoGenerarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoGenerarFactura.Name = "txtCodigoGenerarFactura";
            this.txtCodigoGenerarFactura.ReadOnly = true;
            this.txtCodigoGenerarFactura.Size = new System.Drawing.Size(56, 22);
            this.txtCodigoGenerarFactura.TabIndex = 53;
            this.txtCodigoGenerarFactura.Validar = true;
            // 
            // txtDescripcionGenerarFactura
            // 
            this.txtDescripcionGenerarFactura.BackColor = System.Drawing.Color.Moccasin;
            this.txtDescripcionGenerarFactura.Location = new System.Drawing.Point(236, 170);
            this.txtDescripcionGenerarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionGenerarFactura.Name = "txtDescripcionGenerarFactura";
            this.txtDescripcionGenerarFactura.ReadOnly = true;
            this.txtDescripcionGenerarFactura.Size = new System.Drawing.Size(153, 22);
            this.txtDescripcionGenerarFactura.TabIndex = 52;
            this.txtDescripcionGenerarFactura.Validar = true;
            // 
            // txtValUniGenerarFactura
            // 
            this.txtValUniGenerarFactura.BackColor = System.Drawing.Color.Moccasin;
            this.txtValUniGenerarFactura.Location = new System.Drawing.Point(399, 170);
            this.txtValUniGenerarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtValUniGenerarFactura.Name = "txtValUniGenerarFactura";
            this.txtValUniGenerarFactura.ReadOnly = true;
            this.txtValUniGenerarFactura.Size = new System.Drawing.Size(104, 22);
            this.txtValUniGenerarFactura.TabIndex = 51;
            this.txtValUniGenerarFactura.Validar = true;
            // 
            // txtCantidadGenerarFactura
            // 
            this.txtCantidadGenerarFactura.BackColor = System.Drawing.Color.Moccasin;
            this.txtCantidadGenerarFactura.Location = new System.Drawing.Point(149, 170);
            this.txtCantidadGenerarFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadGenerarFactura.Name = "txtCantidadGenerarFactura";
            this.txtCantidadGenerarFactura.Size = new System.Drawing.Size(77, 22);
            this.txtCantidadGenerarFactura.TabIndex = 45;
            this.txtCantidadGenerarFactura.Validar = true;
            // 
            // FormGenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(945, 617);
            this.Controls.Add(this.txtCodigoGenerarFactura);
            this.Controls.Add(this.txtDescripcionGenerarFactura);
            this.Controls.Add(this.txtValUniGenerarFactura);
            this.Controls.Add(this.txtCantidadGenerarFactura);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label lblCodCli;
    }
}