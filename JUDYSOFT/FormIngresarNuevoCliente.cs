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
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            this.Dispose();
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Está seguro que desea cancelar?", "JUDYSOFT", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (confirmacion == System.Windows.Forms.DialogResult.OK)
            {
                this.Dispose();
            }
            else if (confirmacion == System.Windows.Forms.DialogResult.Cancel)
            {

            }
        }

        private void FormIngresarNuevoCliente_FormClosing(object sender, FormClosingEventArgs e)
        {

            MenuSettings.EnableMenuItem("clientesToolStripMenuItem", "ingresarNuevoClienteToolStripMenuItem");
            
            //((Form)this.MdiParent).Controls["ingresarNuevoClienteToolStripMenuItem"].Enabled = true;



            DialogResult confirmacion = MessageBox.Show("Está seguro que desea cancelar?", "JUDYSOFT", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (confirmacion == System.Windows.Forms.DialogResult.OK)
            {
                this.Dispose();
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
                textBoxNacionalidad.BackColor = Color.LightCoral;
                e.Handled = true;
                return;
            }
            else
            {
                textBoxNacionalidad.BackColor = Color.White;
            }
        }

        private void textBoxNombre1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
