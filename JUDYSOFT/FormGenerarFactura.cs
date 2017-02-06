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
            String cmd = "SELECT * FROM EMPLEADO WHERE CODEMPLEADO= " + frmLogin.Codigo;
            DataSet DS = Utilidades.Ejecutar(cmd);
            lblAtendidoPor.Text = DS.Tables[0].Rows[0]["NOMBRE1EMPLEADO"].ToString().Trim() + DS.Tables[0].Rows[0]["APELLIDO1EMPLEADO"].ToString().Trim();


        }

        public static int contFila = 0;
        public static double total;


        private void BotonAniadir_Click(object sender, EventArgs e)
        {
            
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
                        dataGridView1.Rows.Add(txtCodigo.Text,txtCantidad.Text, txtDescripcion.Text, txtValUni.Text);
                        double total = Convert.ToDouble(dataGridView1.Rows[contFila].Cells[1].Value) * Convert.ToDouble(dataGridView1.Rows[contFila].Cells[3].Value);
                        dataGridView1.Rows[contFila].Cells[4].Value = total;

                        contFila++;
                    }

                }

                total = 0;

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    total += Convert.ToDouble(fila.Cells[4].Value);
                }
                txtSubtotal.Text = total.ToString();
            }

        }

        private void FormGenerarFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuSettings.EnableMenuItem("facturacionToolStripMenuItem", "generarFacturaToolStripMenuItem");
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (contFila > 0)
            {
                //MessageBox.Show("¿Está seguro de eliminar el objeto?", "Mensaje advertencia", MessageBoxButtons.YesNo);
                string message = "¿Está seguro de eliminar el objeto?";
                string caption = "Advertencia";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    total = total - (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value));
                    txtSubtotal.Text = total.ToString();

                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    contFila--;


                }

            }

            else
            {
                MessageBox.Show("No hay elementos a eliminar.", "Advertencia");
            }
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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


        private void botonListaProductos_Click(object sender, EventArgs e)
        {
            FormAgregarProductoAFactura agregarProducto = new FormAgregarProductoAFactura();
            agregarProducto.StartPosition = FormStartPosition.CenterScreen;
            agregarProducto.ShowDialog();

            if(agregarProducto.DialogResult == DialogResult.OK)
            {
                txtCodigo.Text = agregarProducto.dataGridView1.Rows[agregarProducto.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtDescripcion.Text = agregarProducto.dataGridView1.Rows[agregarProducto.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtValUni.Text = agregarProducto.dataGridView1.Rows[agregarProducto.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();

                txtCantidad.Focus();

            }


            //this.Hide();
        }

        private void Limpiar()
        {
            txtCantidad.Text = "";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtDireccion.Text = "";
            txtidCliente.Text = "";
            txtBoxCliente.Text = "";
            txtSubtotal.Text = "";
            txtTelefono.Text = "";
            txtValUni.Text = "";
            txtImpuesto.Text = "";
            txtTotal.Text = "";
            lblCliente.Text = "";

            comboBoxTaxes.SelectedIndex = -1;
            dataGridView1.Rows.Clear();
            contFila = 0;
            total = 0;

            txtidCliente.Focus();
        }

        private void botonNuevaFactura_Click(object sender, EventArgs e)
        {
            /*txtCantidad.Text = "";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtDireccion.Text = "";
            txtidCliente.Text = "";
            txtBoxCliente.Text = "";
            txtSubtotal.Text = "";
            txtTelefono.Text = "";
            txtValUni.Text = "";
            txtImpuesto.Text = "";
            txtTotal.Text = ""; 
            lblCliente.Text = "";

            comboBoxTaxes.SelectedIndex = -1;
            dataGridView1.Rows.Clear();
            contFila = 0;
            total = 0;

            txtidCliente.Focus();*/

            Limpiar();


        }

        private void botonListaClientes_Click(object sender, EventArgs e)
        {
            FormListaClientes nuevaLista = new FormListaClientes();
            nuevaLista.StartPosition = FormStartPosition.CenterScreen;
            nuevaLista.ShowDialog();


            if (nuevaLista.DialogResult == DialogResult.OK)
            {
                txtidCliente.Text = nuevaLista.dataGridView1.Rows[nuevaLista.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtBoxCliente.Text = nuevaLista.dataGridView1.Rows[nuevaLista.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString() + nuevaLista.dataGridView1.Rows[nuevaLista.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                txtDireccion.Text = nuevaLista.dataGridView1.Rows[nuevaLista.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                txtTelefono.Text = nuevaLista.dataGridView1.Rows[nuevaLista.dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();

                txtCodigo.Focus();

            }
        }
        double montoTotal;
        private void comboBoxTaxes_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if(comboBoxTaxes.SelectedIndex == 0)
            {
                txtImpuesto.Text = "0,12";
                
                CalculoMontoTotal(txtImpuesto.Text, txtSubtotal.Text);
            }
            else if(comboBoxTaxes.SelectedIndex == 1)
            {
                txtImpuesto.Text = "0,14";
                CalculoMontoTotal(txtImpuesto.Text, txtSubtotal.Text);
            }
            else
            {
                return;
            }
        }

        public void CalculoMontoTotal (string tax, string Subt)
        {
            montoTotal = (Convert.ToDouble(Subt) * Convert.ToDouble(tax)) + Convert.ToDouble(Subt);
            txtTotal.Text = montoTotal.ToString();
        }

        private void BotonFacturar_Click(object sender, EventArgs e)
        {
            try
            {

                string cmd = string.Format("Exec ActualizarFactura '{0}'", txtidCliente.Text.Trim());
                DataSet DS = Utilidades.Ejecutar(cmd);

                string NumFac = DS.Tables[0].Rows[0]["NumFactura"].ToString().Trim();

                foreach(DataGridViewRow Fila in dataGridView1.Rows)
                {
                    cmd = string.Format("Exec ActualizarDetalle '{0}','{1}','{2}','{3}'", NumFac, Fila.Cells[0].Value.ToString(), Fila.Cells[3].Value.ToString(), Fila.Cells[1].Value.ToString());
                    DS = Utilidades.Ejecutar(cmd);
                     
                }

                cmd = "Exec DatosFactura " + NumFac;
                DS = Utilidades.Ejecutar(cmd);

                Reporte report = new Reporte();

                report.reportViewer1.LocalReport.DataSources[0].Value = DS.Tables[0];
                report.ShowDialog();
                Limpiar();



            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
