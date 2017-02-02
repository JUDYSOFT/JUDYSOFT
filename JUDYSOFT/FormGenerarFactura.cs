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
    public partial class FormGenerarFactura : Form
    {
        public FormGenerarFactura()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BotonClientes_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormGenerarFactura_Load(object sender, EventArgs e)
        {

        }

        private void BotonAniadir_Click(object sender, EventArgs e)
        {
            FormAgregarProductoAFactura agregarProducto = new FormAgregarProductoAFactura();
            agregarProducto.StartPosition = FormStartPosition.CenterScreen;
            agregarProducto.Show();

        }

        private void FormGenerarFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuSettings.EnableMenuItem("facturacionToolStripMenuItem", "generarFacturaToolStripMenuItem");
        }
    }
}
