﻿namespace JUDYSOFT
{
    partial class FormIngresarNuevoEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIngresarNuevoEmpleado));
            this.panelNuevoEmpleado = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxCargo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaDeEntrada = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSalario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxCiudad = new System.Windows.Forms.ComboBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxProvincia = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCelular = new System.Windows.Forms.TextBox();
            this.textBoxTelefonoConvencional = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxIdentificacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTipoDeIdentificacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelNuevoEmpleado.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNuevoEmpleado
            // 
            this.panelNuevoEmpleado.AutoSize = true;
            this.panelNuevoEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.panelNuevoEmpleado.Controls.Add(this.panel3);
            this.panelNuevoEmpleado.Controls.Add(this.panel2);
            this.panelNuevoEmpleado.Controls.Add(this.panel1);
            this.panelNuevoEmpleado.Controls.Add(this.label16);
            this.panelNuevoEmpleado.Controls.Add(this.button2);
            this.panelNuevoEmpleado.Controls.Add(this.button1);
            this.panelNuevoEmpleado.Location = new System.Drawing.Point(4, 2);
            this.panelNuevoEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelNuevoEmpleado.Name = "panelNuevoEmpleado";
            this.panelNuevoEmpleado.Size = new System.Drawing.Size(1024, 542);
            this.panelNuevoEmpleado.TabIndex = 2;
            this.panelNuevoEmpleado.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNuevoEmpleado_Paint);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.comboBoxCargo);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.dateTimePickerFechaDeEntrada);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.textBoxSalario);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(13, 363);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(973, 78);
            this.panel3.TabIndex = 37;
            // 
            // comboBoxCargo
            // 
            this.comboBoxCargo.FormattingEnabled = true;
            this.comboBoxCargo.Items.AddRange(new object[] {
            "Administrador",
            "Recepcionista",
            "Limpieza"});
            this.comboBoxCargo.Location = new System.Drawing.Point(613, 23);
            this.comboBoxCargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCargo.Name = "comboBoxCargo";
            this.comboBoxCargo.Size = new System.Drawing.Size(340, 24);
            this.comboBoxCargo.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(609, 5);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "Cargo (*)";
            // 
            // dateTimePickerFechaDeEntrada
            // 
            this.dateTimePickerFechaDeEntrada.Location = new System.Drawing.Point(17, 23);
            this.dateTimePickerFechaDeEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerFechaDeEntrada.Name = "dateTimePickerFechaDeEntrada";
            this.dateTimePickerFechaDeEntrada.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerFechaDeEntrada.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 4);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 17);
            this.label13.TabIndex = 36;
            this.label13.Text = "Fecha de registro (*)";
            // 
            // textBoxSalario
            // 
            this.textBoxSalario.Location = new System.Drawing.Point(329, 23);
            this.textBoxSalario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSalario.Name = "textBoxSalario";
            this.textBoxSalario.Size = new System.Drawing.Size(235, 22);
            this.textBoxSalario.TabIndex = 35;
            this.textBoxSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSalario_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(332, 5);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 34;
            this.label12.Text = "Salario (*)";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.comboBoxCiudad);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.textBoxDireccion);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.comboBoxProvincia);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dateTimePickerFechaDeNacimiento);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxCelular);
            this.panel2.Controls.Add(this.textBoxTelefonoConvencional);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxCorreoElectronico);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxApellidos);
            this.panel2.Controls.Add(this.textBoxNombres);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 96);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 259);
            this.panel2.TabIndex = 36;
            // 
            // comboBoxCiudad
            // 
            this.comboBoxCiudad.FormattingEnabled = true;
            this.comboBoxCiudad.Location = new System.Drawing.Point(331, 92);
            this.comboBoxCiudad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCiudad.Name = "comboBoxCiudad";
            this.comboBoxCiudad.Size = new System.Drawing.Size(235, 24);
            this.comboBoxCiudad.TabIndex = 44;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(788, 30);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(91, 21);
            this.radioButton3.TabIndex = 43;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Femenino";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(615, 30);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 21);
            this.radioButton2.TabIndex = 42;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Masculino";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(611, 10);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 17);
            this.label17.TabIndex = 41;
            this.label17.Text = "Sexo";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(615, 92);
            this.textBoxDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(339, 22);
            this.textBoxDireccion.TabIndex = 40;
            this.textBoxDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDireccion_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(611, 73);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "Dirección (*)";
            // 
            // comboBoxProvincia
            // 
            this.comboBoxProvincia.FormattingEnabled = true;
            this.comboBoxProvincia.Items.AddRange(new object[] {
            "Azuay",
            "Bolivar",
            "Cañar",
            "Carchi",
            "Chimborazo",
            "Cotopaxi",
            "El Oro",
            "Esmeraldas",
            "Galápagos",
            "Guayas",
            "Imbabura",
            "Loja",
            "Los Rios",
            "Manabí",
            "Morona Santiago",
            "Napo",
            "Orellana",
            "Pastaza",
            "Pichincha",
            "Santa Elena",
            "Santo Domingo de los Tsáchilas",
            "Sucumbíos",
            "Tungurahua",
            "Zamora Chinchipe"});
            this.comboBoxProvincia.Location = new System.Drawing.Point(19, 92);
            this.comboBoxProvincia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxProvincia.Name = "comboBoxProvincia";
            this.comboBoxProvincia.Size = new System.Drawing.Size(265, 24);
            this.comboBoxProvincia.TabIndex = 38;
            this.comboBoxProvincia.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvincia_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(327, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "Ciudad (*)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 73);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Provincia (*)";
            // 
            // dateTimePickerFechaDeNacimiento
            // 
            this.dateTimePickerFechaDeNacimiento.Location = new System.Drawing.Point(19, 158);
            this.dateTimePickerFechaDeNacimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerFechaDeNacimiento.Name = "dateTimePickerFechaDeNacimiento";
            this.dateTimePickerFechaDeNacimiento.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerFechaDeNacimiento.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 138);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Fecha de nacimiento (*)";
            // 
            // textBoxCelular
            // 
            this.textBoxCelular.Location = new System.Drawing.Point(331, 217);
            this.textBoxCelular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCelular.Name = "textBoxCelular";
            this.textBoxCelular.Size = new System.Drawing.Size(235, 22);
            this.textBoxCelular.TabIndex = 32;
            this.textBoxCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCelular_TextChanged);
            // 
            // textBoxTelefonoConvencional
            // 
            this.textBoxTelefonoConvencional.Location = new System.Drawing.Point(19, 217);
            this.textBoxTelefonoConvencional.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTelefonoConvencional.Name = "textBoxTelefonoConvencional";
            this.textBoxTelefonoConvencional.Size = new System.Drawing.Size(265, 22);
            this.textBoxTelefonoConvencional.TabIndex = 31;
            this.textBoxTelefonoConvencional.TextChanged += new System.EventHandler(this.textBoxTelefonoConvencional_TextChanged);
            this.textBoxTelefonoConvencional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelefonoConvencional_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 197);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Teléfono 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Teléfono 1 (*)";
            // 
            // textBoxCorreoElectronico
            // 
            this.textBoxCorreoElectronico.Location = new System.Drawing.Point(331, 158);
            this.textBoxCorreoElectronico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCorreoElectronico.Name = "textBoxCorreoElectronico";
            this.textBoxCorreoElectronico.Size = new System.Drawing.Size(235, 22);
            this.textBoxCorreoElectronico.TabIndex = 28;
            this.textBoxCorreoElectronico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCorreoElectronico_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Correo Electrónico (*)";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(331, 26);
            this.textBoxApellidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(235, 22);
            this.textBoxApellidos.TabIndex = 26;
            this.textBoxApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellidos_TextChanged);
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(19, 26);
            this.textBoxNombres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(265, 22);
            this.textBoxNombres.TabIndex = 25;
            this.textBoxNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombres_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Apellidos (*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nombres (*)";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBoxIdentificacion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxTipoDeIdentificacion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 73);
            this.panel1.TabIndex = 35;
            // 
            // textBoxIdentificacion
            // 
            this.textBoxIdentificacion.Location = new System.Drawing.Point(331, 36);
            this.textBoxIdentificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIdentificacion.Name = "textBoxIdentificacion";
            this.textBoxIdentificacion.Size = new System.Drawing.Size(235, 22);
            this.textBoxIdentificacion.TabIndex = 7;
            this.textBoxIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdentificacion_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Identificación (*)";
            // 
            // comboBoxTipoDeIdentificacion
            // 
            this.comboBoxTipoDeIdentificacion.FormattingEnabled = true;
            this.comboBoxTipoDeIdentificacion.Items.AddRange(new object[] {
            "Cédula",
            "Pasaporte"});
            this.comboBoxTipoDeIdentificacion.Location = new System.Drawing.Point(19, 34);
            this.comboBoxTipoDeIdentificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTipoDeIdentificacion.Name = "comboBoxTipoDeIdentificacion";
            this.comboBoxTipoDeIdentificacion.Size = new System.Drawing.Size(265, 24);
            this.comboBoxTipoDeIdentificacion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de Identificación";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(29, 446);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(339, 17);
            this.label16.TabIndex = 34;
            this.label16.Text = "Campos con (*) deben ser llenados obligatoriamente";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(491, 481);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 28);
            this.button2.TabIndex = 28;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 481);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 28);
            this.button1.TabIndex = 27;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormIngresarNuevoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 551);
            this.Controls.Add(this.panelNuevoEmpleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIngresarNuevoEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Nuevo Empleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIngresarNuevoEmpleado_FormClosing);
            this.Load += new System.EventHandler(this.FormIngresarNuevoEmpleado_Load);
            this.panelNuevoEmpleado.ResumeLayout(false);
            this.panelNuevoEmpleado.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNuevoEmpleado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxIdentificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTipoDeIdentificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxCargo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDeEntrada;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSalario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxProvincia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDeNacimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCelular;
        private System.Windows.Forms.TextBox textBoxTelefonoConvencional;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCorreoElectronico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBoxCiudad;
    }
}