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
            if (dataGridView1.Rows.Count >  0)
            {
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Debe selecionar un Cliente", "JUDYSOFT");
            }

        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LLenarDGv("CLIENTE").Tables[0];  
        }

        public DataSet LLenarDGv(string tabla)
        {
            DataSet DS;
            string cmd = string.Format("SELECT NUMERODOCUMENTOCLIENTE Numero_Identificacion,DOCUMENTOIDENTIDADCLIENTE Tipo_Documento,NOMBRE1CLIENTE Nombre,APELLIDO1CLIENTE Primer_Apellido,APELLIDO2CLIENTE Segundo_Apellido,DIRECCIONCLIENTE Direccion,FECHANACCLIENTE Fecha_Nacimiento FROM " + tabla);
            DS = Utilidades.Ejecutar(cmd);
            return DS;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
