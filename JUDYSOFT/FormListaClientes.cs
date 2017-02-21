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
            dataGridViewModificarClientes.Columns["CODCLIENTE"].Visible = false;
            dataGridViewModificarClientes.Columns["TELEFONO1CLIENTE"].Visible = false;
            dataGridViewModificarClientes.Columns["TELEFONO2CLIENTE"].Visible = false;
            dataGridViewModificarClientes.Columns["DIRECCIONCLIENTE"].Visible = false;
            dataGridViewModificarClientes.Columns["NACIONALIDADCLIENTE"].Visible = false;
            dataGridViewModificarClientes.Columns["LUGARPROCEDENCIACLIENTE"].Visible = false;
            dataGridViewModificarClientes.Columns["SEXOCLIENTE"].Visible = false;
            dataGridViewModificarClientes.Columns["CORREOCLIENTE"].Visible = false;
            dataGridViewModificarClientes.Columns[1].HeaderCell.Value = "Nombre 1";
            dataGridViewModificarClientes.Columns[2].HeaderCell.Value = "Nombre 2";
            dataGridViewModificarClientes.Columns[3].HeaderCell.Value = "Apellido 1";
            dataGridViewModificarClientes.Columns[4].HeaderCell.Value = "Apellido 2";
            dataGridViewModificarClientes.Columns[8].HeaderCell.Value = "Documento de Indentificación";
            dataGridViewModificarClientes.Columns[9].HeaderCell.Value = "Número de Indentificación";
        }

        public DataSet LLenarDGv(string tabla)
        {
            DataSet DS;
            string cmd = string.Format("SELECT * FROM " + tabla);
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
        }

        private void bttmCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    

}
