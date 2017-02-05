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
    public partial class FormAgregarProductoAFactura : Form
    {
        public FormAgregarProductoAFactura()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       public static int controw;
        private void bttmSelect_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add(txtCodProduct.Text, txtProductName.Text, txtPrice.Text);

        }
    }
}
