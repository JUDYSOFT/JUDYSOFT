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
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxNumeroNiniosNuevaReserva = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxNumeroAdultosNuevaReserva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaSalidaNuevaReservacion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaArrivoNuevaReservacion = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.botonReservacion = new System.Windows.Forms.Button();
            this.btnCancelarReservacion = new System.Windows.Forms.Button();
            this.tBoxNumeroIdClienteNuevareservacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(467, 22);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 26);
            this.button2.TabIndex = 32;
            this.button2.Text = "Lista de Clientes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "* Niño se considera hasta los 12 años";
            // 
            // tBoxNumeroNiniosNuevaReserva
            // 
            this.tBoxNumeroNiniosNuevaReserva.Location = new System.Drawing.Point(195, 290);
            this.tBoxNumeroNiniosNuevaReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxNumeroNiniosNuevaReserva.Name = "tBoxNumeroNiniosNuevaReserva";
            this.tBoxNumeroNiniosNuevaReserva.Size = new System.Drawing.Size(43, 22);
            this.tBoxNumeroNiniosNuevaReserva.TabIndex = 29;
            this.tBoxNumeroNiniosNuevaReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxNumeroNiniosNuevaReserva_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Número de niños";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Número de adultos";
            // 
            // tBoxNumeroAdultosNuevaReserva
            // 
            this.tBoxNumeroAdultosNuevaReserva.Location = new System.Drawing.Point(195, 231);
            this.tBoxNumeroAdultosNuevaReserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBoxNumeroAdultosNuevaReserva.Name = "tBoxNumeroAdultosNuevaReserva";
            this.tBoxNumeroAdultosNuevaReserva.Size = new System.Drawing.Size(43, 22);
            this.tBoxNumeroAdultosNuevaReserva.TabIndex = 26;
            this.tBoxNumeroAdultosNuevaReserva.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tBoxNumeroAdultosNuevaReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxNumeroAdultosNuevaReserva_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fecha de salida";
            // 
            // fechaSalidaNuevaReservacion
            // 
            this.fechaSalidaNuevaReservacion.Location = new System.Drawing.Point(195, 176);
            this.fechaSalidaNuevaReservacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaSalidaNuevaReservacion.Name = "fechaSalidaNuevaReservacion";
            this.fechaSalidaNuevaReservacion.Size = new System.Drawing.Size(248, 22);
            this.fechaSalidaNuevaReservacion.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Fecha de arrivo";
            // 
            // fechaArrivoNuevaReservacion
            // 
            this.fechaArrivoNuevaReservacion.Location = new System.Drawing.Point(195, 125);
            this.fechaArrivoNuevaReservacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaArrivoNuevaReservacion.Name = "fechaArrivoNuevaReservacion";
            this.fechaArrivoNuevaReservacion.Size = new System.Drawing.Size(248, 22);
            this.fechaArrivoNuevaReservacion.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 26);
            this.button1.TabIndex = 21;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Identificación del Cliente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // botonReservacion
            // 
            this.botonReservacion.Location = new System.Drawing.Point(342, 341);
            this.botonReservacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.botonReservacion.Name = "botonReservacion";
            this.botonReservacion.Size = new System.Drawing.Size(101, 30);
            this.botonReservacion.TabIndex = 18;
            this.botonReservacion.Text = "Ingresar Reservación";
            this.botonReservacion.UseVisualStyleBackColor = true;
            this.botonReservacion.Click += new System.EventHandler(this.botonReservacion_Click);
            // 
            // btnCancelarReservacion
            // 
            this.btnCancelarReservacion.Location = new System.Drawing.Point(492, 341);
            this.btnCancelarReservacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarReservacion.Name = "btnCancelarReservacion";
            this.btnCancelarReservacion.Size = new System.Drawing.Size(101, 30);
            this.btnCancelarReservacion.TabIndex = 17;
            this.btnCancelarReservacion.Text = "Cancelar";
            this.btnCancelarReservacion.UseVisualStyleBackColor = true;
            this.btnCancelarReservacion.Click += new System.EventHandler(this.botonCancelarReservacion_Click);
            // 
            // tBoxNumeroIdClienteNuevareservacion
            // 
            this.tBoxNumeroIdClienteNuevareservacion.Location = new System.Drawing.Point(195, 24);
            this.tBoxNumeroIdClienteNuevareservacion.Name = "tBoxNumeroIdClienteNuevareservacion";
            this.tBoxNumeroIdClienteNuevareservacion.Size = new System.Drawing.Size(128, 22);
            this.tBoxNumeroIdClienteNuevareservacion.TabIndex = 33;
            this.tBoxNumeroIdClienteNuevareservacion.TextChanged += new System.EventHandler(this.tBoxNumeroIdClienteNuevareservacion_TextChanged);
            this.tBoxNumeroIdClienteNuevareservacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxNumeroIdClienteNuevareservacion_KeyPress_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Nombre de Cliente";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(195, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(248, 22);
            this.textBox3.TabIndex = 35;
            // 
            // FormNuevaReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 382);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tBoxNumeroIdClienteNuevareservacion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBoxNumeroNiniosNuevaReserva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBoxNumeroAdultosNuevaReserva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaSalidaNuevaReservacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechaArrivoNuevaReservacion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonReservacion);
            this.Controls.Add(this.btnCancelarReservacion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormNuevaReservacion";
            this.Text = "Nueva Reservacion";
            this.Load += new System.EventHandler(this.FormNuevaReservacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxNumeroNiniosNuevaReserva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxNumeroAdultosNuevaReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaSalidaNuevaReservacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaArrivoNuevaReservacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonReservacion;
        private System.Windows.Forms.Button btnCancelarReservacion;
        private System.Windows.Forms.TextBox tBoxNumeroIdClienteNuevareservacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
    }
}