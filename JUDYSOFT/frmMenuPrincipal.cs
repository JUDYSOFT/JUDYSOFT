using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JUDYSOFT
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
            frmAdministracionHabitaciones frm= new frmAdministracionHabitaciones();
            consultarToolStripMenuItem.Enabled = false;
            frm.MdiParent = this;
            frm.Show();
        }

        private void acercaEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcerca frm = new frmAcerca();
            acercaEToolStripMenuItem.Enabled = false;
            frm.MdiParent = this;
            frm.Show();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngresarNuevoEmpleado frm = new FormIngresarNuevoEmpleado();
            nuevoToolStripMenuItem.Enabled = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminarEmpleado frm = new FormEliminarEmpleado();
            eliminarToolStripMenuItem.Enabled = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarDatosDeEmpleado frm = new FormModificarDatosDeEmpleado();
            modificarToolStripMenuItem.Enabled = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void reservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReservas frm = new FormReservas();
            reservacionesToolStripMenuItem.Enabled = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGenerarFactura frm = new FormGenerarFactura();
            generarFacturaToolStripMenuItem.Enabled = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void modificarDatosDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*   FormListaClientes frm = new FormListaClientes();
               modificarDatosDeClienteToolStripMenuItem.Enabled = false;
               frm.StartPosition = FormStartPosition.CenterScreen;
               frm.WindowState = FormWindowState.Maximized;
               frm.MdiParent = this;
               frm.Show();*/
            FormModificarDatosDeCliente frm = new FormModificarDatosDeCliente();
            modificarDatosDeClienteToolStripMenuItem.Enabled = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void ingresarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngresarNuevoCliente frm = new FormIngresarNuevoCliente();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            ingresarNuevoClienteToolStripMenuItem.Enabled = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void adnibistracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarCliente frm = new FormConsultarCliente();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            consultarClientesToolStripMenuItem.Enabled = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
