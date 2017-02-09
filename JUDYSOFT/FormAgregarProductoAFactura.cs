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
     

        private void FormAgregarProductoAFactura_Load(object sender, EventArgs e)
        {
            //Administración-----------------------------------------------------------------------------------------------

                dataGridView1.DataSource = LLenarDGv("Producto").Tables[0];

            //JUDYSOFT-----------------------------------------------------------------------------------------------------

                //DGVGenerarFactura.DataSource = LLenarDGv("PRODUCTO").Tables[0];
        }

        public DataSet LLenarDGv(string tabla)
        {
            DataSet DS;
            string cmd = string.Format("SELECT * FROM " + tabla);
            DS = Utilidades.Ejecutar(cmd);
            return DS;
        }
    }
}
