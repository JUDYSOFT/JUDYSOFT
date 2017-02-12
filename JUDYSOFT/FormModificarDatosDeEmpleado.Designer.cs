namespace JUDYSOFT
{
    partial class FormModificarDatosDeEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarDatosDeEmpleado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxCargo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaDeEntrada = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSalario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxCelular = new System.Windows.Forms.TextBox();
            this.textBoxTelefonoConvencional = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.textBoxCorreoElectronico = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxProvincia = new System.Windows.Forms.ComboBox();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelObligatorios = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 485);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.labelObligatorios);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(14, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 410);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBoxCargo);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.dateTimePickerFechaDeEntrada);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.textBoxSalario);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(5, 230);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(756, 77);
            this.panel4.TabIndex = 96;
            // 
            // comboBoxCargo
            // 
            this.comboBoxCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCargo.FormattingEnabled = true;
            this.comboBoxCargo.Items.AddRange(new object[] {
            "Administrador",
            "Recepcionista",
            "Limpieza"});
            this.comboBoxCargo.Location = new System.Drawing.Point(462, 22);
            this.comboBoxCargo.Name = "comboBoxCargo";
            this.comboBoxCargo.Size = new System.Drawing.Size(256, 21);
            this.comboBoxCargo.TabIndex = 99;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(459, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 98;
            this.label14.Text = "Cargo (*)";
            // 
            // dateTimePickerFechaDeEntrada
            // 
            this.dateTimePickerFechaDeEntrada.CalendarMonthBackground = System.Drawing.Color.Moccasin;
            this.dateTimePickerFechaDeEntrada.Enabled = false;
            this.dateTimePickerFechaDeEntrada.Location = new System.Drawing.Point(20, 23);
            this.dateTimePickerFechaDeEntrada.Name = "dateTimePickerFechaDeEntrada";
            this.dateTimePickerFechaDeEntrada.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaDeEntrada.TabIndex = 97;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 96;
            this.label13.Text = "Fecha de entrada";
            // 
            // textBoxSalario
            // 
            this.textBoxSalario.BackColor = System.Drawing.Color.Moccasin;
            this.textBoxSalario.Location = new System.Drawing.Point(251, 23);
            this.textBoxSalario.Name = "textBoxSalario";
            this.textBoxSalario.Size = new System.Drawing.Size(177, 20);
            this.textBoxSalario.TabIndex = 95;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(251, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 94;
            this.label12.Text = "Salario (*)";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxCelular);
            this.panel3.Controls.Add(this.textBoxTelefonoConvencional);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dateTimePickerFechaDeNacimiento);
            this.panel3.Controls.Add(this.textBoxCorreoElectronico);
            this.panel3.Controls.Add(this.textBoxDireccion);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.comboBoxProvincia);
            this.panel3.Controls.Add(this.textBoxCiudad);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textBoxApellidos);
            this.panel3.Controls.Add(this.textBoxNombres);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(5, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 220);
            this.panel3.TabIndex = 95;
            // 
            // textBoxCelular
            // 
            this.textBoxCelular.BackColor = System.Drawing.Color.Moccasin;
            this.textBoxCelular.Location = new System.Drawing.Point(250, 187);
            this.textBoxCelular.Name = "textBoxCelular";
            this.textBoxCelular.Size = new System.Drawing.Size(177, 20);
            this.textBoxCelular.TabIndex = 105;
            // 
            // textBoxTelefonoConvencional
            // 
            this.textBoxTelefonoConvencional.BackColor = System.Drawing.Color.Moccasin;
            this.textBoxTelefonoConvencional.Location = new System.Drawing.Point(16, 187);
            this.textBoxTelefonoConvencional.Name = "textBoxTelefonoConvencional";
            this.textBoxTelefonoConvencional.Size = new System.Drawing.Size(200, 20);
            this.textBoxTelefonoConvencional.TabIndex = 104;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 103;
            this.label7.Text = "Teléfono 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 102;
            this.label6.Text = "Teléfono 1 (*)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(241, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 13);
            this.label17.TabIndex = 101;
            this.label17.Text = "Correo Electrónico (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Fecha de Nacimiento";
            // 
            // dateTimePickerFechaDeNacimiento
            // 
            this.dateTimePickerFechaDeNacimiento.CalendarMonthBackground = System.Drawing.Color.Moccasin;
            this.dateTimePickerFechaDeNacimiento.Enabled = false;
            this.dateTimePickerFechaDeNacimiento.Location = new System.Drawing.Point(17, 140);
            this.dateTimePickerFechaDeNacimiento.Name = "dateTimePickerFechaDeNacimiento";
            this.dateTimePickerFechaDeNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaDeNacimiento.TabIndex = 99;
            // 
            // textBoxCorreoElectronico
            // 
            this.textBoxCorreoElectronico.BackColor = System.Drawing.Color.Moccasin;
            this.textBoxCorreoElectronico.Location = new System.Drawing.Point(244, 140);
            this.textBoxCorreoElectronico.Name = "textBoxCorreoElectronico";
            this.textBoxCorreoElectronico.Size = new System.Drawing.Size(177, 20);
            this.textBoxCorreoElectronico.TabIndex = 98;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.BackColor = System.Drawing.Color.Moccasin;
            this.textBoxDireccion.Location = new System.Drawing.Point(460, 81);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(255, 20);
            this.textBoxDireccion.TabIndex = 94;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(456, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 93;
            this.label11.Text = "Dirección ";
            // 
            // comboBoxProvincia
            // 
            this.comboBoxProvincia.BackColor = System.Drawing.Color.Moccasin;
            this.comboBoxProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvincia.Enabled = false;
            this.comboBoxProvincia.FormattingEnabled = true;
            this.comboBoxProvincia.Location = new System.Drawing.Point(17, 81);
            this.comboBoxProvincia.Name = "comboBoxProvincia";
            this.comboBoxProvincia.Size = new System.Drawing.Size(200, 21);
            this.comboBoxProvincia.TabIndex = 92;
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.BackColor = System.Drawing.Color.Moccasin;
            this.textBoxCiudad.Enabled = false;
            this.textBoxCiudad.Location = new System.Drawing.Point(251, 81);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(177, 20);
            this.textBoxCiudad.TabIndex = 91;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(250, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 90;
            this.label10.Text = "Ciudad ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "Provincia ";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.BackColor = System.Drawing.Color.Moccasin;
            this.textBoxApellidos.Enabled = false;
            this.textBoxApellidos.Location = new System.Drawing.Point(251, 19);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(177, 20);
            this.textBoxApellidos.TabIndex = 86;
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.BackColor = System.Drawing.Color.Moccasin;
            this.textBoxNombres.Enabled = false;
            this.textBoxNombres.Location = new System.Drawing.Point(17, 19);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombres.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Nombres";
            // 
            // labelObligatorios
            // 
            this.labelObligatorios.AutoSize = true;
            this.labelObligatorios.ForeColor = System.Drawing.Color.Red;
            this.labelObligatorios.Location = new System.Drawing.Point(29, 341);
            this.labelObligatorios.Name = "labelObligatorios";
            this.labelObligatorios.Size = new System.Drawing.Size(251, 13);
            this.labelObligatorios.TabIndex = 94;
            this.labelObligatorios.Text = "Campos con (*) deben ser llenados obligatoriamente";
            this.labelObligatorios.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 23);
            this.button2.TabIndex = 88;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 87;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese cedula o pasaporte del empleado";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Moccasin;
            this.textBox1.Location = new System.Drawing.Point(38, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 20);
            this.textBox1.TabIndex = 0;
            // 
            // FormModificarDatosDeEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(789, 486);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModificarDatosDeEmpleado";
            this.Text = "Modificar datos de Empleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormModificarDatosDeEmpleado_FormClosing);
            this.Load += new System.EventHandler(this.FormModificarDatosDeEmpleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxProvincia;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBoxCargo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDeEntrada;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSalario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxCelular;
        private System.Windows.Forms.TextBox textBoxTelefonoConvencional;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDeNacimiento;
        private System.Windows.Forms.TextBox textBoxCorreoElectronico;
        public System.Windows.Forms.Label labelObligatorios;
    }
}