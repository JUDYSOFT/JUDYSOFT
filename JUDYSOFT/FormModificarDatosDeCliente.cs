using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria;

namespace JUDYSOFT
{
    public partial class FormModificarDatosDeCliente : Form
    {

        public FormModificarDatosDeCliente()
        {
            InitializeComponent();

            desabilitarCampos();
        }

        clsCliente objCliente = new clsCliente();

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
            objCliente.NumDocumento = txtNumDocumentoModificarCliente.Text.ToString();
            objCliente.Nombre1 = txtNombre1IngresoCliente.Text.ToString();
            objCliente.Nombre2 = txtNombre2IngresoCliente.Text.ToString();
            objCliente.Apellido1 = txtApellido1IngresoCliente.Text.ToString();
            objCliente.Apellido2 = txtApellido2IngresoCliente.Text.ToString();
            objCliente.Telefono1 = txtTelefono1IngresoCliente.Text.ToString();
            objCliente.Telefono2 = txtTelefono2IngresoCliente.Text.ToString();
            objCliente.Nacionalidad = txtNacionalidadIngresoCliente.Text.ToString();
            objCliente.Procedencia = txtProcedenciaIngresoCliente.Text.ToString();
            objCliente.EstadoCivil = comboBoxEstadoCivil.SelectedText.ToString();
            objCliente.Correo = txtCorreoIngresoCLiente.Text.ToString();
            objCliente.Direccion = txtDireccionIngresoCliente.Text.ToString();
            objCliente.FechaNac = Convert.ToDateTime(fechaNacIngresoCliente.Text.ToString());
            objCliente.EstadoCivil = comboBoxEstadoCivil.SelectedItem.ToString();
            string cmd = string.Format("exec verificarCliente '{0}'", objCliente.NumDocumento);
            DataSet DS = Utilidades.Ejecutar(cmd);
            int codCliente = Convert.ToInt32( DS.Tables[0].Rows[0]["CODCLIENTE"].ToString().Trim());

            try
            {
                string cmd1 = string.Format("exec modificarCliente '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}', '{8}', '{9}','{10}','{11}','{12}'", objCliente.Nombre1, objCliente.Nombre2, objCliente.Apellido1, objCliente.Apellido2, objCliente.Telefono1, objCliente.Telefono2, objCliente.Direccion, objCliente.Nacionalidad, objCliente.Procedencia, objCliente.FechaNac, objCliente.Correo, objCliente.EstadoCivil, codCliente);
                DataSet DS1 = Utilidades.Ejecutar(cmd1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex);
            }

            MessageBox.Show("Datos Modificados Correctamente", "JUDYSOFT");
            limpiarCampos();
            desabilitarCampos();
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
        private void habilitarCampos()
        {
            txtNombre1IngresoCliente.Enabled = true;
            txtApellido1IngresoCliente.Enabled = true;
            txtNombre2IngresoCliente.Enabled = true;
            txtApellido2IngresoCliente.Enabled = true;
            txtTelefono1IngresoCliente.Enabled = true;
            txtTelefono2IngresoCliente.Enabled = true;
            txtNacionalidadIngresoCliente.Enabled = true;
            comboBoxEstadoCivil.Enabled = true;
            txtCorreoIngresoCLiente.Enabled = true;
            txtProcedenciaIngresoCliente.Enabled = true;
            txtDireccionIngresoCliente.Enabled = true;
            fechaNacIngresoCliente.Enabled = true;
        }

        private void listaClientesModificarCliente_Click(object sender, EventArgs e)
        {
            FormListaClientes frm = new FormListaClientes();
           frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Normal;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {

                txtNumDocumentoModificarCliente.Text= frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[9].Value.ToString();
                txtNombre1IngresoCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[1].Value.ToString();
                txtNombre2IngresoCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[2].Value.ToString();
                txtApellido1IngresoCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[3].Value.ToString();
                txtApellido2IngresoCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[4].Value.ToString();
                txtTelefono1IngresoCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[5].Value.ToString();
                txtTelefono2IngresoCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[6].Value.ToString();
                txtDireccionIngresoCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[7].Value.ToString();
                txtNacionalidadIngresoCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[10].Value.ToString();
                txtProcedenciaIngresoCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[11].Value.ToString();
                fechaNacIngresoCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[12].Value.ToString();
                txtCorreoIngresoCLiente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[14].Value.ToString();
                comboBoxEstadoCivil.SelectedItem = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[15].Value.ToString();
                habilitarCampos();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("El cliente no se encuentra registrado en la base de datos","JUDYSOFT",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
