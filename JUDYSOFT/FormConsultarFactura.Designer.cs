namespace JUDYSOFT
{
    partial class FormConsultarFactura
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
            this.panelInsertarId = new System.Windows.Forms.Panel();
            this.panelApellidosNombres = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.panelCedula = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panelInsertarId.SuspendLayout();
            this.panelApellidosNombres.SuspendLayout();
            this.panelCedula.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInsertarId
            // 
            this.panelInsertarId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInsertarId.Controls.Add(this.panelApellidosNombres);
            this.panelInsertarId.Controls.Add(this.panelCedula);
            this.panelInsertarId.Location = new System.Drawing.Point(10, 55);
            this.panelInsertarId.Name = "panelInsertarId";
            this.panelInsertarId.Size = new System.Drawing.Size(735, 100);
            this.panelInsertarId.TabIndex = 11;
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
            this.textBox7.BackColor = System.Drawing.Color.Moccasin;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(16, 33);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(299, 24);
            this.textBox7.TabIndex = 1;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(13, 7);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(177, 16);
            this.label24.TabIndex = 0;
            this.label24.Text = "Inserte Apellidos y Nombres";
            // 
            // panelCedula
            // 
            this.panelCedula.Controls.Add(this.label18);
            this.panelCedula.Controls.Add(this.textBoxCedula);
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
            // textBoxCedula
            // 
            this.textBoxCedula.Location = new System.Drawing.Point(16, 26);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(302, 20);
            this.textBoxCedula.TabIndex = 0;
            this.textBoxCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCedula_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(19, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(211, 16);
            this.label17.TabIndex = 10;
            this.label17.Text = "Seleccione el modo de busqueda";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.Moccasin;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Cédula",
            "Apellidos y Nombres",
            "Cargo"});
            this.comboBox3.Location = new System.Drawing.Point(22, 27);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(300, 26);
            this.comboBox3.TabIndex = 9;
            // 
            // FormConsultarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(754, 481);
            this.Controls.Add(this.panelInsertarId);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboBox3);
            this.Name = "FormConsultarFactura";
            this.Text = "FormConsultarFactura";
            this.panelInsertarId.ResumeLayout(false);
            this.panelApellidosNombres.ResumeLayout(false);
            this.panelApellidosNombres.PerformLayout();
            this.panelCedula.ResumeLayout(false);
            this.panelCedula.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInsertarId;
        private System.Windows.Forms.Panel panelCedula;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.Panel panelApellidosNombres;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}