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
    public partial class FormListaClientes : Form
    {
        public FormListaClientes()
        {
            InitializeComponent();
        }

        private void bttnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }

        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = LLenarDGv("CLIENTE").Tables[0];  
        }

        public DataSet LLenarDGv(string tabla)
        {
            DataSet DS;
            string cmd = string.Format("SELECT * FROM "+tabla);
            DS = Utilidades.Ejecutar(cmd);
            return DS;
        }
    }
}
