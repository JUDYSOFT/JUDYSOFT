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
        Validaciones validar = new Validaciones();
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
            if(textBoxNombre1.Focused)
                validar.validarCadenasDeTexto( e, textBoxNombre1,textBoxNombre2);
        }

        private void textBoxNombre2_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if(textBoxNombre2.Focused)
                validar.validarCadenasDeTexto(e, textBoxNombre2,textBoxApellido1);
        }

        private void textBoxApellido1_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (textBoxApellido1.Focused)
                validar.validarCadenasDeTexto(e, textBoxApellido1,textBoxApellido2);
        }

        private void textBoxApellido2_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (textBoxApellido2.Focused)
                validar.validarCadenasDeTexto( e, textBoxApellido2,textBoxTelefono1);
        }

        private void textBoxTelefono1_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (textBoxTelefono1.Focused)
                validar.validarCamposNumericos(e,textBoxTelefono1, textBoxTelefono2);
        }
        private void textBoxTelefono2_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (textBoxTelefono2.Focused)
                validar.validarCamposNumericos(e, textBoxTelefono2, textBoxLugarDeProcedencia);
        }
        private void textBoxLugarDeProcedencia_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (textBoxLugarDeProcedencia.Focused)
                validar.validarCadenasDeTexto(e, textBoxLugarDeProcedencia, textBoxNacionalidad);
        }
        private void textBoxNacionalidad_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (textBoxNacionalidad.Focused)
                validar.validarCadenasDeTexto(e, textBoxNacionalidad, textBoxEstadoCivil);
        }

        private void textBoxEstadoCivil_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (textBoxEstadoCivil.Focused)
                validar.validarCadenasDeTexto(e, textBoxEstadoCivil,textBoxProfesion);
        }

        private void textBoxProfesion_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (textBoxProfesion.Focused)
                validar.validarCadenasDeTexto( e, textBoxProfesion, textBoxProfesion);
        }

       


    }
}
