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
            if (Utilidades.ValidarFormulario(groupBoxDocumento,errorProvider2)==false )
            {

                //verificarCedula(txtDocumento.Text.Trim());

            }
            if (Utilidades.ValidarFormulario(panelInformación,errorProvider2)==false)
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
            txtNumIdentificacionIngresoCliente.Text = "";
            /*if (radioCedula.Checked)
            {
                txtDocumento.Visible = true;
            }*/
            txtNumIdentificacionIngresoCliente.CharacterCasing = CharacterCasing.Upper;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtNumIdentificacionIngresoCliente.Text ="";
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
            
                if (radioCedulaIngresoCliente.Checked)
                {
                   
                    if (Convert.ToInt32(txtNumIdentificacionIngresoCliente.Text.Length) == 10 && e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                    }
                if (val.validarCamposNumericos(e, txtNumIdentificacionIngresoCliente))
                    return;
                    
                
                    

                }
                else if (radioPasaporteIngresoCliente.Checked)
                {
                    
                    if (Convert.ToInt32(txtNumIdentificacionIngresoCliente.Text.Length) == 8 && e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                    }

                }

            

               
                
                    
            
            
      }

        private void txtNombre1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNombre1IngresoCliente.CharacterCasing = CharacterCasing.Upper;
            if (val.validarCadenasDeTexto(e, txtNombre1IngresoCliente))
                return;
        }

        private void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
           
        {
            txtApellido1IngresoCliente.CharacterCasing = CharacterCasing.Upper;
            if (val.validarCadenasDeTexto(e, txtApellido1IngresoCliente))
                return;
        }

        private void txtTelefono1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (val.validarCamposNumericos(e, txtTelefono1IngresoCliente))
                return;
        }

        private void txtTelefono1_Leave(object sender, EventArgs e)
        {
            if (val.validartelefono(txtTelefono1IngresoCliente.Text))
                return;
            else
                MessageBox.Show("telefono incorrecto");
        }

       private void txtDocumento_Leave(object sender, EventArgs e)
        {
            if (radioCedulaIngresoCliente.Checked)
            {
                if (val.verificarCedula(txtNumIdentificacionIngresoCliente.Text))
                    habilitarCampos();
                else
                    desabilitarCampos();
                    
            }
            
        }

        private void txtNacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNacionalidadIngresoCliente.CharacterCasing = CharacterCasing.Upper;
            if (val.validarCadenasDeTexto(e,txtNacionalidadIngresoCliente))
                return;

            
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
            txtEstadoCivilIngresoCliente.Enabled = false;
            txtCorreoIngresoCLiente.Enabled = false;
            txtProcedenciaIngresoCliente.Enabled = false;
            txtDireccionIngresoCliente.Enabled = false;
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
            txtEstadoCivilIngresoCliente.Enabled = true;
            txtCorreoIngresoCLiente.Enabled = true;
            txtProcedenciaIngresoCliente.Enabled = true;
            txtDireccionIngresoCliente.Enabled = true;
        }

        private void txtEstadoCivil_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtEstadoCivilIngresoCliente.CharacterCasing = CharacterCasing.Upper;
            if (val.validarCadenasDeTexto(e, txtEstadoCivilIngresoCliente))
                return;

            
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDireccionIngresoCliente.CharacterCasing = CharacterCasing.Upper;
            
        }

        private void txtNombre2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNombre2IngresoCliente.CharacterCasing = CharacterCasing.Upper;
            if (val.validarCadenasDeTexto(e,txtNombre2IngresoCliente))
                return;
        }

        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtApellido2IngresoCliente.CharacterCasing = CharacterCasing.Upper;
            if (val.validarCadenasDeTexto(e,txtApellido2IngresoCliente))
                return;
            
        }

        private void txtTelefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (val.validarCamposNumericos(e,txtTelefono2IngresoCliente))
                return;
        }

        private void txtProcedencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtProcedenciaIngresoCliente.CharacterCasing = CharacterCasing.Upper;
            if (val.validarCadenasDeTexto(e, txtProcedenciaIngresoCliente))
                return;

            
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (val.emailBienEscrito(txtCorreoIngresoCLiente.Text))
            {
                txtCorreoIngresoCLiente.BackColor = Color.LightGreen;
            }
            else
                txtCorreoIngresoCLiente.BackColor = Color.LightCoral;
        }
    }
}
