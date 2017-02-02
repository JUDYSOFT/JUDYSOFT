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
    public partial class FormIngresarNuevoEmpleado : Form
    {
        public FormIngresarNuevoEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Ingresados Correctamente", "JUDYSOFT");
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
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

        private void FormIngresarNuevoEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuSettings.EnableMenuItem("toolStripMenuItem1", "nuevoToolStripMenuItem");
        }

        private void panelNuevoEmpleado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormIngresarNuevoEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
