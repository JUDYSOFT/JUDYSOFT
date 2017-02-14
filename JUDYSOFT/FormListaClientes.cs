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
            if (dataGridViewModificarClientes.Rows.Count == 0)
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
           
            dataGridViewModificarClientes.DataSource = LLenarDGv("CLIENTE").Tables[0];
            dataGridViewModificarClientes.Columns[0].HeaderCell.Value = "Nombre 1";
        }

        public DataSet LLenarDGv(string tabla)
        {
            DataSet DS;
            string cmd = string.Format("SELECT NOMBRE1CLIENTE, NOMBRE2CLIENTE, APELLIDO1CLIENTE , APELLIDO2CLIENTE, NUMERODOCUMENTOCLIENTE FROM "+tabla);
            DS = Utilidades.Ejecutar(cmd);
            return DS;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void FormListaClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea salir?", "JUDYSOFT", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (confirmacion == System.Windows.Forms.DialogResult.OK)
            {
                this.Dispose();
                MenuSettings.EnableMenuItem("clientesToolStripMenuItem", "modificarDatosDeClienteToolStripMenuItem");
            }
            else
            {

                e.Cancel = true;
            }

        }
    }
    

}
