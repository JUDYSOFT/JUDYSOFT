namespace JUDYSOFT
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.gpboxlogin = new System.Windows.Forms.GroupBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btningresar = new System.Windows.Forms.Button();
            this.gpboxlogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpboxlogin
            // 
            this.gpboxlogin.Controls.Add(this.lblpass);
            this.gpboxlogin.Controls.Add(this.lbluser);
            this.gpboxlogin.Controls.Add(this.txtpass);
            this.gpboxlogin.Controls.Add(this.txtuser);
            this.gpboxlogin.Controls.Add(this.btncancelar);
            this.gpboxlogin.Controls.Add(this.btningresar);
            this.gpboxlogin.Location = new System.Drawing.Point(12, 12);
            this.gpboxlogin.Name = "gpboxlogin";
            this.gpboxlogin.Size = new System.Drawing.Size(300, 120);
            this.gpboxlogin.TabIndex = 0;
            this.gpboxlogin.TabStop = false;
            this.gpboxlogin.Text = "Iniciar Sesión";
            this.gpboxlogin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(34, 49);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(61, 13);
            this.lblpass.TabIndex = 5;
            this.lblpass.Text = "Contraseña";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(52, 23);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(43, 13);
            this.lbluser.TabIndex = 4;
            this.lbluser.Text = "Usuario";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(110, 49);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(125, 20);
            this.txtpass.TabIndex = 3;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(110, 23);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(125, 20);
            this.txtuser.TabIndex = 2;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(160, 89);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 1;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(55, 89);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(75, 23);
            this.btningresar.TabIndex = 0;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(324, 142);
            this.Controls.Add(this.gpboxlogin);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso al Sistema";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.gpboxlogin.ResumeLayout(false);
            this.gpboxlogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpboxlogin;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btningresar;
    }
}