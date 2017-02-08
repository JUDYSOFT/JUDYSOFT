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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxDocumento = new System.Windows.Forms.GroupBox();
            this.txtDocumento = new Libreria.ErrorTxtBox();
            this.radioPasaporte = new System.Windows.Forms.RadioButton();
            this.radioCedula = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panelInformación = new System.Windows.Forms.Panel();
            this.txtDireccion = new Libreria.ErrorTxtBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txtCorreo = new Libreria.ErrorTxtBox();
            this.txtProcedencia = new Libreria.ErrorTxtBox();
            this.txtTelefono2 = new Libreria.ErrorTxtBox();
            this.txtApellido2 = new Libreria.ErrorTxtBox();
            this.txtNombre2 = new Libreria.ErrorTxtBox();
            this.txtEstadoCivil = new Libreria.ErrorTxtBox();
            this.txtNombre1 = new Libreria.ErrorTxtBox();
            this.txtApellido1 = new Libreria.ErrorTxtBox();
            this.txtTelefono1 = new Libreria.ErrorTxtBox();
            this.txtNacionalidad = new Libreria.ErrorTxtBox();
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
            this.label4.Location = new System.Drawing.Point(261, -47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 34);
            this.label4.TabIndex = 26;
            this.label4.Text = "Judy\'s Palace Hostal";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(466, 561);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(159, 49);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(242, 561);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAceptar.Size = new System.Drawing.Size(159, 49);
            this.btnAceptar.TabIndex = 27;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // groupBoxDocumento
            // 
            this.groupBoxDocumento.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxDocumento.Controls.Add(this.txtDocumento);
            this.groupBoxDocumento.Controls.Add(this.radioPasaporte);
            this.groupBoxDocumento.Controls.Add(this.radioCedula);
            this.groupBoxDocumento.Location = new System.Drawing.Point(43, 23);
            this.groupBoxDocumento.Name = "groupBoxDocumento";
            this.groupBoxDocumento.Size = new System.Drawing.Size(419, 100);
            this.groupBoxDocumento.TabIndex = 3;
            this.groupBoxDocumento.TabStop = false;
            this.groupBoxDocumento.Text = "Documento de Identificación (*)";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(199, 48);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(172, 22);
            this.txtDocumento.TabIndex = 21;
            this.txtDocumento.Validar = true;
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            this.txtDocumento.Leave += new System.EventHandler(this.txtDocumento_Leave);
            // 
            // radioPasaporte
            // 
            this.radioPasaporte.AutoSize = true;
            this.radioPasaporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPasaporte.Location = new System.Drawing.Point(50, 63);
            this.radioPasaporte.Name = "radioPasaporte";
            this.radioPasaporte.Size = new System.Drawing.Size(106, 24);
            this.radioPasaporte.TabIndex = 20;
            this.radioPasaporte.TabStop = true;
            this.radioPasaporte.Text = "Pasaporte";
            this.radioPasaporte.UseVisualStyleBackColor = true;
            this.radioPasaporte.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioCedula
            // 
            this.radioCedula.AutoSize = true;
            this.radioCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCedula.Location = new System.Drawing.Point(50, 33);
            this.radioCedula.Name = "radioCedula";
            this.radioCedula.Size = new System.Drawing.Size(82, 24);
            this.radioCedula.TabIndex = 19;
            this.radioCedula.Text = "Cédula";
            this.radioCedula.UseVisualStyleBackColor = true;
            this.radioCedula.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(545, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 100);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo (*)";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(158, 46);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 24);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Femenino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(17, 46);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(106, 24);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panelInformación
            // 
            this.panelInformación.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInformación.Controls.Add(this.txtDireccion);
            this.panelInformación.Controls.Add(this.lbldireccion);
            this.panelInformación.Controls.Add(this.txtCorreo);
            this.panelInformación.Controls.Add(this.txtProcedencia);
            this.panelInformación.Controls.Add(this.txtTelefono2);
            this.panelInformación.Controls.Add(this.txtApellido2);
            this.panelInformación.Controls.Add(this.txtNombre2);
            this.panelInformación.Controls.Add(this.txtEstadoCivil);
            this.panelInformación.Controls.Add(this.txtNombre1);
            this.panelInformación.Controls.Add(this.txtApellido1);
            this.panelInformación.Controls.Add(this.txtTelefono1);
            this.panelInformación.Controls.Add(this.txtNacionalidad);
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
            this.panelInformación.Location = new System.Drawing.Point(43, 147);
            this.panelInformación.Name = "panelInformación";
            this.panelInformación.Size = new System.Drawing.Size(785, 372);
            this.panelInformación.TabIndex = 60;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(197, 320);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(172, 22);
            this.txtDireccion.TabIndex = 120;
            this.txtDireccion.Validar = false;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.Location = new System.Drawing.Point(58, 320);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(86, 40);
            this.lbldireccion.TabIndex = 119;
            this.lbldireccion.Text = "Dirección \r\nDomicilio";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.Window;
            this.txtCorreo.Location = new System.Drawing.Point(562, 268);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(172, 22);
            this.txtCorreo.TabIndex = 118;
            this.txtCorreo.Validar = false;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            // 
            // txtProcedencia
            // 
            this.txtProcedencia.Location = new System.Drawing.Point(562, 213);
            this.txtProcedencia.Name = "txtProcedencia";
            this.txtProcedencia.Size = new System.Drawing.Size(173, 22);
            this.txtProcedencia.TabIndex = 117;
            this.txtProcedencia.Validar = false;
            this.txtProcedencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProcedencia_KeyPress);
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.Location = new System.Drawing.Point(563, 144);
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Size = new System.Drawing.Size(171, 22);
            this.txtTelefono2.TabIndex = 116;
            this.txtTelefono2.Validar = false;
            this.txtTelefono2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono2_KeyPress);
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(562, 81);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(172, 22);
            this.txtApellido2.TabIndex = 115;
            this.txtApellido2.Validar = false;
            this.txtApellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido2_KeyPress);
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(562, 31);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(172, 22);
            this.txtNombre2.TabIndex = 114;
            this.txtNombre2.Validar = false;
            this.txtNombre2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre2_KeyPress);
            // 
            // txtEstadoCivil
            // 
            this.txtEstadoCivil.Location = new System.Drawing.Point(197, 268);
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.Size = new System.Drawing.Size(172, 22);
            this.txtEstadoCivil.TabIndex = 113;
            this.txtEstadoCivil.Validar = false;
            this.txtEstadoCivil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstadoCivil_KeyPress);
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(197, 26);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(172, 22);
            this.txtNombre1.TabIndex = 112;
            this.txtNombre1.Validar = true;
            this.txtNombre1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre1_KeyPress);
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(197, 81);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(172, 22);
            this.txtApellido1.TabIndex = 111;
            this.txtApellido1.Validar = true;
            this.txtApellido1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido1_KeyPress);
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.Location = new System.Drawing.Point(197, 140);
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.Size = new System.Drawing.Size(172, 22);
            this.txtTelefono1.TabIndex = 110;
            this.txtTelefono1.Validar = true;
            this.txtTelefono1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono1_KeyPress);
            this.txtTelefono1.Leave += new System.EventHandler(this.txtTelefono1_Leave);
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(197, 210);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(172, 22);
            this.txtNacionalidad.TabIndex = 109;
            this.txtNacionalidad.Validar = true;
            this.txtNacionalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNacionalidad_KeyPress);
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(416, 268);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(93, 40);
            this.labelCorreo.TabIndex = 108;
            this.labelCorreo.Text = "Correo \r\nElectrónico";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.Location = new System.Drawing.Point(46, 266);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(98, 20);
            this.lblEstadoCivil.TabIndex = 107;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidad.Location = new System.Drawing.Point(46, 212);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(128, 20);
            this.lblNacionalidad.TabIndex = 106;
            this.lblNacionalidad.Text = "Nacionalidad (*)";
            // 
            // labelProcedencia
            // 
            this.labelProcedencia.AutoSize = true;
            this.labelProcedencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcedencia.Location = new System.Drawing.Point(417, 202);
            this.labelProcedencia.Name = "labelProcedencia";
            this.labelProcedencia.Size = new System.Drawing.Size(107, 40);
            this.labelProcedencia.TabIndex = 105;
            this.labelProcedencia.Text = "Lugar de \r\nProcedencia ";
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre1.Location = new System.Drawing.Point(46, 26);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(110, 20);
            this.lblNombre1.TabIndex = 99;
            this.lblNombre1.Text = " Nombre 1 (*)";
            this.lblNombre1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelNombre2
            // 
            this.labelNombre2.AutoSize = true;
            this.labelNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre2.Location = new System.Drawing.Point(417, 26);
            this.labelNombre2.Name = "labelNombre2";
            this.labelNombre2.Size = new System.Drawing.Size(82, 20);
            this.labelNombre2.TabIndex = 102;
            this.labelNombre2.Text = "Nombre 2";
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido1.Location = new System.Drawing.Point(46, 83);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(105, 20);
            this.lblApellido1.TabIndex = 100;
            this.lblApellido1.Text = "Apellido 1 (*)";
            this.lblApellido1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido2.Location = new System.Drawing.Point(417, 83);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(82, 20);
            this.lblApellido2.TabIndex = 101;
            this.lblApellido2.Text = "Apellido 2";
            // 
            // lbltelefono2
            // 
            this.lbltelefono2.AutoSize = true;
            this.lbltelefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono2.Location = new System.Drawing.Point(417, 144);
            this.lbltelefono2.Name = "lbltelefono2";
            this.lbltelefono2.Size = new System.Drawing.Size(92, 20);
            this.lbltelefono2.TabIndex = 104;
            this.lbltelefono2.Text = "Teléfono 2 ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(46, 142);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(110, 20);
            this.lblTelefono.TabIndex = 103;
            this.lblTelefono.Text = "Teléfono 1 (*)";
            // 
            // FormIngresarNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(876, 642);
            this.Controls.Add(this.panelInformación);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDocumento);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormIngresarNuevoCliente";
            this.Text = "FormIngresarNuevoCliente";
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.GroupBox groupBoxDocumento;
        private Libreria.ErrorTxtBox txtDocumento;
        private System.Windows.Forms.RadioButton radioPasaporte;
        private System.Windows.Forms.RadioButton radioCedula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panelInformación;
        private Libreria.ErrorTxtBox txtCorreo;
        private Libreria.ErrorTxtBox txtProcedencia;
        private Libreria.ErrorTxtBox txtTelefono2;
        private Libreria.ErrorTxtBox txtApellido2;
        private Libreria.ErrorTxtBox txtNombre2;
        private Libreria.ErrorTxtBox txtEstadoCivil;
        private Libreria.ErrorTxtBox txtNombre1;
        private Libreria.ErrorTxtBox txtApellido1;
        private Libreria.ErrorTxtBox txtTelefono1;
        private Libreria.ErrorTxtBox txtNacionalidad;
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
        private Libreria.ErrorTxtBox txtDireccion;
    }
}