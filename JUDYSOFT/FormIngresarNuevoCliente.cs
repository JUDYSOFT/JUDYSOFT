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
        public FormIngresarNuevoCliente()
        {
            InitializeComponent();
            textBoxDocumento.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)//boton aceptar 
        {
            if (radioCedula.Checked)
            {
                verificarCedula(textBoxDocumento.Text.Trim());
            }
            else
            {
                MessageBox.Show("Pasaporte seleccionado");
                
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

        private void textBoxNombre1_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
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
                textBoxNacionalidad.BackColor = Color.LightCoral;
                e.Handled = true;
                return;
            }
            else
            {
                textBoxNacionalidad.BackColor = Color.White;
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

        

        

        private void textBoxCédula_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
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
            
        

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCedula.Checked)
            {
                textBoxDocumento.Visible = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPasaporte.Checked)
            {
                textBoxDocumento.Visible = true;
            }

        }
        private void verificarCedula(string cedula)
        {
            char[] vector = cedula.ToCharArray();
            int sumatotal = 0;
            if (vector.Length==10)
            {
                for(int i = 0; i < vector.Length - 1; i++)
                {
                    int numero =Convert.ToInt32( vector[i].ToString());
                    if ((i+1) % 2 ==1)
                    {
                        numero = Convert.ToInt32(vector[i].ToString()) * 2;
                        if (numero>9)
                        {
                            numero = numero- 9;
                        }
                    }
                    sumatotal += numero;
                }
                sumatotal = 10 - (sumatotal % 10);
                if (sumatotal == Convert.ToInt32(vector[9].ToString()))
                {
                    MessageBox.Show("la cédula es correcta");
                }
                else
                {
                    MessageBox.Show("la cédula es incorrecta","JUDYSOFT",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("el número de cédula ingresado no contiene 10 dígitos");
            
            }
        }

        private void textBoxDocumento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
