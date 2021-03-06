﻿using System;
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
            dataGridViewModificarClientes.DataSource = LLenarDGv().Tables[0];
            dataGridViewModificarClientes.Columns[0].Visible = false;
            dataGridViewModificarClientes.Columns[7].Visible = false;
            dataGridViewModificarClientes.Columns[8].Visible = false;
            dataGridViewModificarClientes.Columns[9].Visible = false;
            dataGridViewModificarClientes.Columns[10].Visible = false;
            dataGridViewModificarClientes.Columns[11].Visible = false;
            dataGridViewModificarClientes.Columns[12].Visible = false;
            dataGridViewModificarClientes.Columns[13].Visible = false;
            dataGridViewModificarClientes.Columns[14].Visible = false;
            dataGridViewModificarClientes.Columns[3].HeaderCell.Value = "Apellido 1";
            dataGridViewModificarClientes.Columns[4].HeaderCell.Value = "Apellido 2";
            dataGridViewModificarClientes.Columns[1].HeaderCell.Value = "Nombre 1";
            dataGridViewModificarClientes.Columns[2].HeaderCell.Value = "Nombre 2";
            dataGridViewModificarClientes.Columns[5].HeaderCell.Value = "Documento de Indentificación";
            dataGridViewModificarClientes.Columns[6].HeaderCell.Value = "Número de Indentificación";
        }

        public DataSet LLenarDGv()
        {
            DataSet DS;
            string cmd = string.Format("SELECT * FROM CLIENTE");
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
