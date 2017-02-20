namespace JUDYSOFT
{
    partial class FormListaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaClientes));
            this.dataGridViewModificarClientes = new System.Windows.Forms.DataGridView();
            this.bttnSeleccionar = new System.Windows.Forms.Button();
            this.bttmCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificarClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewModificarClientes
            // 
            this.dataGridViewModificarClientes.AllowUserToAddRows = false;
            this.dataGridViewModificarClientes.AllowUserToDeleteRows = false;
            this.dataGridViewModificarClientes.AllowUserToResizeColumns = false;
            this.dataGridViewModificarClientes.AllowUserToResizeRows = false;
            this.dataGridViewModificarClientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewModificarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModificarClientes.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewModificarClientes.Name = "dataGridViewModificarClientes";
            this.dataGridViewModificarClientes.ReadOnly = true;
            this.dataGridViewModificarClientes.Size = new System.Drawing.Size(645, 164);
            this.dataGridViewModificarClientes.TabIndex = 0;
            this.dataGridViewModificarClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bttnSeleccionar
            // 
            this.bttnSeleccionar.Location = new System.Drawing.Point(220, 221);
            this.bttnSeleccionar.Name = "bttnSeleccionar";
            this.bttnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.bttnSeleccionar.TabIndex = 1;
            this.bttnSeleccionar.Text = "Seleccionar";
            this.bttnSeleccionar.UseVisualStyleBackColor = true;
            this.bttnSeleccionar.Click += new System.EventHandler(this.bttnSeleccionar_Click);
            // 
            // bttmCancelar
            // 
            this.bttmCancelar.Location = new System.Drawing.Point(397, 221);
            this.bttmCancelar.Name = "bttmCancelar";
            this.bttmCancelar.Size = new System.Drawing.Size(75, 23);
            this.bttmCancelar.TabIndex = 2;
            this.bttmCancelar.Text = "Cancelar";
            this.bttmCancelar.UseVisualStyleBackColor = true;
            this.bttmCancelar.Click += new System.EventHandler(this.bttmCancelar_Click);
            // 
            // FormListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(669, 257);
            this.ControlBox = false;
            this.Controls.Add(this.bttmCancelar);
            this.Controls.Add(this.bttnSeleccionar);
            this.Controls.Add(this.dataGridViewModificarClientes);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión CLIENTES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormListaClientes_FormClosing);
            this.Load += new System.EventHandler(this.FormListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificarClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewModificarClientes;
        private System.Windows.Forms.Button bttnSeleccionar;
        private System.Windows.Forms.Button bttmCancelar;
    }
}