namespace JUDYSOFT
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.habitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDatosDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adnibistracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habitacionesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.facturacionToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.adnibistracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // habitacionesToolStripMenuItem
            // 
            this.habitacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.reservacionesToolStripMenuItem});
            this.habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            this.habitacionesToolStripMenuItem.ShowShortcutKeys = false;
            this.habitacionesToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.habitacionesToolStripMenuItem.Text = "Habitaciones";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarToolStripMenuItem.Image")));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.consultarToolStripMenuItem.Text = "Gestión de Habitación";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // reservacionesToolStripMenuItem
            // 
            this.reservacionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reservacionesToolStripMenuItem.Image")));
            this.reservacionesToolStripMenuItem.Name = "reservacionesToolStripMenuItem";
            this.reservacionesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.reservacionesToolStripMenuItem.Text = "Reservaciones";
            this.reservacionesToolStripMenuItem.Click += new System.EventHandler(this.reservacionesToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNuevoClienteToolStripMenuItem,
            this.modificarDatosDeClienteToolStripMenuItem,
            this.consultarClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // ingresarNuevoClienteToolStripMenuItem
            // 
            this.ingresarNuevoClienteToolStripMenuItem.Name = "ingresarNuevoClienteToolStripMenuItem";
            this.ingresarNuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.ingresarNuevoClienteToolStripMenuItem.Text = "Ingresar Nuevo Cliente";
            this.ingresarNuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.ingresarNuevoClienteToolStripMenuItem_Click);
            // 
            // modificarDatosDeClienteToolStripMenuItem
            // 
            this.modificarDatosDeClienteToolStripMenuItem.Name = "modificarDatosDeClienteToolStripMenuItem";
            this.modificarDatosDeClienteToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.modificarDatosDeClienteToolStripMenuItem.Text = "Modificar Datos de Cliente";
            this.modificarDatosDeClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarDatosDeClienteToolStripMenuItem_Click);
            // 
            // consultarClientesToolStripMenuItem
            // 
            this.consultarClientesToolStripMenuItem.Name = "consultarClientesToolStripMenuItem";
            this.consultarClientesToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.consultarClientesToolStripMenuItem.Text = "Consultar Clientes";
            this.consultarClientesToolStripMenuItem.Click += new System.EventHandler(this.consultarClientesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.toolStripMenuItem1.Text = "Empleados";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.nuevoToolStripMenuItem.Text = "Ingresar nuevo empleado";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarFacturaToolStripMenuItem});
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            // 
            // generarFacturaToolStripMenuItem
            // 
            this.generarFacturaToolStripMenuItem.Name = "generarFacturaToolStripMenuItem";
            this.generarFacturaToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.generarFacturaToolStripMenuItem.Text = "Generar factura";
            this.generarFacturaToolStripMenuItem.Click += new System.EventHandler(this.generarFacturaToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soporteToolStripMenuItem,
            this.acercaEToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("soporteToolStripMenuItem.Image")));
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // acercaEToolStripMenuItem
            // 
            this.acercaEToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acercaEToolStripMenuItem.Image")));
            this.acercaEToolStripMenuItem.Name = "acercaEToolStripMenuItem";
            this.acercaEToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.acercaEToolStripMenuItem.Text = "Acerca de JUDYSOFT ";
            this.acercaEToolStripMenuItem.Click += new System.EventHandler(this.acercaEToolStripMenuItem_Click);
            // 
            // adnibistracionToolStripMenuItem
            // 
            this.adnibistracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionUsuariosToolStripMenuItem,
            this.parametrosToolStripMenuItem,
            this.modificarClientesToolStripMenuItem});
            this.adnibistracionToolStripMenuItem.Name = "adnibistracionToolStripMenuItem";
            this.adnibistracionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.adnibistracionToolStripMenuItem.Text = "Administracion";
            this.adnibistracionToolStripMenuItem.Click += new System.EventHandler(this.adnibistracionToolStripMenuItem_Click);
            // 
            // gestionUsuariosToolStripMenuItem
            // 
            this.gestionUsuariosToolStripMenuItem.Name = "gestionUsuariosToolStripMenuItem";
            this.gestionUsuariosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.gestionUsuariosToolStripMenuItem.Text = "Gestion Usuarios";
            this.gestionUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestionUsuariosToolStripMenuItem_Click);
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.parametrosToolStripMenuItem.Text = "Parametros";
            // 
            // modificarClientesToolStripMenuItem
            // 
            this.modificarClientesToolStripMenuItem.Name = "modificarClientesToolStripMenuItem";
            this.modificarClientesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.modificarClientesToolStripMenuItem.Text = "Modificar Clientes";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JUDYSOFT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem habitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarNuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarDatosDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adnibistracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClientesToolStripMenuItem;
    }
}