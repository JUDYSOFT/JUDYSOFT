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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Modificados Correctamente", "JUDYSOFT");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Esta seguro que desea cancelar", "JUDYSOFT", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (confirmacion == System.Windows.Forms.DialogResult.OK)
            {
                this.Dispose();
            }
            else if (confirmacion == System.Windows.Forms.DialogResult.Cancel)
            {

            }
        }

        private void FormModificarDatosDeCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuSettings.EnableMenuItem("clientesToolStripMenuItem", "modificarDatosDeClienteToolStripMenuItem");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
