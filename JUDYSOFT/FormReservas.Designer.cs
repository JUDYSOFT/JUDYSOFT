﻿namespace JUDYSOFT
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
            this.btnCancelarReservaReservaciones = new System.Windows.Forms.Button();
            this.btnNuevaReservaReservaciones = new System.Windows.Forms.Button();
            this.btnConsultarReservasPasadasReservaciones = new System.Windows.Forms.Button();
            this.btnConsultarReservaciones = new System.Windows.Forms.Button();
            this.tablaReservaciones = new System.Windows.Forms.DataGridView();
            this.lblFuturasReservasReservaciones = new System.Windows.Forms.Label();
            this.btnSalirReservaciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarReservaReservaciones
            // 
            this.btnCancelarReservaReservaciones.Location = new System.Drawing.Point(215, 297);
            this.btnCancelarReservaReservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarReservaReservaciones.Name = "btnCancelarReservaReservaciones";
            this.btnCancelarReservaReservaciones.Size = new System.Drawing.Size(136, 30);
            this.btnCancelarReservaReservaciones.TabIndex = 13;
            this.btnCancelarReservaReservaciones.Text = "Cancelar Reserva";
            this.btnCancelarReservaReservaciones.UseVisualStyleBackColor = true;
            this.btnCancelarReservaReservaciones.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnNuevaReservaReservaciones
            // 
            this.btnNuevaReservaReservaciones.Location = new System.Drawing.Point(415, 297);
            this.btnNuevaReservaReservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevaReservaReservaciones.Name = "btnNuevaReservaReservaciones";
            this.btnNuevaReservaReservaciones.Size = new System.Drawing.Size(125, 30);
            this.btnNuevaReservaReservaciones.TabIndex = 12;
            this.btnNuevaReservaReservaciones.Text = "Nueva Reserva";
            this.btnNuevaReservaReservaciones.UseVisualStyleBackColor = true;
            this.btnNuevaReservaReservaciones.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnConsultarReservasPasadasReservaciones
            // 
            this.btnConsultarReservasPasadasReservaciones.Location = new System.Drawing.Point(503, 33);
            this.btnConsultarReservasPasadasReservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarReservasPasadasReservaciones.Name = "btnConsultarReservasPasadasReservaciones";
            this.btnConsultarReservasPasadasReservaciones.Size = new System.Drawing.Size(223, 33);
            this.btnConsultarReservasPasadasReservaciones.TabIndex = 11;
            this.btnConsultarReservasPasadasReservaciones.Text = "Consultar Reservas Pasadas";
            this.btnConsultarReservasPasadasReservaciones.UseVisualStyleBackColor = true;
            this.btnConsultarReservasPasadasReservaciones.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnConsultarReservaciones
            // 
            this.btnConsultarReservaciones.Location = new System.Drawing.Point(32, 297);
            this.btnConsultarReservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarReservaciones.Name = "btnConsultarReservaciones";
            this.btnConsultarReservaciones.Size = new System.Drawing.Size(123, 30);
            this.btnConsultarReservaciones.TabIndex = 10;
            this.btnConsultarReservaciones.Text = "Consultar";
            this.btnConsultarReservaciones.UseVisualStyleBackColor = true;
            this.btnConsultarReservaciones.Click += new System.EventHandler(this.button2_Click);
            // 
            // tablaReservaciones
            // 
            this.tablaReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaReservaciones.Location = new System.Drawing.Point(29, 74);
            this.tablaReservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaReservaciones.Name = "tablaReservaciones";
            this.tablaReservaciones.RowTemplate.Height = 24;
            this.tablaReservaciones.Size = new System.Drawing.Size(696, 199);
            this.tablaReservaciones.TabIndex = 9;
            // 
            // lblFuturasReservasReservaciones
            // 
            this.lblFuturasReservasReservaciones.AutoSize = true;
            this.lblFuturasReservasReservaciones.Location = new System.Drawing.Point(29, 49);
            this.lblFuturasReservasReservaciones.Name = "lblFuturasReservasReservaciones";
            this.lblFuturasReservasReservaciones.Size = new System.Drawing.Size(120, 17);
            this.lblFuturasReservasReservaciones.TabIndex = 8;
            this.lblFuturasReservasReservaciones.Text = "Futuras Reservas";
            // 
            // btnSalirReservaciones
            // 
            this.btnSalirReservaciones.Location = new System.Drawing.Point(588, 297);
            this.btnSalirReservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalirReservaciones.Name = "btnSalirReservaciones";
            this.btnSalirReservaciones.Size = new System.Drawing.Size(137, 30);
            this.btnSalirReservaciones.TabIndex = 7;
            this.btnSalirReservaciones.Text = "Salir";
            this.btnSalirReservaciones.UseVisualStyleBackColor = true;
            this.btnSalirReservaciones.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 361);
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