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
            String cmd = "SELECT * FROM usuario WHERE idUsuario= " + frmLogin.Codigo;
            DataSet DS = Utilidades.Ejecutar(cmd);
            lblAtendidoPor.Text = DS.Tables[0].Rows[0]["NombreUsuario"].ToString().Trim();


        }

        public static int contFila = 0;
        private void BotonAniadir_Click(object sender, EventArgs e)
        {
            //FormAgregarProductoAFactura agregarProducto = new FormAgregarProductoAFactura();
            //agregarProducto.StartPosition = FormStartPosition.CenterScreen;
            //agregarProducto.Show();
            //this.Hide();

            if(Utilidades.ValidarFormulario(this,errorProvider1) == false)
            {
                bool existencia = false;
                int numFila = 0;

                if(contFila == 0)
                {
                    dataGridView1.Rows.Add(txtCodigo.Text,txtCantidad.Text, txtDescripcion.Text, txtValUni.Text);
                    double total = Convert.ToDouble(dataGridView1.Rows[contFila].Cells[1].Value) * Convert.ToDouble(dataGridView1.Rows[contFila].Cells[3].Value);
                    dataGridView1.Rows[contFila].Cells[4].Value = total;

                    contFila++;
                }
                else
                {
                    foreach(DataGridViewRow fila in dataGridView1.Rows)
                    {
                        if(fila.Cells[0].Value.ToString() == txtCodigo.Text)
                        {
                            existencia = true;
                            numFila = fila.Index;

                        }
                    }

                    if(existencia == true)
                    {
                        dataGridView1.Rows[numFila].Cells[1].Value = (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[numFila].Cells[1].Value)).ToString();
                        double total = Convert.ToDouble(dataGridView1.Rows[numFila].Cells[1].Value) * Convert.ToDouble(dataGridView1.Rows[numFila].Cells[3].Value);

                        dataGridView1.Rows[numFila].Cells[4].Value = total;

                    }else
                    {
                        dataGridView1.Rows.Add(txtCantidad.Text, txtDescripcion.Text, txtValUni.Text);
                        double total = Convert.ToDouble(dataGridView1.Rows[contFila].Cells[1].Value) * Convert.ToDouble(dataGridView1.Rows[contFila].Cells[3].Value);
                        dataGridView1.Rows[contFila].Cells[4].Value = total;

                        contFila++;
                    }

                }
            }

        }

        private void FormGenerarFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuSettings.EnableMenuItem("facturacionToolStripMenuItem", "generarFacturaToolStripMenuItem");
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Está seguro de eliminar el objeto?", "Mensaje advertencia", MessageBoxButtons.YesNo);
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection("Data Source=LENOVO-PC\\SQLEXPRESS;Initial Catalog=Administracion;Integrated Security=True");
            con.Open();
            MessageBox.Show("conexion exitosa");
            con.Close();*/



        }
        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtidCliente.Text.Trim()) == false) {
                try
                {
                    string cmd = string.Format("SELECT * FROM Cliente WHERE idCliente='{0}'", txtidCliente.Text.Trim());
                    DataSet DS = Utilidades.Ejecutar(cmd);

                    txtBoxCliente.Text = DS.Tables[0].Rows[0]["nombreCliente"].ToString().Trim() + " " +DS.Tables[0].Rows[0]["apellidoCliente"].ToString().Trim();
                    txtDireccion.Text = DS.Tables[0].Rows[0]["direccion"].ToString().Trim();
                    txtTelefono.Text = DS.Tables[0].Rows[0]["telefono"].ToString().Trim();
                } catch(Exception er)
                {
                    MessageBox.Show("Ha ocurrido un problema. \n" + er.Message);

                }
           }
        }
    }
}
