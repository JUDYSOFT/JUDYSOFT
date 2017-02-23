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
        Validaciones val = new Validaciones();
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
                Dispose();
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
            objCliente.EstadoCivil = comboBoxEstadoCivil.Text.ToString();
            objCliente.Correo = txtCorreoIngresoCLiente.Text.ToString();
            objCliente.Direccion = txtDireccionIngresoCliente.Text.ToString();
           
            
            string cmd = string.Format("exec verificarCliente '{0}'", objCliente.NumDocumento);
            DataSet DS = Utilidades.Ejecutar(cmd);
            int codCliente = Convert.ToInt32( DS.Tables[0].Rows[0]["CODCLIENTE"].ToString().Trim());

            try
            {
                string cmd1 = string.Format("exec modificarCliente '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}', '{8}', '{9}','{10}','{11}'", objCliente.Nombre1, objCliente.Nombre2, objCliente.Apellido1, objCliente.Apellido2, objCliente.Procedencia,objCliente.EstadoCivil,objCliente.Nacionalidad,objCliente.Correo,objCliente.Direccion,objCliente.Telefono1,objCliente.Telefono2,codCliente);
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
            desabilitarCampos();
        }

        private void btnSalirModificarDatosCliente_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Esta seguro que desea cancelar", "JUDYSOFT", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (confirmacion == System.Windows.Forms.DialogResult.OK)
            {
                Dispose();
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
           
        }
        private void habilitarCampos()
        {
           // txtNombre1IngresoCliente.Enabled = true;
            //txtApellido1IngresoCliente.Enabled = true;
            //txtNombre2IngresoCliente.Enabled = true;
            //txtApellido2IngresoCliente.Enabled = true;
            txtTelefono1IngresoCliente.Enabled = true;
            txtTelefono2IngresoCliente.Enabled = true;
            txtNacionalidadIngresoCliente.Enabled = true;
            comboBoxEstadoCivil.Enabled = true;
            txtCorreoIngresoCLiente.Enabled = true;
            txtProcedenciaIngresoCliente.Enabled = true;
            txtDireccionIngresoCliente.Enabled = true;
           
        }

        private void listaClientesModificarCliente_Click(object sender, EventArgs e)
        {
            FormListaClientes frm = new FormListaClientes();
           frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Normal;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                
                txtNumDocumentoModificarCliente.Text= frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[6].Value.ToString();
                txtNombre1IngresoCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[1].Value.ToString();
                txtNombre2IngresoCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[2].Value.ToString();
                txtApellido1IngresoCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[3].Value.ToString();
                txtApellido2IngresoCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[4].Value.ToString();
                txtTelefono1IngresoCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[13].Value.ToString();
                txtTelefono2IngresoCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[14].Value.ToString();
                txtDireccionIngresoCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[12].Value.ToString();
                txtNacionalidadIngresoCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[10].Value.ToString();
                txtProcedenciaIngresoCliente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[7].Value.ToString();
                txtCorreoIngresoCLiente.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[11].Value.ToString();
                comboBoxEstadoCivil.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[8].Value.ToString();
                habilitarCampos();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            objCliente.NumDocumento = txtNumDocumentoModificarCliente.Text;
            try
            {
                string cmd3 = string.Format("select * from CLIENTE where NUMERODOCUMENTOIDENTIFICACIONCLIENTE= '{0}' ", objCliente.NumDocumento);
                DataSet DS3 = Utilidades.Ejecutar(cmd3);
                if (DS3.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("El cliente no se encuentra registrado en la base de datos", "JUDYSOFT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtNombre1IngresoCliente.Text = DS3.Tables[0].Rows[0]["NOMBRE1CLIENTE"].ToString().Trim();
                    txtNombre2IngresoCliente.Text = DS3.Tables[0].Rows[0]["NOMBRE2CLIENTE"].ToString().Trim();
                    txtApellido1IngresoCliente.Text = DS3.Tables[0].Rows[0]["APELLIDO1CLIENTE"].ToString().Trim();
                    txtApellido2IngresoCliente.Text = DS3.Tables[0].Rows[0]["APELLIDO2CLIENTE"].ToString().Trim();
                    txtTelefono1IngresoCliente.Text = DS3.Tables[0].Rows[0]["TELEFONO1CLIENTE"].ToString().Trim();
                    txtTelefono2IngresoCliente.Text = DS3.Tables[0].Rows[0]["TELEFONO2CLIENTE"].ToString().Trim();
                    txtDireccionIngresoCliente.Text = DS3.Tables[0].Rows[0]["DIRECCIONDOMICILIOCLIENTE"].ToString().Trim();
                    txtNacionalidadIngresoCliente.Text = DS3.Tables[0].Rows[0]["NACIONALIDADCLIENTE"].ToString().Trim();
                    txtProcedenciaIngresoCliente.Text = DS3.Tables[0].Rows[0]["LUGARPROCEDENCIACLIENTE"].ToString().Trim();
                    txtCorreoIngresoCLiente.Text = DS3.Tables[0].Rows[0]["CORREOELECTRONICOCLIENTE"].ToString().Trim();
                    comboBoxEstadoCivil.SelectedItem = DS3.Tables[0].Rows[0]["ESTADOCIVILCLIENTE"].ToString().Trim();
                }

                
                habilitarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex);
            }
        }

        private void FormModificarDatosDeCliente_Load(object sender, EventArgs e)
        {
            convertirMayusulas();
        }
        private void convertirMayusulas()
        {
            txtNombre1IngresoCliente.CharacterCasing = CharacterCasing.Upper;
            txtApellido1IngresoCliente.CharacterCasing = CharacterCasing.Upper;
            txtNacionalidadIngresoCliente.CharacterCasing = CharacterCasing.Upper;
            txtNombre2IngresoCliente.CharacterCasing = CharacterCasing.Upper;
            txtApellido2IngresoCliente.CharacterCasing = CharacterCasing.Upper;
            txtProcedenciaIngresoCliente.CharacterCasing = CharacterCasing.Upper;
            txtDireccionIngresoCliente.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtTelefono1IngresoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (val.validarCamposNumericos(e, txtTelefono1IngresoCliente))
                return;
        }

        private void txtTelefono2IngresoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (val.validarCamposNumericos(e, txtTelefono2IngresoCliente))
                return;
        }

        private void txtNacionalidadIngresoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (val.validarCadenasDeTexto(e,txtNacionalidadIngresoCliente))
            {
                return;
            }
        }

        private void txtProcedenciaIngresoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProcedenciaIngresoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (val.validarCadenasDeTexto(e, txtProcedenciaIngresoCliente))
            {
                return;
            }
        }

        private void txtCorreoIngresoCLiente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (val.emailBienEscrito(txtCorreoIngresoCLiente.Text))
            {
                txtCorreoIngresoCLiente.BackColor = Color.LightGreen;
            }
            else
                txtCorreoIngresoCLiente.BackColor = Color.LightCoral;
        }

        private void txtDireccionIngresoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (val.validarCadenasDeTexto(e, txtDireccionIngresoCliente))
            {
                return;
            }
        }
    }
}
