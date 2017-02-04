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
    }
}
