﻿namespace JUDYSOFT
{
    partial class reservacionesPasadas
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
            this.tablaReservacionesPasadas = new System.Windows.Forms.DataGridView();
            this.btnAtrasReservacionesPasadas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservacionesPasadas)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaReservacionesPasadas
            // 
            this.tablaReservacionesPasadas.AllowUserToAddRows = false;
            this.tablaReservacionesPasadas.AllowUserToDeleteRows = false;
            this.tablaReservacionesPasadas.AllowUserToOrderColumns = true;
            this.tablaReservacionesPasadas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tablaReservacionesPasadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaReservacionesPasadas.Location = new System.Drawing.Point(23, 16);
            this.tablaReservacionesPasadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaReservacionesPasadas.Name = "tablaReservacionesPasadas";
            this.tablaReservacionesPasadas.ReadOnly = true;
            this.tablaReservacionesPasadas.RowTemplate.Height = 24;
            this.tablaReservacionesPasadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaReservacionesPasadas.Size = new System.Drawing.Size(511, 377);
            this.tablaReservacionesPasadas.TabIndex = 3;
            this.tablaReservacionesPasadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaReservacionesPasadas_CellContentClick);
            // 
            // btnAtrasReservacionesPasadas
            // 
            this.btnAtrasReservacionesPasadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrasReservacionesPasadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtrasReservacionesPasadas.Location = new System.Drawing.Point(384, 411);
            this.btnAtrasReservacionesPasadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtrasReservacionesPasadas.Name = "btnAtrasReservacionesPasadas";
            this.btnAtrasReservacionesPasadas.Size = new System.Drawing.Size(149, 53);
            this.btnAtrasReservacionesPasadas.TabIndex = 5;
            this.btnAtrasReservacionesPasadas.Text = "Atrás";
            this.btnAtrasReservacionesPasadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtrasReservacionesPasadas.UseVisualStyleBackColor = true;
            this.btnAtrasReservacionesPasadas.Click += new System.EventHandler(this.button2_Click);
            // 
            // reservacionesPasadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(573, 478);
            this.Controls.Add(this.btnAtrasReservacionesPasadas);
            this.Controls.Add(this.tablaReservacionesPasadas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "reservacionesPasadas";
            this.Text = "Reservaciones Pasadas";
            this.Load += new System.EventHandler(this.reservacionesPasadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservacionesPasadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtrasReservacionesPasadas;
        private System.Windows.Forms.DataGridView tablaReservacionesPasadas;
    }
}