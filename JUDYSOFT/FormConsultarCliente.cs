using Libreria;
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
    public partial class FormConsultarCliente : Form
    {
        clsCliente objCliente = new clsCliente();
        public FormConsultarCliente()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        private void FormConsultarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuSettings.EnableMenuItem("clientesToolStripMenuItem", "consultarClientesToolStripMenuItem");
        }

        private void btnSalirConsultarCliente_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MenuSettings.EnableMenuItem("clientesToolStripMenuItem", "consultarClientesToolStripMenuItem");
        }

        private void FormConsultarCliente_Load(object sender, EventArgs e)
        {

        }

        private void desabilitarCampos()
        {
            txtNombre1ConsultarCliente.Enabled = false;
            txtApellido1ConsultarCliente.Enabled = false;
            txtNombre2ConsultarCliente.Enabled = false;
            txtApellido2ConsultarCliente.Enabled = false;
            txtTelefono1ConsultarCliente.Enabled = false;
            txtTelefono2ConsultarCliente.Enabled = false;
            txtNacionalidadConsultarCliente.Enabled = false;
            comboBoxConsultarEstadoCivil.Enabled = false;
            txtCorreoConsultarCLiente.Enabled = false;
            txtProcedenciaConsultarCliente.Enabled = false;
            txtDireccionConsultarCliente.Enabled = false;

        }

        private void listaClientesConsultarCliente_Click(object sender, EventArgs e)
        {
            FormListaClientes frm = new FormListaClientes();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Normal;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {

                txtNumIdentificacionConsultarCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[6].Value.ToString();
                txtNombre1ConsultarCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[1].Value.ToString();
                txtNombre2ConsultarCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[2].Value.ToString();
                txtApellido1ConsultarCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[3].Value.ToString();
                txtApellido2ConsultarCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[4].Value.ToString();
                txtTelefono1ConsultarCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[13].Value.ToString();
                txtTelefono2ConsultarCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[14].Value.ToString();
                txtDireccionConsultarCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[12].Value.ToString();
                txtNacionalidadConsultarCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[10].Value.ToString();
                txtProcedenciaConsultarCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[7].Value.ToString();
                txtCorreoConsultarCLiente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[11].Value.ToString();
                comboBoxConsultarEstadoCivil.SelectedItem = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[8].Value.ToString();
               

            }
        }

        private void botonConsultar_Click(object sender, EventArgs e)
        {

            objCliente.NumDocumento = txtNumIdentificacionConsultarCliente.Text;
            try
            {
                string cmd3 = string.Format("select * from CLIENTE where NUMERODOCUMENTOCLIENTE= '{0}' ", objCliente.NumDocumento);
                DataSet DS3 = Utilidades.Ejecutar(cmd3);
                if (DS3.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("El cliente no se encuentra registrado en la base de datos", "JUDYSOFT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtNombre1ConsultarCliente.Text = DS3.Tables[0].Rows[0]["NOMBRE1CLIENTE"].ToString().Trim();
                    txtNombre2ConsultarCliente.Text = DS3.Tables[0].Rows[0]["NOMBRE2CLIENTE"].ToString().Trim();
                    txtApellido1ConsultarCliente.Text = DS3.Tables[0].Rows[0]["APELLIDO1CLIENTE"].ToString().Trim();
                    txtApellido2ConsultarCliente.Text = DS3.Tables[0].Rows[0]["APELLIDO2CLIENTE"].ToString().Trim();
                    txtTelefono1ConsultarCliente.Text = DS3.Tables[0].Rows[0]["TELEFONO1CLIENTE"].ToString().Trim();
                    txtTelefono2ConsultarCliente.Text = DS3.Tables[0].Rows[0]["TELEFONO2CLIENTE"].ToString().Trim();
                    txtDireccionConsultarCliente.Text = DS3.Tables[0].Rows[0]["DIRECCIONCLIENTE"].ToString().Trim();
                    txtNacionalidadConsultarCliente.Text = DS3.Tables[0].Rows[0]["NACIONALIDADCLIENTE"].ToString().Trim();
                    txtProcedenciaConsultarCliente.Text = DS3.Tables[0].Rows[0]["LUGARPROCEDENCIACLIENTE"].ToString().Trim();
                    txtCorreoConsultarCLiente.Text = DS3.Tables[0].Rows[0]["CORREOCLIENTE"].ToString().Trim();
                    comboBoxConsultarEstadoCivil.SelectedItem = DS3.Tables[0].Rows[0]["ESTADOCIVILCLIENTE"].ToString().Trim();
                }


               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }


}
}
