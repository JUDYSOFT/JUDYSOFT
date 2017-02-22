namespace JUDYSOFT
{
    partial class FormConsultarCliente
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
            this.btnSalirConsultarCliente = new System.Windows.Forms.Button();
            this.panelInformación = new System.Windows.Forms.Panel();
            this.comboBoxConsultarEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtDireccionConsultarCliente = new Libreria.ErrorTxtBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txtCorreoConsultarCLiente = new Libreria.ErrorTxtBox();
            this.txtProcedenciaConsultarCliente = new Libreria.ErrorTxtBox();
            this.txtTelefono2ConsultarCliente = new Libreria.ErrorTxtBox();
            this.txtApellido2ConsultarCliente = new Libreria.ErrorTxtBox();
            this.txtNombre2ConsultarCliente = new Libreria.ErrorTxtBox();
            this.txtNombre1ConsultarCliente = new Libreria.ErrorTxtBox();
            this.txtApellido1ConsultarCliente = new Libreria.ErrorTxtBox();
            this.txtTelefono1ConsultarCliente = new Libreria.ErrorTxtBox();
            this.txtNacionalidadConsultarCliente = new Libreria.ErrorTxtBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.labelProcedencia = new System.Windows.Forms.Label();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.labelNombre2 = new System.Windows.Forms.Label();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.lbltelefono2 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.groupBoxDocumento = new System.Windows.Forms.GroupBox();
            this.txtNumIdentificacionConsultarCliente = new Libreria.ErrorTxtBox();
            this.listaClientesConsultarCliente = new System.Windows.Forms.Button();
            this.botonConsultar = new System.Windows.Forms.Button();
            this.lblDocumentoIdentificaciónConsultarDatosCliente = new System.Windows.Forms.Label();
            this.panelInformación.SuspendLayout();
            this.groupBoxDocumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalirConsultarCliente
            // 
            this.btnSalirConsultarCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalirConsultarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirConsultarCliente.Location = new System.Drawing.Point(317, 465);
            this.btnSalirConsultarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalirConsultarCliente.Name = "btnSalirConsultarCliente";
            this.btnSalirConsultarCliente.Size = new System.Drawing.Size(119, 40);
            this.btnSalirConsultarCliente.TabIndex = 65;
            this.btnSalirConsultarCliente.Text = "Salir";
            this.btnSalirConsultarCliente.UseVisualStyleBackColor = false;
            this.btnSalirConsultarCliente.Click += new System.EventHandler(this.btnSalirConsultarCliente_Click);
            // 
            // panelInformación
            // 
            this.panelInformación.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInformación.Controls.Add(this.comboBoxConsultarEstadoCivil);
            this.panelInformación.Controls.Add(this.txtDireccionConsultarCliente);
            this.panelInformación.Controls.Add(this.lbldireccion);
            this.panelInformación.Controls.Add(this.txtCorreoConsultarCLiente);
            this.panelInformación.Controls.Add(this.txtProcedenciaConsultarCliente);
            this.panelInformación.Controls.Add(this.txtTelefono2ConsultarCliente);
            this.panelInformación.Controls.Add(this.txtApellido2ConsultarCliente);
            this.panelInformación.Controls.Add(this.txtNombre2ConsultarCliente);
            this.panelInformación.Controls.Add(this.txtNombre1ConsultarCliente);
            this.panelInformación.Controls.Add(this.txtApellido1ConsultarCliente);
            this.panelInformación.Controls.Add(this.txtTelefono1ConsultarCliente);
            this.panelInformación.Controls.Add(this.txtNacionalidadConsultarCliente);
            this.panelInformación.Controls.Add(this.labelCorreo);
            this.panelInformación.Controls.Add(this.lblEstadoCivil);
            this.panelInformación.Controls.Add(this.lblNacionalidad);
            this.panelInformación.Controls.Add(this.labelProcedencia);
            this.panelInformación.Controls.Add(this.lblNombre1);
            this.panelInformación.Controls.Add(this.labelNombre2);
            this.panelInformación.Controls.Add(this.lblApellido1);
            this.panelInformación.Controls.Add(this.lblApellido2);
            this.panelInformación.Controls.Add(this.lbltelefono2);
            this.panelInformación.Controls.Add(this.lblTelefono);
            this.panelInformación.Location = new System.Drawing.Point(54, 132);
            this.panelInformación.Margin = new System.Windows.Forms.Padding(2);
            this.panelInformación.Name = "panelInformación";
            this.panelInformación.Size = new System.Drawing.Size(590, 303);
            this.panelInformación.TabIndex = 64;
            // 
            // comboBoxConsultarEstadoCivil
            // 
            this.comboBoxConsultarEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConsultarEstadoCivil.FormattingEnabled = true;
            this.comboBoxConsultarEstadoCivil.Items.AddRange(new object[] {
            "Casado/(a)",
            "Soltero/(a)",
            "Viudo/(a)",
            "Divorciado/(a)",
            "Comprometido/(a)"});
            this.comboBoxConsultarEstadoCivil.Location = new System.Drawing.Point(148, 218);
            this.comboBoxConsultarEstadoCivil.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxConsultarEstadoCivil.Name = "comboBoxConsultarEstadoCivil";
            this.comboBoxConsultarEstadoCivil.Size = new System.Drawing.Size(130, 21);
            this.comboBoxConsultarEstadoCivil.TabIndex = 123;
            // 
            // txtDireccionConsultarCliente
            // 
            this.txtDireccionConsultarCliente.BackColor = System.Drawing.Color.Moccasin;
            this.txtDireccionConsultarCliente.Location = new System.Drawing.Point(148, 260);
            this.txtDireccionConsultarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccionConsultarCliente.Name = "txtDireccionConsultarCliente";
            this.txtDireccionConsultarCliente.Size = new System.Drawing.Size(130, 20);
            this.txtDireccionConsultarCliente.TabIndex = 120;
            this.txtDireccionConsultarCliente.Validar = false;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.Location = new System.Drawing.Point(33, 258);
            this.lbldireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(71, 34);
            this.lbldireccion.TabIndex = 119;
            this.lbldireccion.Text = "Dirección \r\nDomicilio";
            // 
            // txtCorreoConsultarCLiente
            // 
            this.txtCorreoConsultarCLiente.BackColor = System.Drawing.Color.Moccasin;
            this.txtCorreoConsultarCLiente.Location = new System.Drawing.Point(422, 218);
            this.txtCorreoConsultarCLiente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreoConsultarCLiente.Name = "txtCorreoConsultarCLiente";
            this.txtCorreoConsultarCLiente.Size = new System.Drawing.Size(130, 20);
            this.txtCorreoConsultarCLiente.TabIndex = 118;
            this.txtCorreoConsultarCLiente.Validar = false;
            // 
            // txtProcedenciaConsultarCliente
            // 
            this.txtProcedenciaConsultarCliente.BackColor = System.Drawing.Color.Moccasin;
            this.txtProcedenciaConsultarCliente.Location = new System.Drawing.Point(422, 173);
            this.txtProcedenciaConsultarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtProcedenciaConsultarCliente.Name = "txtProcedenciaConsultarCliente";
            this.txtProcedenciaConsultarCliente.Size = new System.Drawing.Size(131, 20);
            this.txtProcedenciaConsultarCliente.TabIndex = 117;
            this.txtProcedenciaConsultarCliente.Validar = false;
            // 
            // txtTelefono2ConsultarCliente
            // 
            this.txtTelefono2ConsultarCliente.BackColor = System.Drawing.Color.Moccasin;
            this.txtTelefono2ConsultarCliente.Location = new System.Drawing.Point(422, 117);
            this.txtTelefono2ConsultarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono2ConsultarCliente.Name = "txtTelefono2ConsultarCliente";
            this.txtTelefono2ConsultarCliente.Size = new System.Drawing.Size(129, 20);
            this.txtTelefono2ConsultarCliente.TabIndex = 116;
            this.txtTelefono2ConsultarCliente.Validar = false;
            // 
            // txtApellido2ConsultarCliente
            // 
            this.txtApellido2ConsultarCliente.BackColor = System.Drawing.Color.Moccasin;
            this.txtApellido2ConsultarCliente.Location = new System.Drawing.Point(422, 66);
            this.txtApellido2ConsultarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido2ConsultarCliente.Name = "txtApellido2ConsultarCliente";
            this.txtApellido2ConsultarCliente.Size = new System.Drawing.Size(130, 20);
            this.txtApellido2ConsultarCliente.TabIndex = 115;
            this.txtApellido2ConsultarCliente.Validar = false;
            // 
            // txtNombre2ConsultarCliente
            // 
            this.txtNombre2ConsultarCliente.BackColor = System.Drawing.Color.Moccasin;
            this.txtNombre2ConsultarCliente.Location = new System.Drawing.Point(422, 25);
            this.txtNombre2ConsultarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre2ConsultarCliente.Name = "txtNombre2ConsultarCliente";
            this.txtNombre2ConsultarCliente.Size = new System.Drawing.Size(130, 20);
            this.txtNombre2ConsultarCliente.TabIndex = 114;
            this.txtNombre2ConsultarCliente.Validar = false;
            // 
            // txtNombre1ConsultarCliente
            // 
            this.txtNombre1ConsultarCliente.BackColor = System.Drawing.Color.Moccasin;
            this.txtNombre1ConsultarCliente.Location = new System.Drawing.Point(148, 21);
            this.txtNombre1ConsultarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre1ConsultarCliente.Name = "txtNombre1ConsultarCliente";
            this.txtNombre1ConsultarCliente.Size = new System.Drawing.Size(130, 20);
            this.txtNombre1ConsultarCliente.TabIndex = 112;
            this.txtNombre1ConsultarCliente.Validar = true;
            // 
            // txtApellido1ConsultarCliente
            // 
            this.txtApellido1ConsultarCliente.BackColor = System.Drawing.Color.Moccasin;
            this.txtApellido1ConsultarCliente.Location = new System.Drawing.Point(148, 66);
            this.txtApellido1ConsultarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido1ConsultarCliente.Name = "txtApellido1ConsultarCliente";
            this.txtApellido1ConsultarCliente.Size = new System.Drawing.Size(130, 20);
            this.txtApellido1ConsultarCliente.TabIndex = 111;
            this.txtApellido1ConsultarCliente.Validar = true;
            // 
            // txtTelefono1ConsultarCliente
            // 
            this.txtTelefono1ConsultarCliente.BackColor = System.Drawing.Color.Moccasin;
            this.txtTelefono1ConsultarCliente.Location = new System.Drawing.Point(148, 114);
            this.txtTelefono1ConsultarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono1ConsultarCliente.Name = "txtTelefono1ConsultarCliente";
            this.txtTelefono1ConsultarCliente.Size = new System.Drawing.Size(130, 20);
            this.txtTelefono1ConsultarCliente.TabIndex = 110;
            this.txtTelefono1ConsultarCliente.Validar = true;
            // 
            // txtNacionalidadConsultarCliente
            // 
            this.txtNacionalidadConsultarCliente.BackColor = System.Drawing.Color.Moccasin;
            this.txtNacionalidadConsultarCliente.Location = new System.Drawing.Point(148, 171);
            this.txtNacionalidadConsultarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNacionalidadConsultarCliente.Name = "txtNacionalidadConsultarCliente";
            this.txtNacionalidadConsultarCliente.Size = new System.Drawing.Size(130, 20);
            this.txtNacionalidadConsultarCliente.TabIndex = 109;
            this.txtNacionalidadConsultarCliente.Validar = true;
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(313, 216);
            this.labelCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(78, 34);
            this.labelCorreo.TabIndex = 108;
            this.labelCorreo.Text = "Correo \r\nElectrónico";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.Location = new System.Drawing.Point(34, 216);
            this.lblEstadoCivil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(79, 16);
            this.lblEstadoCivil.TabIndex = 107;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidad.Location = new System.Drawing.Point(34, 172);
            this.lblNacionalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(105, 16);
            this.lblNacionalidad.TabIndex = 106;
            this.lblNacionalidad.Text = "Nacionalidad (*)";
            // 
            // labelProcedencia
            // 
            this.labelProcedencia.AutoSize = true;
            this.labelProcedencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcedencia.Location = new System.Drawing.Point(313, 164);
            this.labelProcedencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProcedencia.Name = "labelProcedencia";
            this.labelProcedencia.Size = new System.Drawing.Size(88, 32);
            this.labelProcedencia.TabIndex = 105;
            this.labelProcedencia.Text = "Lugar de \r\nProcedencia ";
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre1.Location = new System.Drawing.Point(34, 21);
            this.lblNombre1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(86, 16);
            this.lblNombre1.TabIndex = 99;
            this.lblNombre1.Text = " Nombre 1 (*)";
            this.lblNombre1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelNombre2
            // 
            this.labelNombre2.AutoSize = true;
            this.labelNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre2.Location = new System.Drawing.Point(313, 21);
            this.labelNombre2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre2.Name = "labelNombre2";
            this.labelNombre2.Size = new System.Drawing.Size(67, 16);
            this.labelNombre2.TabIndex = 102;
            this.labelNombre2.Text = "Nombre 2";
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido1.Location = new System.Drawing.Point(34, 67);
            this.lblApellido1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(84, 16);
            this.lblApellido1.TabIndex = 100;
            this.lblApellido1.Text = "Apellido 1 (*)";
            this.lblApellido1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido2.Location = new System.Drawing.Point(313, 67);
            this.lblApellido2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(68, 16);
            this.lblApellido2.TabIndex = 101;
            this.lblApellido2.Text = "Apellido 2";
            // 
            // lbltelefono2
            // 
            this.lbltelefono2.AutoSize = true;
            this.lbltelefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono2.Location = new System.Drawing.Point(313, 117);
            this.lbltelefono2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltelefono2.Name = "lbltelefono2";
            this.lbltelefono2.Size = new System.Drawing.Size(75, 16);
            this.lbltelefono2.TabIndex = 104;
            this.lbltelefono2.Text = "Teléfono 2 ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(34, 115);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(88, 16);
            this.lblTelefono.TabIndex = 103;
            this.lblTelefono.Text = "Teléfono 1 (*)";
            // 
            // groupBoxDocumento
            // 
            this.groupBoxDocumento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxDocumento.Controls.Add(this.lblDocumentoIdentificaciónConsultarDatosCliente);
            this.groupBoxDocumento.Controls.Add(this.txtNumIdentificacionConsultarCliente);
            this.groupBoxDocumento.Location = new System.Drawing.Point(54, 31);
            this.groupBoxDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDocumento.Name = "groupBoxDocumento";
            this.groupBoxDocumento.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDocumento.Size = new System.Drawing.Size(314, 81);
            this.groupBoxDocumento.TabIndex = 66;
            this.groupBoxDocumento.TabStop = false;
            this.groupBoxDocumento.Text = "Documento de Identificación (*)";
            // 
            // txtNumIdentificacionConsultarCliente
            // 
            this.txtNumIdentificacionConsultarCliente.BackColor = System.Drawing.Color.Moccasin;
            this.txtNumIdentificacionConsultarCliente.Location = new System.Drawing.Point(150, 36);
            this.txtNumIdentificacionConsultarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumIdentificacionConsultarCliente.Name = "txtNumIdentificacionConsultarCliente";
            this.txtNumIdentificacionConsultarCliente.Size = new System.Drawing.Size(130, 20);
            this.txtNumIdentificacionConsultarCliente.TabIndex = 21;
            this.txtNumIdentificacionConsultarCliente.Validar = true;
            // 
            // listaClientesConsultarCliente
            // 
            this.listaClientesConsultarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaClientesConsultarCliente.Location = new System.Drawing.Point(508, 53);
            this.listaClientesConsultarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.listaClientesConsultarCliente.Name = "listaClientesConsultarCliente";
            this.listaClientesConsultarCliente.Size = new System.Drawing.Size(129, 37);
            this.listaClientesConsultarCliente.TabIndex = 68;
            this.listaClientesConsultarCliente.Text = "Lista de Clientes";
            this.listaClientesConsultarCliente.UseVisualStyleBackColor = true;
            this.listaClientesConsultarCliente.Click += new System.EventHandler(this.listaClientesConsultarCliente_Click);
            // 
            // botonConsultar
            // 
            this.botonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConsultar.Location = new System.Drawing.Point(402, 53);
            this.botonConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(88, 37);
            this.botonConsultar.TabIndex = 67;
            this.botonConsultar.Text = "Consultar";
            this.botonConsultar.UseVisualStyleBackColor = true;
            this.botonConsultar.Click += new System.EventHandler(this.botonConsultar_Click);
            // 
            // lblDocumentoIdentificaciónConsultarDatosCliente
            // 
            this.lblDocumentoIdentificaciónConsultarDatosCliente.AutoSize = true;
            this.lblDocumentoIdentificaciónConsultarDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentoIdentificaciónConsultarDatosCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDocumentoIdentificaciónConsultarDatosCliente.Location = new System.Drawing.Point(8, 39);
            this.lblDocumentoIdentificaciónConsultarDatosCliente.Name = "lblDocumentoIdentificaciónConsultarDatosCliente";
            this.lblDocumentoIdentificaciónConsultarDatosCliente.Size = new System.Drawing.Size(133, 17);
            this.lblDocumentoIdentificaciónConsultarDatosCliente.TabIndex = 22;
            this.lblDocumentoIdentificaciónConsultarDatosCliente.Text = "Cédula o Pasaporte";
            // 
            // FormConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(712, 563);
            this.Controls.Add(this.listaClientesConsultarCliente);
            this.Controls.Add(this.botonConsultar);
            this.Controls.Add(this.groupBoxDocumento);
            this.Controls.Add(this.btnSalirConsultarCliente);
            this.Controls.Add(this.panelInformación);
            this.Name = "FormConsultarCliente";
            this.Text = "Consultar Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConsultarCliente_FormClosing);
            this.Load += new System.EventHandler(this.FormConsultarCliente_Load);
            this.panelInformación.ResumeLayout(false);
            this.panelInformación.PerformLayout();
            this.groupBoxDocumento.ResumeLayout(false);
            this.groupBoxDocumento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalirConsultarCliente;
        private System.Windows.Forms.Panel panelInformación;
        private System.Windows.Forms.ComboBox comboBoxConsultarEstadoCivil;
        private Libreria.ErrorTxtBox txtDireccionConsultarCliente;
        private System.Windows.Forms.Label lbldireccion;
        private Libreria.ErrorTxtBox txtCorreoConsultarCLiente;
        private Libreria.ErrorTxtBox txtProcedenciaConsultarCliente;
        private Libreria.ErrorTxtBox txtTelefono2ConsultarCliente;
        private Libreria.ErrorTxtBox txtApellido2ConsultarCliente;
        private Libreria.ErrorTxtBox txtNombre2ConsultarCliente;
        private Libreria.ErrorTxtBox txtNombre1ConsultarCliente;
        private Libreria.ErrorTxtBox txtApellido1ConsultarCliente;
        private Libreria.ErrorTxtBox txtTelefono1ConsultarCliente;
        private Libreria.ErrorTxtBox txtNacionalidadConsultarCliente;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label labelProcedencia;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label labelNombre2;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.Label lbltelefono2;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.GroupBox groupBoxDocumento;
        private Libreria.ErrorTxtBox txtNumIdentificacionConsultarCliente;
        private System.Windows.Forms.Button listaClientesConsultarCliente;
        private System.Windows.Forms.Button botonConsultar;
        private System.Windows.Forms.Label lblDocumentoIdentificaciónConsultarDatosCliente;
    }
}