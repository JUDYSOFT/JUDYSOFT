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
    public partial class IngresarCliente : Form
    {
        Validaciones val = new Validaciones();
        public IngresarCliente()
        {
            InitializeComponent();
            //txtDocumento.Visible = false;
            desabilitarCampos();
           
        }
        

        private void btnAceptar_Click(object sender, EventArgs e)//boton aceptar 
        {
            if (Utilidades.ValidarFormulario(groupBoxDocumentoIdentificaciónIngresarCliente,errorProvider2)==false )
            {

                //verificarCedula(txtDocumento.Text.Trim());

            }
            if (Utilidades.ValidarFormulario(panelInformaciónIngresarCliente,errorProvider2)==false)
            {
                MessageBox.Show("Datos Correctos");
            }
                 
           
         }

        private void button2_Click(object sender, EventArgs e)//boton cancelar 
        {
            DialogResult confirmacion = MessageBox.Show("Está seguro que desea cancelar?", "JUDYSOFT", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (confirmacion == System.Windows.Forms.DialogResult.OK)
            {
                this.Dispose();
                MenuSettings.EnableMenuItem("clientesToolStripMenuItem", "ingresarNuevoClienteToolStripMenuItem");
            }
            else
            {

            }
        }

        private void FormIngresarNuevoCliente_FormClosing(object sender, FormClosingEventArgs e)
        {

        DialogResult confirmacion = MessageBox.Show("Está seguro que desea cancelar?", "JUDYSOFT", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (confirmacion == System.Windows.Forms.DialogResult.OK)
            {
                this.Dispose();
                MenuSettings.EnableMenuItem("clientesToolStripMenuItem", "ingresarNuevoClienteToolStripMenuItem");
            }
            else
            {
                
                e.Cancel=true;
            }

        }

        private void FormIngresarNuevoCliente_Load(object sender, EventArgs e)
        {

        }

      /*  private void textBoxNombre1_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                textBoxNombre1.BackColor = Color.LightCoral;
                e.Handled = true;
                return;
            }
            else
            {
                textBoxNombre1.BackColor = Color.White;
            }
        }

        private void textBoxNombre2_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                textBoxNombre2.BackColor = Color.LightCoral;
                e.Handled = true;
                return;
            }
            else
            {
                textBoxNombre2.BackColor = Color.White;
            }
        }

        private void textBoxApellido1_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                textBoxApellido1.BackColor = Color.LightCoral;
                e.Handled = true;
                return;
            }
            else
            {
                textBoxApellido1.BackColor = Color.White;
            }
        }

        private void textBoxApellido2_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                textBoxApellido2.BackColor = Color.LightCoral;
                e.Handled = true;
                return;
            }
            else
            {
                textBoxApellido2.BackColor = Color.White;
            }
        }

        private void textBoxTelefono1_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                textBoxTelefono1.BackColor = Color.LightCoral;
                e.Handled = true;
                return;
            }
            else
            {
                textBoxTelefono1.BackColor = Color.White;
            }
        }
        private void textBoxTelefono2_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                textBoxTelefono2.BackColor = Color.LightCoral;
                e.Handled = true;
                return;
            }
            else
            {
                textBoxTelefono2.BackColor = Color.White;
            }
        }

        private void textBoxNacionalidad_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                textBoxProcedencia.BackColor = Color.LightCoral;
                e.Handled = true;
                return;
            }
            else
            {
                textBoxProcedencia.BackColor = Color.White;
            }
        }

        private void textBoxEstadoCivil_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                textBoxEstadoCivil.BackColor = Color.LightCoral;
                e.Handled = true;
                return;
            }
            else
            {
                textBoxEstadoCivil.BackColor = Color.White;
            }
        }

        private void textBoxNombre1_TextChanged(object sender, EventArgs e)
        {

        }

        

        

        private void textBoxDocumento_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (radioCedula.Checked)
            {
                if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    textBoxDocumento.BackColor = Color.LightCoral;
                    e.Handled = true;
                    return;
                }
                else
                {
                    textBoxDocumento.BackColor = Color.White;
                }
            }
            else
            {
                
            }
            
        

        }*/

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtNumIdentificacionIngresarCliente.Text = "";
            /*if (radioCedula.Checked)
            {
                txtDocumento.Visible = true;
            }*/
            txtNumIdentificacionIngresarCliente.CharacterCasing = CharacterCasing.Upper;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtNumIdentificacionIngresarCliente.Text ="";
            /*if (radioPasaporte.Checked)
            {
                txtDocumento.Visible = true;
            }*/

        }
        

        private void textBoxNacionalidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (radioCedulaIngresarCliente.Checked)
                {
                   
                    if (Convert.ToInt32(txtNumIdentificacionIngresarCliente.Text.Length) == 10 && e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                    }
                if (val.validarCamposNumericos(e, txtNumIdentificacionIngresarCliente))
                    return;
                    
                
                    

                }
                else if (radioPasaporteIngresarCliente.Checked)
                {
                    
                    if (Convert.ToInt32(txtNumIdentificacionIngresarCliente.Text.Length) == 8 && e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                    }

                }

            

               
                
                    
            
            
      }

        private void txtNombre1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNombre1IngresarCliente.CharacterCasing = CharacterCasing.Upper;
            if (val.validarCadenasDeTexto(e, txtNombre1IngresarCliente))
                return;
        }

        private void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
           
        {
            txtApellido1IngresarCliente.CharacterCasing = CharacterCasing.Upper;
            if (val.validarCadenasDeTexto(e, txtApellido1IngresarCliente))
                return;
        }

        private void txtTelefono1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (val.validarCamposNumericos(e, txtTelefono1IngresarCliente))
                return;
        }

        private void txtTelefono1_Leave(object sender, EventArgs e)
        {
            if (val.validartelefono(txtTelefono1IngresarCliente.Text))
                return;
            else
                MessageBox.Show("telefono incorrecto");
        }

       private void txtDocumento_Leave(object sender, EventArgs e)
        {
            if (radioCedulaIngresarCliente.Checked)
            {
                if (val.verificarCedula(txtNumIdentificacionIngresarCliente.Text))
                    habilitarCampos();
                else
                    desabilitarCampos();
                    
            }
            
        }

        private void txtNacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNacionalidadIngresarCliente.CharacterCasing = CharacterCasing.Upper;
            if (val.validarCadenasDeTexto(e,txtNacionalidadIngresarCliente))
                return;

            
        }
        private void desabilitarCampos()
        {
            txtNombre1IngresarCliente.Enabled = false;
            txtApellido1IngresarCliente.Enabled = false;
            txtNombre2IngresarCliente.Enabled = false;
            txtApellido2IngresarCliente.Enabled = false;
            txtTelefono1IngresarCliente.Enabled = false;
            txtTelefono2IngresarCliente.Enabled = false;
            txtNacionalidadIngresarCliente.Enabled = false;
            txtEstadoCivilIngresarCliente.Enabled = false;
            txtCorreoIngresarCLiente.Enabled = false;
            txtProcedenciaIngresarCliente.Enabled = false;
            txtDireccionIngresarCliente.Enabled = false;
        }
        private void habilitarCampos()
        {
            txtNombre1IngresarCliente.Enabled = true;
            txtApellido1IngresarCliente.Enabled = true;
            txtNombre2IngresarCliente.Enabled = true;
            txtApellido2IngresarCliente.Enabled = true;
            txtTelefono1IngresarCliente.Enabled = true;
            txtTelefono2IngresarCliente.Enabled = true;
            txtNacionalidadIngresarCliente.Enabled = true;
            txtEstadoCivilIngresarCliente.Enabled = true;
            txtCorreoIngresarCLiente.Enabled = true;
            txtProcedenciaIngresarCliente.Enabled = true;
            txtDireccionIngresarCliente.Enabled = true;
        }

        private void txtEstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtEstadoCivilIngresarCliente.CharacterCasing = CharacterCasing.Upper;
            if (val.validarCadenasDeTexto(e, txtEstadoCivilIngresarCliente))
                return;

            
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDireccionIngresarCliente.CharacterCasing = CharacterCasing.Upper;
            
        }

        private void txtNombre2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNombre2IngresarCliente.CharacterCasing = CharacterCasing.Upper;
            if (val.validarCadenasDeTexto(e,txtNombre2IngresarCliente))
                return;
        }

        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtApellido2IngresarCliente.CharacterCasing = CharacterCasing.Upper;
            if (val.validarCadenasDeTexto(e,txtApellido2IngresarCliente))
                return;
            
        }

        private void txtTelefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (val.validarCamposNumericos(e,txtTelefono2IngresarCliente))
                return;
        }

        private void txtProcedencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtProcedenciaIngresarCliente.CharacterCasing = CharacterCasing.Upper;
            if (val.validarCadenasDeTexto(e, txtProcedenciaIngresarCliente))
                return;

            
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (val.emailBienEscrito(txtCorreoIngresarCLiente.Text))
            {
                txtCorreoIngresarCLiente.BackColor = Color.LightGreen;
            }
            else
                txtCorreoIngresarCLiente.BackColor = Color.LightCoral;
        }
    }
}
