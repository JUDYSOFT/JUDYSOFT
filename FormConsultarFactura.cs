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
    public partial class FormConsultarFactura : Form
    {
        public FormConsultarFactura()
        {
            InitializeComponent();
        }

        private void textBoxCedula_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                textBoxCedula.BackColor = Color.LightCoral;
                e.Handled = true;
                return;
            }
            else
            {
                textBoxCedula.BackColor = Color.White;
            }
        }

        private void textBox7_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                textBoxCedula.BackColor = Color.LightCoral;
                e.Handled = true;
                return;
            }
            else
            {
                textBoxCedula.BackColor = Color.White;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
