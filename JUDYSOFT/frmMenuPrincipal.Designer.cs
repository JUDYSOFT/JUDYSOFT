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
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDatosDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adnibistracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ingresarToolStripMenuItem,
            this.reservacionesToolStripMenuItem});
            this.habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            this.habitacionesToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.habitacionesToolStripMenuItem.Text = "Habitaciones";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarToolStripMenuItem.Image")));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.consultarToolStripMenuItem.Text = "Consultar Habitacion";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // ingresarToolStripMenuItem
            // 
            this.ingresarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ingresarToolStripMenuItem.Image")));
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ingresarToolStripMenuItem.Text = "Asignar Habitacion";
            this.ingresarToolStripMenuItem.Click += new System.EventHandler(this.ingresarToolStripMenuItem_Click);
            // 
            // reservacionesToolStripMenuItem
            // 
            this.reservacionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reservacionesToolStripMenuItem.Image")));
            this.reservacionesToolStripMenuItem.Name = "reservacionesToolStripMenuItem";
            this.reservacionesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.reservacionesToolStripMenuItem.Text = "Reservaciones";
            this.reservacionesToolStripMenuItem.Click += new System.EventHandler(this.reservacionesToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNuevoClienteToolStripMenuItem,
            this.modificarDatosDeClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // ingresarNuevoClienteToolStripMenuItem
            // 
            this.ingresarNuevoClienteToolStripMenuItem.Image = global::JUDYSOFT.Properties.Resources._1484548508_Pencil;
            this.ingresarNuevoClienteToolStripMenuItem.Name = "ingresarNuevoClienteToolStripMenuItem";
            this.ingresarNuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.ingresarNuevoClienteToolStripMenuItem.Text = "Ingresar Nuevo Cliente";
            this.ingresarNuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.ingresarNuevoClienteToolStripMenuItem_Click);
            // 
            // modificarDatosDeClienteToolStripMenuItem
            // 
            this.modificarDatosDeClienteToolStripMenuItem.Image = global::JUDYSOFT.Properties.Resources._1484548483_Edit_page;
            this.modificarDatosDeClienteToolStripMenuItem.Name = "modificarDatosDeClienteToolStripMenuItem";
            this.modificarDatosDeClienteToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.modificarDatosDeClienteToolStripMenuItem.Text = "Modificar Datos de Cliente";
            this.modificarDatosDeClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarDatosDeClienteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.toolStripMenuItem1.Text = "Empleados";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = global::JUDYSOFT.Properties.Resources._1484548508_Pencil;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.nuevoToolStripMenuItem.Text = "Ingresar nuevo empleado";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Image = global::JUDYSOFT.Properties.Resources._1484548483_Edit_page;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.modificarToolStripMenuItem.Text = "Modificar datos de un empleado";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = global::JUDYSOFT.Properties.Resources._1484546297_Cancel;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar empleado";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
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
            this.generarFacturaToolStripMenuItem.Image = global::JUDYSOFT.Properties.Resources._1484548508_Pencil;
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
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // acercaEToolStripMenuItem
            // 
            this.acercaEToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("acercaEToolStripMenuItem.Image")));
            this.acercaEToolStripMenuItem.Name = "acercaEToolStripMenuItem";
            this.acercaEToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.acercaEToolStripMenuItem.Text = "Acerca de JUDYSOFT ";
            this.acercaEToolStripMenuItem.Click += new System.EventHandler(this.acercaEToolStripMenuItem_Click);
            // 
            // adnibistracionToolStripMenuItem
            // 
            this.adnibistracionToolStripMenuItem.Name = "adnibistracionToolStripMenuItem";
            this.adnibistracionToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.adnibistracionToolStripMenuItem.Text = "Adnibistracion";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarNuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarDatosDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adnibistracionToolStripMenuItem;
    }
}