namespace JUDYSOFT
{
    partial class FormIngresarNuevoCliente
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelarIngresoCliente = new System.Windows.Forms.Button();
            this.btnAceptarIngresoCliente = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxDocumento = new System.Windows.Forms.GroupBox();
            this.txtNumIdentificacionIngresoCliente = new Libreria.ErrorTxtBox();
            this.radioPasaporteIngresoCliente = new System.Windows.Forms.RadioButton();
            this.radioCedulaIngresoCliente = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.panelInformación = new System.Windows.Forms.Panel();
            this.comboBoxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtDireccionIngresoCliente = new Libreria.ErrorTxtBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txtCorreoIngresoCLiente = new Libreria.ErrorTxtBox();
            this.txtProcedenciaIngresoCliente = new Libreria.ErrorTxtBox();
            this.txtTelefono2IngresoCliente = new Libreria.ErrorTxtBox();
            this.txtApellido2IngresoCliente = new Libreria.ErrorTxtBox();
            this.txtNombre2IngresoCliente = new Libreria.ErrorTxtBox();
            this.txtNombre1IngresoCliente = new Libreria.ErrorTxtBox();
            this.txtApellido1IngresoCliente = new Libreria.ErrorTxtBox();
            this.txtTelefono1IngresoCliente = new Libreria.ErrorTxtBox();
            this.txtNacionalidadIngresoCliente = new Libreria.ErrorTxtBox();
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
            this.btnSalirCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.groupBoxDocumento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelInformación.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(196, -38);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 26);
            this.label4.TabIndex = 26;
            this.label4.Text = "Judy\'s Palace Hostal";
            // 
            // btnCancelarIngresoCliente
            // 
            this.btnCancelarIngresoCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelarIngresoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelarIngresoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarIngresoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarIngresoCliente.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarIngresoCliente.Image = global::JUDYSOFT.Properties.Resources._1484546297_Cancel;
            this.btnCancelarIngresoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarIngresoCliente.Location = new System.Drawing.Point(279, 456);
            this.btnCancelarIngresoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelarIngresoCliente.Name = "btnCancelarIngresoCliente";
            this.btnCancelarIngresoCliente.Size = new System.Drawing.Size(119, 40);
            this.btnCancelarIngresoCliente.TabIndex = 28;
            this.btnCancelarIngresoCliente.Text = "Cancelar";
            this.btnCancelarIngresoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarIngresoCliente.UseVisualStyleBackColor = false;
            this.btnCancelarIngresoCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAceptarIngresoCliente
            // 
            this.btnAceptarIngresoCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAceptarIngresoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarIngresoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarIngresoCliente.ForeColor = System.Drawing.Color.Black;
            this.btnAceptarIngresoCliente.Image = global::JUDYSOFT.Properties.Resources._1484546293_Save;
            this.btnAceptarIngresoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptarIngresoCliente.Location = new System.Drawing.Point(119, 456);
            this.btnAceptarIngresoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptarIngresoCliente.Name = "btnAceptarIngresoCliente";
            this.btnAceptarIngresoCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAceptarIngresoCliente.Size = new System.Drawing.Size(127, 40);
            this.btnAceptarIngresoCliente.TabIndex = 27;
            this.btnAceptarIngresoCliente.Text = "Guardar";
            this.btnAceptarIngresoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptarIngresoCliente.UseVisualStyleBackColor = false;
            this.btnAceptarIngresoCliente.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // groupBoxDocumento
            // 
            this.groupBoxDocumento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxDocumento.Controls.Add(this.txtNumIdentificacionIngresoCliente);
            this.groupBoxDocumento.Controls.Add(this.radioPasaporteIngresoCliente);
            this.groupBoxDocumento.Controls.Add(this.radioCedulaIngresoCliente);
            this.groupBoxDocumento.Location = new System.Drawing.Point(32, 19);
            this.groupBoxDocumento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDocumento.Name = "groupBoxDocumento";
            this.groupBoxDocumento.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxDocumento.Size = new System.Drawing.Size(314, 81);
            this.groupBoxDocumento.TabIndex = 3;
            this.groupBoxDocumento.TabStop = false;
            this.groupBoxDocumento.Text = "Documento de Identificación (*)";
            // 
            // txtNumIdentificacionIngresoCliente
            // 
            this.txtNumIdentificacionIngresoCliente.BackColor = System.Drawing.Color.Moccasin;
            this.txtNumIdentificacionIngresoCliente.Location = new System.Drawing.Point(149, 39);
            this.txtNumIdentificacionIngresoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumIdentificacionIngresoCliente.Name = "txtNumIdentificacionIngresoCliente";
            this.txtNumIdentificacionIngresoCliente.Size = new System.Drawing.Size(130, 20);
            this.txtNumIdentificacionIngresoCliente.TabIndex = 21;
            this.txtNumIdentificacionIngresoCliente.Validar = true;
            this.txtNumIdentificacionIngresoCliente.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            this.txtNumIdentificacionIngresoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            this.txtNumIdentificacionIngresoCliente.Leave += new System.EventHandler(this.txtDocumento_Leave);
            // 
            // radioPasaporteIngresoCliente
            // 
            this.radioPasaporteIngresoCliente.AutoSize = true;
            this.radioPasaporteIngresoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPasaporteIngresoCliente.Location = new System.Drawing.Point(38, 51);
            this.radioPasaporteIngresoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioPasaporteIngresoCliente.Name = "radioPasaporteIngresoCliente";
            this.radioPasaporteIngresoCliente.Size = new System.Drawing.Size(91, 21);
            this.radioPasaporteIngresoCliente.TabIndex = 20;
            this.radioPasaporteIngresoCliente.TabStop = true;
            this.radioPasaporteIngresoCliente.Text = "Pasaporte";
            this.radioPasaporteIngresoCliente.UseVisualStyleBackColor = true;
            this.radioPasaporteIngresoCliente.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioCedulaIngresoCliente
            // 
            this.radioCedulaIngresoCliente.AutoSize = true;
            this.radioCedulaIngresoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCedulaIngresoCliente.Location = new System.Drawing.Point(38, 27);
            this.radioCedulaIngresoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioCedulaIngresoCliente.Name = "radioCedulaIngresoCliente";
            this.radioCedulaIngresoCliente.Size = new System.Drawing.Size(70, 21);
            this.radioCedulaIngresoCliente.TabIndex = 19;
            this.radioCedulaIngresoCliente.Text = "Cédula";
            this.radioCedulaIngresoCliente.UseVisualStyleBackColor = true;
            this.radioCedulaIngresoCliente.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioF);
            this.groupBox1.Controls.Add(this.radioM);
            this.groupBox1.Location = new System.Drawing.Point(409, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(212, 81);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo (*)";
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioF.Location = new System.Drawing.Point(118, 37);
            this.radioF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(86, 20);
            this.radioF.TabIndex = 4;
            this.radioF.TabStop = true;
            this.radioF.Text = "Femenino";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Checked = true;
            this.radioM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioM.Location = new System.Drawing.Point(13, 37);
            this.radioM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(87, 20);
            this.radioM.TabIndex = 3;
            this.radioM.TabStop = true;
            this.radioM.Text = "Masculino";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // panelInformación
            // 
            this.panelInformación.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInformación.Controls.Add(this.comboBoxEstadoCivil);
            this.panelInformación.Controls.Add(this.txtDireccionIngresoCliente);
            this.panelInformación.Controls.Add(this.lbldireccion);
            this.panelInformación.Controls.Add(this.txtCorreoIngresoCLiente);
            this.panelInformación.Controls.Add(this.txtProcedenciaIngresoCliente);
            this.panelInformación.Controls.Add(this.txtTelefono2IngresoCliente);
            this.panelInformación.Controls.Add(this.txtApellido2IngresoCliente);
            this.panelInformación.Controls.Add(this.txtNombre2IngresoCliente);
            this.panelInformación.Controls.Add(this.txtNombre1IngresoCliente);
            this.panelInformación.Controls.Add(this.txtApellido1IngresoCliente);
            this.panelInformación.Controls.Add(this.txtTelefono1IngresoCliente);
            this.panelInformación.Controls.Add(this.txtNacionalidadIngresoCliente);
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
            this.panelInformación.Location = new System.Drawing.Point(32, 119);
            this.panelInformación.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelInformación.Name = "panelInformación";
            this.panelInformación.Size = new System.Drawing.Size(590, 303);
            this.panelInformación.TabIndex = 60;
            // 
            // comboBoxEstadoCivil
            // 
            this.comboBoxEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstadoCivil.FormattingEnabled = true;
            this.comboBoxEstadoCivil.Items.AddRange(new object[] {
            "Casado/(a)",
            "Soltero/(a)",
            "Viudo/(a)",
            "Divorciado/(a)",
            "Comprometido/(a)"});
            this.comboBoxEstadoCivil.Location = new System.Drawing.Point(148, 218);
            this.comboBoxEstadoCivil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxEstadoCivil.Name = "comboBoxEstadoCivil";
            this.comboBoxEstadoCivil.Size = new System.Drawing.Size(130, 21);
            this.comboBoxEstadoCivil.TabIndex = 123;
            // 
            // txtDireccionIngresoCliente
            // 
            this.txtDireccionIngresoCliente.BackColor = System.Drawing.Color.Moccasin;
            this.txtDireccionIngresoCliente.Location = new System.Drawing.Point(148, 260);
            this.txtDireccionIngresoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccionIngresoCliente.Name = "txtDireccionIngresoCliente";
            this.txtDireccionIngresoCliente.Size = new System.Drawing.Size(130, 20);
            this.txtDireccionIngresoCliente.TabIndex = 120;
            this.txtDireccionIngresoCliente.Validar = false;
            this.txtDireccionIngresoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
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
            // txtCorreoIngresoCLiente
            // 
            this.txtCorreoIngresoCLiente.BackColor = System.Drawing.Color.Moccasin;
            this.txtCorreoIngresoCLiente.Location = new System.Drawing.Point(422, 218);
            this.txtCorreoIngresoCLiente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreoIngresoCLiente.Name = "txtCorreoIngresoCLiente";
            this.txtCorreoIngresoCLiente.Size = new System.Drawing.Size(130, 20);
            this.txtCorreoIngresoCLiente.TabIndex = 118;
            this.txtCorreoIngresoCLiente.Validar = false;
            this.txtCorreoIngresoCLiente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            // 
            // txtProcedenciaIngresoCliente
            // 
            this.txtProcedenciaIngresoCliente.BackColor = System.Drawing.Color.Moccasin;
            this.txtProcedenciaIngresoCliente.Location = new System.Drawing.Point(422, 173);
            this.txtProcedenciaIngresoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProcedenciaIngresoCliente.Name = "txtProcedenciaIngresoCliente";
            this.txtProcedenciaIngresoCliente.Size = new System.Drawing.Size(131, 20);
            this.txtProcedenciaIngresoCliente.TabIndex = 117;
            this.txtProcedenciaIngresoCliente.Validar = false;
            this.txtProcedenciaIngresoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProcedencia_KeyPress);
            // 
            // txtTelefono2IngresoCliente
            // 
            this.txtTelefono2IngresoCliente.BackColor = System.Drawing.Color.Moccasin;
            this.txtTelefono2IngresoCliente.Location = new System.Drawing.Point(422, 117);
            this.txtTelefono2IngresoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefono2IngresoCliente.Name = "txtTelefono2IngresoCliente";
            this.txtTelefono2IngresoCliente.Size = new System.Drawing.Size(129, 20);
            this.txtTelefono2IngresoCliente.TabIndex = 116;
            this.txtTelefono2IngresoCliente.Validar = false;
            this.txtTelefono2IngresoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono2_KeyPress);
            // 
            // txtApellido2IngresoCliente
            // 
            this.txtApellido2IngresoCliente.BackColor = System.Drawing.Color.Moccasin;
            this.txtApellido2IngresoCliente.Location = new System.Drawing.Point(422, 66);
            this.txtApellido2IngresoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido2IngresoCliente.Name = "txtApellido2IngresoCliente";
            this.txtApellido2IngresoCliente.Size = new System.Drawing.Size(130, 20);
            this.txtApellido2IngresoCliente.TabIndex = 115;
            this.txtApellido2IngresoCliente.Validar = false;
            this.txtApellido2IngresoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido2_KeyPress);
            // 
            // txtNombre2IngresoCliente
            // 
            this.txtNombre2IngresoCliente.BackColor = System.Drawing.Color.Moccasin;
            this.txtNombre2IngresoCliente.Location = new System.Drawing.Point(422, 25);
            this.txtNombre2IngresoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre2IngresoCliente.Name = "txtNombre2IngresoCliente";
            this.txtNombre2IngresoCliente.Size = new System.Drawing.Size(130, 20);
            this.txtNombre2IngresoCliente.TabIndex = 114;
            this.txtNombre2IngresoCliente.Validar = false;
            this.txtNombre2IngresoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre2_KeyPress);
            // 
            // txtNombre1IngresoCliente
            // 
            this.txtNombre1IngresoCliente.BackColor = System.Drawing.Color.Moccasin;
            this.txtNombre1IngresoCliente.Location = new System.Drawing.Point(148, 21);
            this.txtNombre1IngresoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre1IngresoCliente.Name = "txtNombre1IngresoCliente";
            this.txtNombre1IngresoCliente.Size = new System.Drawing.Size(130, 20);
            this.txtNombre1IngresoCliente.TabIndex = 112;
            this.txtNombre1IngresoCliente.Validar = true;
            this.txtNombre1IngresoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre1_KeyPress);
            // 
            // txtApellido1IngresoCliente
            // 
            this.txtApellido1IngresoCliente.BackColor = System.Drawing.Color.Moccasin;
            this.txtApellido1IngresoCliente.Location = new System.Drawing.Point(148, 66);
            this.txtApellido1IngresoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido1IngresoCliente.Name = "txtApellido1IngresoCliente";
            this.txtApellido1IngresoCliente.Size = new System.Drawing.Size(130, 20);
            this.txtApellido1IngresoCliente.TabIndex = 111;
            this.txtApellido1IngresoCliente.Validar = true;
            this.txtApellido1IngresoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido1_KeyPress);
            // 
            // txtTelefono1IngresoCliente
            // 
            this.txtTelefono1IngresoCliente.BackColor = System.Drawing.Color.Moccasin;
            this.txtTelefono1IngresoCliente.Location = new System.Drawing.Point(148, 114);
            this.txtTelefono1IngresoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefono1IngresoCliente.Name = "txtTelefono1IngresoCliente";
            this.txtTelefono1IngresoCliente.Size = new System.Drawing.Size(130, 20);
            this.txtTelefono1IngresoCliente.TabIndex = 110;
            this.txtTelefono1IngresoCliente.Validar = true;
            this.txtTelefono1IngresoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono1_KeyPress);
            this.txtTelefono1IngresoCliente.Leave += new System.EventHandler(this.txtTelefono1_Leave);
            // 
            // txtNacionalidadIngresoCliente
            // 
            this.txtNacionalidadIngresoCliente.BackColor = System.Drawing.Color.Moccasin;
            this.txtNacionalidadIngresoCliente.Location = new System.Drawing.Point(148, 171);
            this.txtNacionalidadIngresoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNacionalidadIngresoCliente.Name = "txtNacionalidadIngresoCliente";
            this.txtNacionalidadIngresoCliente.Size = new System.Drawing.Size(130, 20);
            this.txtNacionalidadIngresoCliente.TabIndex = 109;
            this.txtNacionalidadIngresoCliente.Validar = true;
            this.txtNacionalidadIngresoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNacionalidad_KeyPress);
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
            // btnSalirCliente
            // 
            this.btnSalirCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirCliente.Location = new System.Drawing.Point(422, 456);
            this.btnSalirCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalirCliente.Name = "btnSalirCliente";
            this.btnSalirCliente.Size = new System.Drawing.Size(119, 40);
            this.btnSalirCliente.TabIndex = 61;
            this.btnSalirCliente.Text = "Salir";
            this.btnSalirCliente.UseVisualStyleBackColor = false;
            this.btnSalirCliente.Click += new System.EventHandler(this.btnSalirCliente_Click);
            // 
            // FormIngresarNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(657, 522);
            this.Controls.Add(this.btnSalirCliente);
            this.Controls.Add(this.panelInformación);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDocumento);
            this.Controls.Add(this.btnAceptarIngresoCliente);
            this.Controls.Add(this.btnCancelarIngresoCliente);
            this.Controls.Add(this.label4);
            this.Name = "FormIngresarNuevoCliente";
            this.Text = "IngresarCliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIngresarNuevoCliente_FormClosing);
            this.Load += new System.EventHandler(this.FormIngresarNuevoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.groupBoxDocumento.ResumeLayout(false);
            this.groupBoxDocumento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelInformación.ResumeLayout(false);
            this.panelInformación.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelarIngresoCliente;
        private System.Windows.Forms.Button btnAceptarIngresoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.GroupBox groupBoxDocumento;
        private Libreria.ErrorTxtBox txtNumIdentificacionIngresoCliente;
        private System.Windows.Forms.RadioButton radioPasaporteIngresoCliente;
        private System.Windows.Forms.RadioButton radioCedulaIngresoCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.Panel panelInformación;
        private Libreria.ErrorTxtBox txtCorreoIngresoCLiente;
        private Libreria.ErrorTxtBox txtProcedenciaIngresoCliente;
        private Libreria.ErrorTxtBox txtTelefono2IngresoCliente;
        private Libreria.ErrorTxtBox txtApellido2IngresoCliente;
        private Libreria.ErrorTxtBox txtNombre2IngresoCliente;
        private Libreria.ErrorTxtBox txtNombre1IngresoCliente;
        private Libreria.ErrorTxtBox txtApellido1IngresoCliente;
        private Libreria.ErrorTxtBox txtTelefono1IngresoCliente;
        private Libreria.ErrorTxtBox txtNacionalidadIngresoCliente;
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
        private System.Windows.Forms.Label lbldireccion;
        private Libreria.ErrorTxtBox txtDireccionIngresoCliente;
        private System.Windows.Forms.ComboBox comboBoxEstadoCivil;
        private System.Windows.Forms.Button btnSalirCliente;
    }
}