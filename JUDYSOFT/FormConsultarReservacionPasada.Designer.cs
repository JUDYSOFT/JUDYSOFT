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
            this.tablaReservacionesPasadas = new System.Windows.Forms.DataGridView();
            this.btnAtrasReservacionesPasadas = new System.Windows.Forms.Button();
            this.btnConsultarReservacionesPasadas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaReservacionesPasadas)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaReservacionesPasadas
            // 
            this.tablaReservacionesPasadas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tablaReservacionesPasadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaReservacionesPasadas.Location = new System.Drawing.Point(17, 13);
            this.tablaReservacionesPasadas.Margin = new System.Windows.Forms.Padding(2);
            this.tablaReservacionesPasadas.Name = "tablaReservacionesPasadas";
            this.tablaReservacionesPasadas.RowTemplate.Height = 24;
            this.tablaReservacionesPasadas.Size = new System.Drawing.Size(383, 306);
            this.tablaReservacionesPasadas.TabIndex = 3;
            // 
            // btnAtrasReservacionesPasadas
            // 
            this.btnAtrasReservacionesPasadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrasReservacionesPasadas.Image = global::JUDYSOFT.Properties.Resources._1484546336_Back;
            this.btnAtrasReservacionesPasadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtrasReservacionesPasadas.Location = new System.Drawing.Point(288, 334);
            this.btnAtrasReservacionesPasadas.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtrasReservacionesPasadas.Name = "btnAtrasReservacionesPasadas";
            this.btnAtrasReservacionesPasadas.Size = new System.Drawing.Size(112, 43);
            this.btnAtrasReservacionesPasadas.TabIndex = 5;
            this.btnAtrasReservacionesPasadas.Text = "Atrás";
            this.btnAtrasReservacionesPasadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtrasReservacionesPasadas.UseVisualStyleBackColor = true;
            this.btnAtrasReservacionesPasadas.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConsultarReservacionesPasadas
            // 
            this.btnConsultarReservacionesPasadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarReservacionesPasadas.Image = global::JUDYSOFT.Properties.Resources._1484548470_Zoom;
            this.btnConsultarReservacionesPasadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarReservacionesPasadas.Location = new System.Drawing.Point(163, 334);
            this.btnConsultarReservacionesPasadas.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarReservacionesPasadas.Name = "btnConsultarReservacionesPasadas";
            this.btnConsultarReservacionesPasadas.Size = new System.Drawing.Size(121, 43);
            this.btnConsultarReservacionesPasadas.TabIndex = 4;
            this.btnConsultarReservacionesPasadas.Text = "Consultar";
            this.btnConsultarReservacionesPasadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarReservacionesPasadas.UseVisualStyleBackColor = true;
            this.btnConsultarReservacionesPasadas.Click += new System.EventHandler(this.button1_Click);
            // 
            // reservacionesPasadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(430, 388);
            this.Controls.Add(this.btnAtrasReservacionesPasadas);
            this.Controls.Add(this.btnConsultarReservacionesPasadas);
            this.Controls.Add(this.tablaReservacionesPasadas);
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