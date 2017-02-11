namespace JUDYSOFT
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
            this.btnAtrasReservacionesPasadas = new System.Windows.Forms.Button();
            this.btnConsultarReservacionesPasadas = new System.Windows.Forms.Button();
            this.tablaReservacionesPasadas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservacionesPasadas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtrasReservacionesPasadas
            // 
            this.btnAtrasReservacionesPasadas.Location = new System.Drawing.Point(405, 382);
            this.btnAtrasReservacionesPasadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtrasReservacionesPasadas.Name = "btnAtrasReservacionesPasadas";
            this.btnAtrasReservacionesPasadas.Size = new System.Drawing.Size(129, 30);
            this.btnAtrasReservacionesPasadas.TabIndex = 5;
            this.btnAtrasReservacionesPasadas.Text = "Atrás";
            this.btnAtrasReservacionesPasadas.UseVisualStyleBackColor = true;
            this.btnAtrasReservacionesPasadas.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConsultarReservacionesPasadas
            // 
            this.btnConsultarReservacionesPasadas.Location = new System.Drawing.Point(236, 382);
            this.btnConsultarReservacionesPasadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarReservacionesPasadas.Name = "btnConsultarReservacionesPasadas";
            this.btnConsultarReservacionesPasadas.Size = new System.Drawing.Size(128, 30);
            this.btnConsultarReservacionesPasadas.TabIndex = 4;
            this.btnConsultarReservacionesPasadas.Text = "Consultar";
            this.btnConsultarReservacionesPasadas.UseVisualStyleBackColor = true;
            this.btnConsultarReservacionesPasadas.Click += new System.EventHandler(this.button1_Click);
            // 
            // tablaReservacionesPasadas
            // 
            this.tablaReservacionesPasadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaReservacionesPasadas.Location = new System.Drawing.Point(23, 16);
            this.tablaReservacionesPasadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaReservacionesPasadas.Name = "tablaReservacionesPasadas";
            this.tablaReservacionesPasadas.RowTemplate.Height = 24;
            this.tablaReservacionesPasadas.Size = new System.Drawing.Size(511, 352);
            this.tablaReservacionesPasadas.TabIndex = 3;
            // 
            // reservacionesPasadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 439);
            this.Controls.Add(this.btnAtrasReservacionesPasadas);
            this.Controls.Add(this.btnConsultarReservacionesPasadas);
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
        private System.Windows.Forms.Button btnConsultarReservacionesPasadas;
        private System.Windows.Forms.DataGridView tablaReservacionesPasadas;
    }
}