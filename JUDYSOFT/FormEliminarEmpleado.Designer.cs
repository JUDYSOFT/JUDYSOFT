namespace JUDYSOFT
{
    partial class FormEliminarEmpleado
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
            this.panelEliminarEmpleado = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMarcoDatosSeleccionados = new System.Windows.Forms.Panel();
            this.panelSeleccion = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.panelMarcoTabla = new System.Windows.Forms.Panel();
            this.panelTablaCargo = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Identificación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMultiple = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panelInsertarId = new System.Windows.Forms.Panel();
            this.panelApellidosNombres = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.panelCedula = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelCargo = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panelEliminarEmpleado.SuspendLayout();
            this.panelMarcoDatosSeleccionados.SuspendLayout();
            this.panelSeleccion.SuspendLayout();
            this.panelMarcoTabla.SuspendLayout();
            this.panelTablaCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelMultiple.SuspendLayout();
            this.panelInsertarId.SuspendLayout();
            this.panelApellidosNombres.SuspendLayout();
            this.panelCedula.SuspendLayout();
            this.panelCargo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEliminarEmpleado
            // 
            this.panelEliminarEmpleado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelEliminarEmpleado.Controls.Add(this.button2);
            this.panelEliminarEmpleado.Controls.Add(this.button1);
            this.panelEliminarEmpleado.Controls.Add(this.panelMarcoDatosSeleccionados);
            this.panelEliminarEmpleado.Controls.Add(this.panelMarcoTabla);
            this.panelEliminarEmpleado.Controls.Add(this.panelInsertarId);
            this.panelEliminarEmpleado.Controls.Add(this.label17);
            this.panelEliminarEmpleado.Controls.Add(this.comboBox3);
            this.panelEliminarEmpleado.Location = new System.Drawing.Point(0, 1);
            this.panelEliminarEmpleado.Name = "panelEliminarEmpleado";
            this.panelEliminarEmpleado.Size = new System.Drawing.Size(775, 545);
            this.panelEliminarEmpleado.TabIndex = 3;
            this.panelEliminarEmpleado.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEliminarEmpleado_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(388, 493);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelMarcoDatosSeleccionados
            // 
            this.panelMarcoDatosSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMarcoDatosSeleccionados.Controls.Add(this.panelSeleccion);
            this.panelMarcoDatosSeleccionados.Location = new System.Drawing.Point(9, 378);
            this.panelMarcoDatosSeleccionados.Name = "panelMarcoDatosSeleccionados";
            this.panelMarcoDatosSeleccionados.Size = new System.Drawing.Size(735, 100);
            this.panelMarcoDatosSeleccionados.TabIndex = 10;
            this.panelMarcoDatosSeleccionados.Visible = false;
            // 
            // panelSeleccion
            // 
            this.panelSeleccion.Controls.Add(this.label1);
            this.panelSeleccion.Controls.Add(this.textBox11);
            this.panelSeleccion.Controls.Add(this.textBox10);
            this.panelSeleccion.Controls.Add(this.textBox9);
            this.panelSeleccion.Controls.Add(this.textBox8);
            this.panelSeleccion.Location = new System.Drawing.Point(16, 18);
            this.panelSeleccion.Name = "panelSeleccion";
            this.panelSeleccion.Size = new System.Drawing.Size(703, 64);
            this.panelSeleccion.TabIndex = 8;
            this.panelSeleccion.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datos del empleado seleccionado";
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(528, 27);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(151, 20);
            this.textBox11.TabIndex = 3;
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(362, 27);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(160, 20);
            this.textBox10.TabIndex = 2;
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(177, 27);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(179, 20);
            this.textBox9.TabIndex = 1;
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(13, 27);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(158, 20);
            this.textBox8.TabIndex = 0;
            // 
            // panelMarcoTabla
            // 
            this.panelMarcoTabla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMarcoTabla.Controls.Add(this.panelTablaCargo);
            this.panelMarcoTabla.Controls.Add(this.panelMultiple);
            this.panelMarcoTabla.Location = new System.Drawing.Point(9, 160);
            this.panelMarcoTabla.Name = "panelMarcoTabla";
            this.panelMarcoTabla.Size = new System.Drawing.Size(735, 195);
            this.panelMarcoTabla.TabIndex = 9;
            this.panelMarcoTabla.Visible = false;
            // 
            // panelTablaCargo
            // 
            this.panelTablaCargo.Controls.Add(this.dataGridView1);
            this.panelTablaCargo.Location = new System.Drawing.Point(7, 5);
            this.panelTablaCargo.Name = "panelTablaCargo";
            this.panelTablaCargo.Size = new System.Drawing.Size(703, 205);
            this.panelTablaCargo.TabIndex = 8;
            this.panelTablaCargo.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificación,
            this.Nombres,
            this.Apellidos,
            this.Cargo});
            this.dataGridView1.Location = new System.Drawing.Point(8, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 26;
            this.dataGridView1.Size = new System.Drawing.Size(690, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // Identificación
            // 
            this.Identificación.HeaderText = "Identificación";
            this.Identificación.Name = "Identificación";
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            // 
            // panelMultiple
            // 
            this.panelMultiple.Controls.Add(this.textBox6);
            this.panelMultiple.Controls.Add(this.textBox5);
            this.panelMultiple.Controls.Add(this.textBox4);
            this.panelMultiple.Controls.Add(this.textBox3);
            this.panelMultiple.Controls.Add(this.textBox2);
            this.panelMultiple.Controls.Add(this.label23);
            this.panelMultiple.Controls.Add(this.label22);
            this.panelMultiple.Controls.Add(this.label21);
            this.panelMultiple.Controls.Add(this.label20);
            this.panelMultiple.Controls.Add(this.label19);
            this.panelMultiple.Location = new System.Drawing.Point(7, -2);
            this.panelMultiple.Name = "panelMultiple";
            this.panelMultiple.Size = new System.Drawing.Size(703, 184);
            this.panelMultiple.TabIndex = 7;
            this.panelMultiple.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(370, 133);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(296, 20);
            this.textBox6.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(16, 133);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(296, 20);
            this.textBox5.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(371, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(295, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(16, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(296, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(16, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(296, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(368, 119);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 13);
            this.label23.TabIndex = 4;
            this.label23.Text = "Teléfono";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 119);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Correo electrónico";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Identificación";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(368, 65);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Apellidos";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 65);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Nombres";
            // 
            // panelInsertarId
            // 
            this.panelInsertarId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInsertarId.Controls.Add(this.panelApellidosNombres);
            this.panelInsertarId.Controls.Add(this.panelCedula);
            this.panelInsertarId.Controls.Add(this.panelCargo);
            this.panelInsertarId.Location = new System.Drawing.Point(9, 53);
            this.panelInsertarId.Name = "panelInsertarId";
            this.panelInsertarId.Size = new System.Drawing.Size(735, 100);
            this.panelInsertarId.TabIndex = 8;
            this.panelInsertarId.Visible = false;
            // 
            // panelApellidosNombres
            // 
            this.panelApellidosNombres.Controls.Add(this.textBox7);
            this.panelApellidosNombres.Controls.Add(this.label24);
            this.panelApellidosNombres.Location = new System.Drawing.Point(2, 8);
            this.panelApellidosNombres.Name = "panelApellidosNombres";
            this.panelApellidosNombres.Size = new System.Drawing.Size(682, 79);
            this.panelApellidosNombres.TabIndex = 7;
            this.panelApellidosNombres.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(16, 33);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(299, 20);
            this.textBox7.TabIndex = 1;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(13, 7);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(137, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Inserte Apellidos y Nombres";
            // 
            // panelCedula
            // 
            this.panelCedula.Controls.Add(this.label18);
            this.panelCedula.Controls.Add(this.textBox1);
            this.panelCedula.Location = new System.Drawing.Point(-1, 8);
            this.panelCedula.Name = "panelCedula";
            this.panelCedula.Size = new System.Drawing.Size(672, 70);
            this.panelCedula.TabIndex = 6;
            this.panelCedula.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Inserte cédula";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_TextChanged);
            // 
            // panelCargo
            // 
            this.panelCargo.Controls.Add(this.comboBox1);
            this.panelCargo.Controls.Add(this.label25);
            this.panelCargo.Location = new System.Drawing.Point(17, 8);
            this.panelCargo.Name = "panelCargo";
            this.panelCargo.Size = new System.Drawing.Size(691, 85);
            this.panelCargo.TabIndex = 8;
            this.panelCargo.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Recepcionista",
            "Limpieza"});
            this.comboBox1.Location = new System.Drawing.Point(12, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(9, 10);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(101, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Seleccione el cargo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(165, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Seleccione el modo de busqueda";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Cédula",
            "Apellidos y Nombres",
            "Cargo"});
            this.comboBox3.Location = new System.Drawing.Point(21, 25);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(300, 21);
            this.comboBox3.TabIndex = 0;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // FormEliminarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(775, 542);
            this.Controls.Add(this.panelEliminarEmpleado);
            this.Name = "FormEliminarEmpleado";
            this.Text = "Eliminar Empleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEliminarEmpleado_FormClosing);
            this.panelEliminarEmpleado.ResumeLayout(false);
            this.panelEliminarEmpleado.PerformLayout();
            this.panelMarcoDatosSeleccionados.ResumeLayout(false);
            this.panelSeleccion.ResumeLayout(false);
            this.panelSeleccion.PerformLayout();
            this.panelMarcoTabla.ResumeLayout(false);
            this.panelTablaCargo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelMultiple.ResumeLayout(false);
            this.panelMultiple.PerformLayout();
            this.panelInsertarId.ResumeLayout(false);
            this.panelApellidosNombres.ResumeLayout(false);
            this.panelApellidosNombres.PerformLayout();
            this.panelCedula.ResumeLayout(false);
            this.panelCedula.PerformLayout();
            this.panelCargo.ResumeLayout(false);
            this.panelCargo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEliminarEmpleado;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Panel panelMarcoDatosSeleccionados;
        private System.Windows.Forms.Panel panelSeleccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Panel panelMarcoTabla;
        private System.Windows.Forms.Panel panelTablaCargo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.Panel panelMultiple;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panelInsertarId;
        private System.Windows.Forms.Panel panelCedula;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelApellidosNombres;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panelCargo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}