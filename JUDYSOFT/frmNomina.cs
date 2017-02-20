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
    public partial class frmNomina : Form
    {
        public DataGridView dataGridView
        {
            get; set;
        }
        public frmNomina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            if (dataGridViewNomina.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmNomina_Load(object sender, EventArgs e)
        {

        }

        public DataSet LLenarDGv(string tabla)
        {
            DataSet DS;
            string cmd = string.Format("SELECT NUMERODOCUMENTOCLIENTE Documento_Identificación,DOCUMENTOIDENTIDADCLIENTE Tipo,NOMBRE1CLIENTE Primer_Nombre,NOMBRE2CLIENTE Segundo_Nombre,APELLIDO1CLIENTE Primer_Apellido,APELLIDO2CLIENTE Segundo_Apellido FROM " + tabla);
            DS = Utilidades.Ejecutar(cmd);
            return DS;
        }

        public DataSet LLenarDGv1(string tabla)
        {
            DataSet DS;
            string cmd = string.Format("SELECT NUMERODOCUMENTOEMPLEADO Documento_Identificación,DOCUMENTOIDENTIFICACIONEMPLEADO Tipo_Identificación,NOMBRE1EMPLEADO Primer_Nombre,NOMBRE2EMPLEADO Segundo_Nombre,APELLIDO1EMPLEADO Primer_Apellido,APELLIDO2EMPLEADO Segundo_Apellido FROM " + tabla);
            DS = Utilidades.Ejecutar(cmd);
            return DS;
        }

        internal void LoadTipoNomina(String Tipo)
        {
            switch (Tipo)
            {
                case "Clientes":
                    dataGridViewNomina.DataSource = LLenarDGv("CLIENTE").Tables[0];
                    break;
                case "Empleados":
                    dataGridViewNomina.DataSource = LLenarDGv1("EMPLEADO").Tables[0];
                    break;
                default:
                    break;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
