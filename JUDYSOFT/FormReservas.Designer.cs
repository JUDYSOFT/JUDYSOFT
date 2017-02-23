namespace JUDYSOFT
{
    partial class FormReservas
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
            this.btnConsultarReservasPasadasReservaciones = new System.Windows.Forms.Button();
            this.tablaReservaciones = new System.Windows.Forms.DataGridView();
            this.lblFuturasReservasReservaciones = new System.Windows.Forms.Label();
            this.btnCancelarReservaReservaciones = new System.Windows.Forms.Button();
            this.btnNuevaReservaReservaciones = new System.Windows.Forms.Button();
            this.btnConsultarReservaciones = new System.Windows.Forms.Button();
            this.btnSalirReservaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultarReservasPasadasReservaciones
            // 
            this.btnConsultarReservasPasadasReservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarReservasPasadasReservaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarReservasPasadasReservaciones.Location = new System.Drawing.Point(472, 14);
            this.btnConsultarReservasPasadasReservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarReservasPasadasReservaciones.Name = "btnConsultarReservasPasadasReservaciones";
            this.btnConsultarReservasPasadasReservaciones.Size = new System.Drawing.Size(253, 53);
            this.btnConsultarReservasPasadasReservaciones.TabIndex = 11;
            this.btnConsultarReservasPasadasReservaciones.Text = "Consultar Reservas Pasadas";
            this.btnConsultarReservasPasadasReservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarReservasPasadasReservaciones.UseVisualStyleBackColor = true;
            this.btnConsultarReservasPasadasReservaciones.Click += new System.EventHandler(this.button3_Click);
            // 
            // tablaReservaciones
            // 
            this.tablaReservaciones.AllowUserToAddRows = false;
            this.tablaReservaciones.AllowUserToDeleteRows = false;
            this.tablaReservaciones.AllowUserToOrderColumns = true;
            this.tablaReservaciones.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tablaReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaReservaciones.Location = new System.Drawing.Point(29, 74);
            this.tablaReservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaReservaciones.MultiSelect = false;
            this.tablaReservaciones.Name = "tablaReservaciones";
            this.tablaReservaciones.ReadOnly = true;
            this.tablaReservaciones.RowTemplate.Height = 24;
            this.tablaReservaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaReservaciones.Size = new System.Drawing.Size(696, 199);
            this.tablaReservaciones.TabIndex = 9;
            this.tablaReservaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaReservaciones_CellContentClick);
            // 
            // lblFuturasReservasReservaciones
            // 
            this.lblFuturasReservasReservaciones.AutoSize = true;
            this.lblFuturasReservasReservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuturasReservasReservaciones.Location = new System.Drawing.Point(29, 49);
            this.lblFuturasReservasReservaciones.Name = "lblFuturasReservasReservaciones";
            this.lblFuturasReservasReservaciones.Size = new System.Drawing.Size(156, 24);
            this.lblFuturasReservasReservaciones.TabIndex = 8;
            this.lblFuturasReservasReservaciones.Text = "Futuras Reservas";
            // 
            // btnCancelarReservaReservaciones
            // 
            this.btnCancelarReservaReservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarReservaReservaciones.Image = global::JUDYSOFT.Properties.Resources._1484546297_Cancel;
            this.btnCancelarReservaReservaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarReservaReservaciones.Location = new System.Drawing.Point(216, 313);
            this.btnCancelarReservaReservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarReservaReservaciones.Name = "btnCancelarReservaReservaciones";
            this.btnCancelarReservaReservaciones.Size = new System.Drawing.Size(173, 71);
            this.btnCancelarReservaReservaciones.TabIndex = 13;
            this.btnCancelarReservaReservaciones.Text = "Cancelar Reserva";
            this.btnCancelarReservaReservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarReservaReservaciones.UseVisualStyleBackColor = true;
            this.btnCancelarReservaReservaciones.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnNuevaReservaReservaciones
            // 
            this.btnNuevaReservaReservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaReservaReservaciones.Image = global::JUDYSOFT.Properties.Resources._1484548508_Pencil1;
            this.btnNuevaReservaReservaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaReservaReservaciones.Location = new System.Drawing.Point(411, 313);
            this.btnNuevaReservaReservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevaReservaReservaciones.Name = "btnNuevaReservaReservaciones";
            this.btnNuevaReservaReservaciones.Size = new System.Drawing.Size(155, 71);
            this.btnNuevaReservaReservaciones.TabIndex = 12;
            this.btnNuevaReservaReservaciones.Text = "Nueva Reserva";
            this.btnNuevaReservaReservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevaReservaReservaciones.UseVisualStyleBackColor = true;
            this.btnNuevaReservaReservaciones.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnConsultarReservaciones
            // 
            this.btnConsultarReservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarReservaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarReservaciones.Location = new System.Drawing.Point(29, 313);
            this.btnConsultarReservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarReservaciones.Name = "btnConsultarReservaciones";
            this.btnConsultarReservaciones.Size = new System.Drawing.Size(167, 71);
            this.btnConsultarReservaciones.TabIndex = 10;
            this.btnConsultarReservaciones.Text = "Consultar";
            this.btnConsultarReservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarReservaciones.UseVisualStyleBackColor = true;
            this.btnConsultarReservaciones.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalirReservaciones
            // 
            this.btnSalirReservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirReservaciones.Image = global::JUDYSOFT.Properties.Resources._1484546336_Back1;
            this.btnSalirReservaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirReservaciones.Location = new System.Drawing.Point(588, 313);
            this.btnSalirReservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalirReservaciones.Name = "btnSalirReservaciones";
            this.btnSalirReservaciones.Size = new System.Drawing.Size(137, 71);
            this.btnSalirReservaciones.TabIndex = 7;
            this.btnSalirReservaciones.Text = "Salir";
            this.btnSalirReservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirReservaciones.UseVisualStyleBackColor = true;
            this.btnSalirReservaciones.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(749, 398);
            this.Controls.Add(this.btnCancelarReservaReservaciones);
            this.Controls.Add(this.btnNuevaReservaReservaciones);
            this.Controls.Add(this.btnConsultarReservasPasadasReservaciones);
            this.Controls.Add(this.btnConsultarReservaciones);
            this.Controls.Add(this.tablaReservaciones);
            this.Controls.Add(this.lblFuturasReservasReservaciones);
            this.Controls.Add(this.btnSalirReservaciones);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormReservas";
            this.Text = "Reservaciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReservas_FormClosed);
            this.Load += new System.EventHandler(this.FormReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarReservaReservaciones;
        private System.Windows.Forms.Button btnNuevaReservaReservaciones;
        public System.Windows.Forms.Button btnConsultarReservasPasadasReservaciones;
        private System.Windows.Forms.Button btnConsultarReservaciones;
        private System.Windows.Forms.DataGridView tablaReservaciones;
        private System.Windows.Forms.Label lblFuturasReservasReservaciones;
        private System.Windows.Forms.Button btnSalirReservaciones;
    }
}