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
    public partial class FormIngresarNuevoCliente : Form
    {
        Validaciones val = new Validaciones();
        clsCliente objCliente = new clsCliente();
        //DataSet DS = new DataSet();

        public FormIngresarNuevoCliente()
        {
            InitializeComponent();
          
            desabilitarCampos();
            radioM.Enabled = false;
            radioM.Enabled = false;
           
        }
        

        private void btnAceptar_Click(object sender, EventArgs e)//boton aceptar 
        {
            

            if (Utilidades.ValidarFormulario(panelInformación,errorProvider2)==false)
            {

               // objCliente.FechaNac = null; 
                objCliente.Nombre1 = txtNombre1IngresoCliente.Text.ToString();
                objCliente.Nombre2 = txtNombre2IngresoCliente.Text.ToString();
                objCliente.Apellido1 = txtApellido1IngresoCliente.Text.ToString();
                objCliente.Apellido2 = txtApellido2IngresoCliente.Text.ToString();
                objCliente.Telefono1 =  txtTelefono1IngresoCliente.Text.ToString();
                objCliente.Telefono2 = txtTelefono2IngresoCliente.Text.ToString();
                objCliente.Nacionalidad = txtNacionalidadIngresoCliente.Text.ToString();
                objCliente.Procedencia = txtProcedenciaIngresoCliente.Text.ToString();
                objCliente.EstadoCivil = comboBoxEstadoCivil.Text.ToString();
                objCliente.Correo = txtCorreoIngresoCLiente.Text.ToString();
                objCliente.Direccion = txtDireccionIngresoCliente.Text.ToString();
               
                if (radioF.Checked)
                {
                    objCliente.Sexo = radioF.Text.ToString();
                }
                else if (radioM.Checked)
                {
                    objCliente.Sexo = radioM.Text.ToString();
                }

                
                
             string val = string.Format("exec verificarCliente '{0}' ", objCliente.NumDocumento);
             DataSet   DS = Utilidades.Ejecutar(val);
               

                if (DS.Tables[0].Rows.Count==0)
                {
                    try
                    {
                        string cmd = string.Format("Exec registrarCliente '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}', '{8}', '{9}','{10}','{11}','{12}','{13}'", objCliente.Nombre1, objCliente.Nombre2, objCliente.Apellido1, objCliente.Apellido2,objCliente.Telefono1,objCliente.Telefono2, objCliente.Direccion, objCliente.Documento, objCliente.NumDocumento, objCliente.Nacionalidad, objCliente.Procedencia, objCliente.Sexo,objCliente.Correo,objCliente.EstadoCivil);
                      DataSet  DS1 = Utilidades.Ejecutar(cmd);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message);
                    }
                    limpiarCampos();
                    MessageBox.Show("Cliente Ingreasado Correctamente", "JUDYSOFT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {

                    MessageBox.Show("El cliente ya se encuentra registrado en el sistema", "JUDYSOFT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                }
                

               
            }
            
            
            
           


        }

        private void button2_Click(object sender, EventArgs e)//boton cancelar 
        {
            DialogResult confirmacion = MessageBox.Show("Está seguro que desea cancelar?", "JUDYSOFT", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (confirmacion == System.Windows.Forms.DialogResult.OK)
            {
                Dispose();
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
                Dispose();
                MenuSettings.EnableMenuItem("clientesToolStripMenuItem", "ingresarNuevoClienteToolStripMenuItem");
            }
            else
            {
                
                e.Cancel=true;
            }

        }

        private void FormIngresarNuevoCliente_Load(object sender, EventArgs e)
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtNumIdentificacionIngresoCliente.Text = "";
            
            txtNumIdentificacionIngresoCliente.CharacterCasing = CharacterCasing.Upper;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtNumIdentificacionIngresoCliente.Text ="";
            

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

            if (val.validarCadenasDeTexto(e,txtNombre1IngresoCliente))
                return;
        }

        private void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
           
        {
           
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
            else if (radioPasaporteIngresoCliente.Checked)
            {

                habilitarCampos();
            }
            else
                desabilitarCampos();
            
        }

        private void txtNacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
           
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
            comboBoxEstadoCivil.Enabled = false;
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
            comboBoxEstadoCivil.Enabled = true;
            txtCorreoIngresoCLiente.Enabled = true;
            txtProcedenciaIngresoCliente.Enabled = true;
            txtDireccionIngresoCliente.Enabled = true;
            
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
            comboBoxEstadoCivil.SelectedIndex=0;
            txtCorreoIngresoCLiente.Text = "";
            txtProcedenciaIngresoCliente.Text = "";
            txtDireccionIngresoCliente.Text = "";
            txtNumIdentificacionIngresoCliente.Text = "";
            
        }

       

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void txtNombre2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (val.validarCadenasDeTexto(e,txtNombre2IngresoCliente))
                return;
        }

        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
          
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

        private void btnSalirCliente_Click(object sender, EventArgs e)
        {
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(groupBoxDocumento, errorProvider2) == false)
            {
                if (radioCedulaIngresoCliente.Checked)
                {
                    objCliente.Documento = radioCedulaIngresoCliente.Text;
                    objCliente.NumDocumento = txtNumIdentificacionIngresoCliente.Text;

                }
                else if (radioPasaporteIngresoCliente.Checked)
                {
                    objCliente.Documento = radioPasaporteIngresoCliente.Text;
                    objCliente.NumDocumento = txtNumIdentificacionIngresoCliente.Text;
                }

                string val = string.Format("exec verificarCliente '{0}' ", objCliente.NumDocumento);
                DataSet DS = Utilidades.Ejecutar(val);


                if (DS.Tables[0].Rows.Count == 0)
                {
                    habilitarCampos();
                    radioM.Enabled = true;
                    radioF.Enabled = true;
                }

                else
                {

                    MessageBox.Show("El cliente ya se encuentra registrado en el sistema", "JUDYSOFT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumIdentificacionIngresoCliente.Text = "";
                    radioM.Enabled = false;
                    radioF.Enabled = false;
                    desabilitarCampos();
                }

            }

        }
    }
}
