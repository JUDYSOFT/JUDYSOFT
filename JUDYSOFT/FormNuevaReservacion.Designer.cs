namespace JUDYSOFT
{
    partial class FormNuevaReservacion
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
            this.btnListaClientesNuevaReservacion = new System.Windows.Forms.Button();
            this.lblAvisoNuevaReservacion = new System.Windows.Forms.Label();
            this.tBoxNumeroNiniosNuevaReserva = new System.Windows.Forms.TextBox();
            this.lblNumeroNiniosNuevaReservacion = new System.Windows.Forms.Label();
            this.lblNumeroAdultosNuevaReservacion = new System.Windows.Forms.Label();
            this.tBoxNumeroAdultosNuevaReserva = new System.Windows.Forms.TextBox();
            this.lblFechaSalidaNuevaReservacion = new System.Windows.Forms.Label();
            this.fechaSalidaNuevaReservacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaArrivoNuevaReservacion = new System.Windows.Forms.Label();
            this.fechaArrivoNuevaReservacion = new System.Windows.Forms.DateTimePicker();
            this.btnConsultarNuevaReservacion = new System.Windows.Forms.Button();
            this.lblNumeroIdentificacionNuevaReservacion = new System.Windows.Forms.Label();
            this.btnIngresarNuevaReservacion = new System.Windows.Forms.Button();
            this.btnCancelarNuevaReservacion = new System.Windows.Forms.Button();
            this.tBoxNumeroIdClienteNuevareservacion = new System.Windows.Forms.TextBox();
            this.lblNombreClienteNuevaReservacion = new System.Windows.Forms.Label();
            this.tBoxNombreClienteNuevaReservacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnListaClientesNuevaReservacion
            // 
            this.btnListaClientesNuevaReservacion.Location = new System.Drawing.Point(467, 22);
            this.btnListaClientesNuevaReservacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListaClientesNuevaReservacion.Name = "btnListaClientesNuevaReservacion";
            this.btnListaClientesNuevaReservacion.Size = new System.Drawing.Size(126, 26);
            this.btnListaClientesNuevaReservacion.TabIndex = 32;
            this.btnListaClientesNuevaReservacion.Text = "Lista de Clientes";
            this.btnListaClientesNuevaReservacion.UseVisualStyleBackColor = true;
            this.btnListaClientesNuevaReservacion.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblAvisoNuevaReservacion
            // 
            this.lblAvisoNuevaReservacion.AutoSize = true;
            this.lblAvisoNuevaReservacion.Location = new System.Drawing.Point(272, 261);
            this.lblAvisoNuevaReservacion.Name = "lblAvisoNuevaReservacion";
            this.lblAvisoNuevaReservacion.Size = new System.Drawing.Size(247, 17);
            this.lblAvisoNuevaReservacion.TabIndex = 31;
            this.lblAvisoNuevaReservacion.Text = "* Niño se considera hasta los 12 años";
            // 
            // tBoxNumeroNiniosNuevaReserva
            // 
            this.tBoxNumeroNiniosNuevaReserva.Location = new System.Drawing.Point(195, 290);
            this.tBoxNumeroNiniosNuevaReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxNumeroNiniosNuevaReserva.Name = "tBoxNumeroNiniosNuevaReserva";
            this.tBoxNumeroNiniosNuevaReserva.Size = new System.Drawing.Size(43, 22);
            this.tBoxNumeroNiniosNuevaReserva.TabIndex = 29;
            // 
            // lblNumeroNiniosNuevaReservacion
            // 
            this.lblNumeroNiniosNuevaReservacion.AutoSize = true;
            this.lblNumeroNiniosNuevaReservacion.Location = new System.Drawing.Point(29, 290);
            this.lblNumeroNiniosNuevaReservacion.Name = "lblNumeroNiniosNuevaReservacion";
            this.lblNumeroNiniosNuevaReservacion.Size = new System.Drawing.Size(116, 17);
            this.lblNumeroNiniosNuevaReservacion.TabIndex = 28;
            this.lblNumeroNiniosNuevaReservacion.Text = "Número de niños";
            // 
            // lblNumeroAdultosNuevaReservacion
            // 
            this.lblNumeroAdultosNuevaReservacion.AutoSize = true;
            this.lblNumeroAdultosNuevaReservacion.Location = new System.Drawing.Point(29, 231);
            this.lblNumeroAdultosNuevaReservacion.Name = "lblNumeroAdultosNuevaReservacion";
            this.lblNumeroAdultosNuevaReservacion.Size = new System.Drawing.Size(128, 17);
            this.lblNumeroAdultosNuevaReservacion.TabIndex = 27;
            this.lblNumeroAdultosNuevaReservacion.Text = "Número de adultos";
            // 
            // tBoxNumeroAdultosNuevaReserva
            // 
            this.tBoxNumeroAdultosNuevaReserva.Location = new System.Drawing.Point(195, 231);
            this.tBoxNumeroAdultosNuevaReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxNumeroAdultosNuevaReserva.Name = "tBoxNumeroAdultosNuevaReserva";
            this.tBoxNumeroAdultosNuevaReserva.Size = new System.Drawing.Size(43, 22);
            this.tBoxNumeroAdultosNuevaReserva.TabIndex = 26;
            // 
            // lblFechaSalidaNuevaReservacion
            // 
            this.lblFechaSalidaNuevaReservacion.AutoSize = true;
            this.lblFechaSalidaNuevaReservacion.Location = new System.Drawing.Point(29, 176);
            this.lblFechaSalidaNuevaReservacion.Name = "lblFechaSalidaNuevaReservacion";
            this.lblFechaSalidaNuevaReservacion.Size = new System.Drawing.Size(108, 17);
            this.lblFechaSalidaNuevaReservacion.TabIndex = 25;
            this.lblFechaSalidaNuevaReservacion.Text = "Fecha de salida";
            // 
            // fechaSalidaNuevaReservacion
            // 
            this.fechaSalidaNuevaReservacion.Location = new System.Drawing.Point(195, 176);
            this.fechaSalidaNuevaReservacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaSalidaNuevaReservacion.Name = "fechaSalidaNuevaReservacion";
            this.fechaSalidaNuevaReservacion.Size = new System.Drawing.Size(248, 22);
            this.fechaSalidaNuevaReservacion.TabIndex = 24;
            // 
            // lblFechaArrivoNuevaReservacion
            // 
            this.lblFechaArrivoNuevaReservacion.AutoSize = true;
            this.lblFechaArrivoNuevaReservacion.Location = new System.Drawing.Point(29, 125);
            this.lblFechaArrivoNuevaReservacion.Name = "lblFechaArrivoNuevaReservacion";
            this.lblFechaArrivoNuevaReservacion.Size = new System.Drawing.Size(107, 17);
            this.lblFechaArrivoNuevaReservacion.TabIndex = 23;
            this.lblFechaArrivoNuevaReservacion.Text = "Fecha de arrivo";
            // 
            // fechaArrivoNuevaReservacion
            // 
            this.fechaArrivoNuevaReservacion.Location = new System.Drawing.Point(195, 125);
            this.fechaArrivoNuevaReservacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaArrivoNuevaReservacion.Name = "fechaArrivoNuevaReservacion";
            this.fechaArrivoNuevaReservacion.Size = new System.Drawing.Size(248, 22);
            this.fechaArrivoNuevaReservacion.TabIndex = 22;
            // 
            // btnConsultarNuevaReservacion
            // 
            this.btnConsultarNuevaReservacion.Location = new System.Drawing.Point(351, 22);
            this.btnConsultarNuevaReservacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarNuevaReservacion.Name = "btnConsultarNuevaReservacion";
            this.btnConsultarNuevaReservacion.Size = new System.Drawing.Size(92, 26);
            this.btnConsultarNuevaReservacion.TabIndex = 21;
            this.btnConsultarNuevaReservacion.Text = "Consultar";
            this.btnConsultarNuevaReservacion.UseVisualStyleBackColor = true;
            this.btnConsultarNuevaReservacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNumeroIdentificacionNuevaReservacion
            // 
            this.lblNumeroIdentificacionNuevaReservacion.AutoSize = true;
            this.lblNumeroIdentificacionNuevaReservacion.Location = new System.Drawing.Point(29, 26);
            this.lblNumeroIdentificacionNuevaReservacion.Name = "lblNumeroIdentificacionNuevaReservacion";
            this.lblNumeroIdentificacionNuevaReservacion.Size = new System.Drawing.Size(160, 17);
            this.lblNumeroIdentificacionNuevaReservacion.TabIndex = 20;
            this.lblNumeroIdentificacionNuevaReservacion.Text = "Identificación del Cliente";
            // 
            // btnIngresarNuevaReservacion
            // 
            this.btnIngresarNuevaReservacion.Location = new System.Drawing.Point(342, 341);
            this.btnIngresarNuevaReservacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresarNuevaReservacion.Name = "btnIngresarNuevaReservacion";
            this.btnIngresarNuevaReservacion.Size = new System.Drawing.Size(101, 30);
            this.btnIngresarNuevaReservacion.TabIndex = 18;
            this.btnIngresarNuevaReservacion.Text = "Ingresar Reservación";
            this.btnIngresarNuevaReservacion.UseVisualStyleBackColor = true;
            this.btnIngresarNuevaReservacion.Click += new System.EventHandler(this.botonReservacion_Click);
            // 
            // btnCancelarNuevaReservacion
            // 
            this.btnCancelarNuevaReservacion.Location = new System.Drawing.Point(492, 341);
            this.btnCancelarNuevaReservacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarNuevaReservacion.Name = "btnCancelarNuevaReservacion";
            this.btnCancelarNuevaReservacion.Size = new System.Drawing.Size(101, 30);
            this.btnCancelarNuevaReservacion.TabIndex = 17;
            this.btnCancelarNuevaReservacion.Text = "Cancelar";
            this.btnCancelarNuevaReservacion.UseVisualStyleBackColor = true;
            this.btnCancelarNuevaReservacion.Click += new System.EventHandler(this.botonCancelarReservacion_Click);
            // 
            // tBoxNumeroIdClienteNuevareservacion
            // 
            this.tBoxNumeroIdClienteNuevareservacion.Location = new System.Drawing.Point(195, 24);
            this.tBoxNumeroIdClienteNuevareservacion.Name = "tBoxNumeroIdClienteNuevareservacion";
            this.tBoxNumeroIdClienteNuevareservacion.Size = new System.Drawing.Size(128, 22);
            this.tBoxNumeroIdClienteNuevareservacion.TabIndex = 33;
            this.tBoxNumeroIdClienteNuevareservacion.TextChanged += new System.EventHandler(this.tBoxNumeroIdClienteNuevareservacion_TextChanged);
            // 
            // lblNombreClienteNuevaReservacion
            // 
            this.lblNombreClienteNuevaReservacion.AutoSize = true;
            this.lblNombreClienteNuevaReservacion.Location = new System.Drawing.Point(29, 78);
            this.lblNombreClienteNuevaReservacion.Name = "lblNombreClienteNuevaReservacion";
            this.lblNombreClienteNuevaReservacion.Size = new System.Drawing.Size(125, 17);
            this.lblNombreClienteNuevaReservacion.TabIndex = 34;
            this.lblNombreClienteNuevaReservacion.Text = "Nombre de Cliente";
            // 
            // tBoxNombreClienteNuevaReservacion
            // 
            this.tBoxNombreClienteNuevaReservacion.Enabled = false;
            this.tBoxNombreClienteNuevaReservacion.Location = new System.Drawing.Point(195, 75);
            this.tBoxNombreClienteNuevaReservacion.Name = "tBoxNombreClienteNuevaReservacion";
            this.tBoxNombreClienteNuevaReservacion.Size = new System.Drawing.Size(248, 22);
            this.tBoxNombreClienteNuevaReservacion.TabIndex = 35;
            // 
            // FormNuevaReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 382);
            this.Controls.Add(this.tBoxNombreClienteNuevaReservacion);
            this.Controls.Add(this.lblNombreClienteNuevaReservacion);
            this.Controls.Add(this.tBoxNumeroIdClienteNuevareservacion);
            this.Controls.Add(this.btnListaClientesNuevaReservacion);
            this.Controls.Add(this.lblAvisoNuevaReservacion);
            this.Controls.Add(this.tBoxNumeroNiniosNuevaReserva);
            this.Controls.Add(this.lblNumeroNiniosNuevaReservacion);
            this.Controls.Add(this.lblNumeroAdultosNuevaReservacion);
            this.Controls.Add(this.tBoxNumeroAdultosNuevaReserva);
            this.Controls.Add(this.lblFechaSalidaNuevaReservacion);
            this.Controls.Add(this.fechaSalidaNuevaReservacion);
            this.Controls.Add(this.lblFechaArrivoNuevaReservacion);
            this.Controls.Add(this.fechaArrivoNuevaReservacion);
            this.Controls.Add(this.btnConsultarNuevaReservacion);
            this.Controls.Add(this.lblNumeroIdentificacionNuevaReservacion);
            this.Controls.Add(this.btnIngresarNuevaReservacion);
            this.Controls.Add(this.btnCancelarNuevaReservacion);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNuevaReservacion";
            this.Text = "Nueva Reservacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListaClientesNuevaReservacion;
        private System.Windows.Forms.Label lblAvisoNuevaReservacion;
        private System.Windows.Forms.TextBox tBoxNumeroNiniosNuevaReserva;
        private System.Windows.Forms.Label lblNumeroNiniosNuevaReservacion;
        private System.Windows.Forms.Label lblNumeroAdultosNuevaReservacion;
        private System.Windows.Forms.TextBox tBoxNumeroAdultosNuevaReserva;
        private System.Windows.Forms.Label lblFechaSalidaNuevaReservacion;
        private System.Windows.Forms.DateTimePicker fechaSalidaNuevaReservacion;
        private System.Windows.Forms.Label lblFechaArrivoNuevaReservacion;
        private System.Windows.Forms.DateTimePicker fechaArrivoNuevaReservacion;
        private System.Windows.Forms.Button btnConsultarNuevaReservacion;
        private System.Windows.Forms.Label lblNumeroIdentificacionNuevaReservacion;
        private System.Windows.Forms.Button btnIngresarNuevaReservacion;
        private System.Windows.Forms.Button btnCancelarNuevaReservacion;
        private System.Windows.Forms.TextBox tBoxNumeroIdClienteNuevareservacion;
        private System.Windows.Forms.Label lblNombreClienteNuevaReservacion;
        private System.Windows.Forms.TextBox tBoxNombreClienteNuevaReservacion;
    }
}