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
    public partial class FormModificarDatosDeCliente : Form
    {
        public FormModificarDatosDeCliente()
        {
            InitializeComponent();

            desabilitarCampos();
        }

       

        private void FormModificarDatosDeCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea salir?", "JUDYSOFT", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (confirmacion == System.Windows.Forms.DialogResult.OK)
            {
                this.Dispose();
                MenuSettings.EnableMenuItem("clientesToolStripMenuItem", "modificarDatosDeClienteToolStripMenuItem");
            }
            else
            {

                e.Cancel = true;
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void btnModificarModificarDatosCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Modificados Correctamente", "JUDYSOFT");
           // this.Close();
        }

        private void btnCancelarModificarDatosCliente_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnSalirModificarDatosCliente_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Esta seguro que desea cancelar", "JUDYSOFT", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (confirmacion == System.Windows.Forms.DialogResult.OK)
            {
                this.Dispose();
                MenuSettings.EnableMenuItem("clientesToolStripMenuItem", "modificarDatosDeClienteToolStripMenuItem");
            }
            else 
            {

            }

        }

        private void limpiarCampos()
        {
            txtNombre1IngresoCliente.Text = "";
            txtApellido1IngresoCliente.Text = "";
            txtNombre2IngresoCliente.Text = "";
            txtApellido2IngresoCliente.Text = "";
            txtTelefono1IngresoCliente.Text = "";
            txtTelefono2IngresoCliente.Text = "";
            txtNacionalidadIngresoCliente.Text = "";
            comboBoxEstadoCivil.SelectedIndex=-1;
            txtCorreoIngresoCLiente.Text = "";
            txtProcedenciaIngresoCliente.Text = "";
            txtDireccionIngresoCliente.Text = "";
            txtNumDocumentoModificarCliente.Text = "";

        }
        private void desabilitarCampos()
        {
            txtNombre1IngresoCliente.Enabled = false;
            txtApellido1IngresoCliente.Enabled = false;
            txtNombre2IngresoCliente.Enabled = false;
            txtApellido2IngresoCliente.Enabled = false;
            txtTelefono1IngresoCliente.Enabled = false;
            txtTelefono2IngresoCliente.Enabled = false;
            txtNacionalidadIngresoCliente.Enabled = false;
            comboBoxEstadoCivil.Enabled = false;
            txtCorreoIngresoCLiente.Enabled = false;
            txtProcedenciaIngresoCliente.Enabled = false;
            txtDireccionIngresoCliente.Enabled = false;
            fechaNacIngresoCliente.Enabled = false;
        }

        private void listaClientesModificarCliente_Click(object sender, EventArgs e)
        {
            FormListaClientes frm = new FormListaClientes();
           frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }
    }
}
