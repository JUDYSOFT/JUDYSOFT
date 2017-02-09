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

            //JUDYSOFT----------------------------------------------------------------------------------------------------------------------------------------

                String cmd = "SELECT * FROM EMPLEADO WHERE CODEMPLEADO= " + frmLogin.Codigo;
                DataSet DS = Utilidades.Ejecutar(cmd);
                lblAtendidoPorGenerarFactura.Text = DS.Tables[0].Rows[0]["NOMBRE1EMPLEADO"].ToString().Trim() + " "+DS.Tables[0].Rows[0]["APELLIDO1EMPLEADO"].ToString().Trim();

            //Administración--------------------------------------------------------------------------------------------------------------------------------------

                //String cmd = "SELECT * FROM usuario WHERE idUsuario= " + frmLogin.Codigo;
                //DataSet DS = Utilidades.Ejecutar(cmd);
                //lblAtendidoPor.Text = DS.Tables[0].Rows[0]["NombreUsuario"].ToString().Trim();

        }

        public static int contFila = 0;
        public static double total;


        private void BotonAniadirGenerarFactura_Click(object sender, EventArgs e)
        {
            
            if(Utilidades.ValidarFormulario(this,errorProvider1) == false)
            {
                bool existencia = false;
                int numFila = 0;

                if(contFila == 0)
                {
                    DGVGenerarFactura.Rows.Add(txtCodigoGenerarFactura.Text, txtCantidadGenerarFactura.Text, txtDescripcionGenerarFactura.Text, txtValUniGenerarFactura.Text);
                    double total = Convert.ToDouble(DGVGenerarFactura.Rows[contFila].Cells[1].Value) * Convert.ToDouble(DGVGenerarFactura.Rows[contFila].Cells[3].Value);
                    DGVGenerarFactura.Rows[contFila].Cells[4].Value = total;

                    contFila++;
                }
                else
                {
                    foreach(DataGridViewRow fila in DGVGenerarFactura.Rows)
                    {
                        if(fila.Cells[0].Value.ToString() == txtCodigoGenerarFactura.Text)
                        {
                            existencia = true;
                            numFila = fila.Index;

                        }
                    }

                    if(existencia == true)
                    {
                        DGVGenerarFactura.Rows[numFila].Cells[1].Value = (Convert.ToDouble(txtCantidadGenerarFactura.Text) + Convert.ToDouble(DGVGenerarFactura.Rows[numFila].Cells[1].Value)).ToString();
                        double total = Convert.ToDouble(DGVGenerarFactura.Rows[numFila].Cells[1].Value) * Convert.ToDouble(DGVGenerarFactura.Rows[numFila].Cells[3].Value);

                        DGVGenerarFactura.Rows[numFila].Cells[4].Value = total;

                    }else
                    {
                        DGVGenerarFactura.Rows.Add(txtCodigoGenerarFactura.Text, txtCantidadGenerarFactura.Text, txtDescripcionGenerarFactura.Text, txtValUniGenerarFactura.Text);
                        double total = Convert.ToDouble(DGVGenerarFactura.Rows[contFila].Cells[1].Value) * Convert.ToDouble(DGVGenerarFactura.Rows[contFila].Cells[3].Value);
                        DGVGenerarFactura.Rows[contFila].Cells[4].Value = total;

                        contFila++;
                    }

                }

                total = 0;

                foreach (DataGridViewRow fila in DGVGenerarFactura.Rows)
                {
                    total += Convert.ToDouble(fila.Cells[4].Value);
                }
                txtSubtotalGenerarFactura.Text = total.ToString();
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
                string message = "¿Está seguro de eliminar el objeto?";
                string caption = "Advertencia";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    total = total - (Convert.ToDouble(DGVGenerarFactura.Rows[DGVGenerarFactura.CurrentRow.Index].Cells[4].Value));
                    txtSubtotalGenerarFactura.Text = total.ToString();

                    DGVGenerarFactura.Rows.RemoveAt(DGVGenerarFactura.CurrentRow.Index);
                    contFila--;


                }

            }

            else
            {
                MessageBox.Show("No hay elementos a eliminar.", "Advertencia");
            }
        }

        private void BotonSalirGenerarFactura_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonBuscarGenerarFactura_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtidClienteGenerarFactura.Text.Trim()) == false) {
                try
                {
                    //Administración-------------------------------------------------------------------------------------------------------------------------------

                        string cmd = string.Format("SELECT * FROM Cliente WHERE CODCLIENTE='{0}'", txtidClienteGenerarFactura.Text.Trim());
                        DataSet DS = Utilidades.Ejecutar(cmd);

                    txtBoxClienteGenerarFactura.Text = DS.Tables[0].Rows[0]["nombre1Cliente"].ToString().Trim() + " " +DS.Tables[0].Rows[0]["apellido1Cliente"].ToString().Trim();
                    txtDireccionGenerarFactura.Text = DS.Tables[0].Rows[0]["direcciondomiciliocliente"].ToString().Trim();
                    txtTelefonoGenerarFactura.Text = DS.Tables[0].Rows[0]["telefono1cliente"].ToString().Trim();

                    //JUDYSOFT-----------------------------------------------------------------------------------------------------------------------------------------

                        
                } catch(Exception er)
                {
                    MessageBox.Show("Ha ocurrido un problema. \n" + er.Message);

                }
           }
        }


        private void botonListaProductosGenerarFactura_Click(object sender, EventArgs e)
        {
            FormAgregarProductoAFactura agregarProducto = new FormAgregarProductoAFactura();
            agregarProducto.StartPosition = FormStartPosition.CenterScreen;
            agregarProducto.ShowDialog();

            if(agregarProducto.DialogResult == DialogResult.OK)
            {
                txtCodigoGenerarFactura.Text = agregarProducto.dataGridView1.Rows[agregarProducto.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtDescripcionGenerarFactura.Text = agregarProducto.dataGridView1.Rows[agregarProducto.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();

                //Administrador--------------------------------------------------------------------------------------------------------------------

                txtValUniGenerarFactura.Text = agregarProducto.dataGridView1.Rows[agregarProducto.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();

                //JUDYSOFT-------------------------------------------------------------------------------------------------------------------------

                //txtValUni.Text = agregarProducto.dataGridView1.Rows[agregarProducto.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();

                txtCantidadGenerarFactura.Text = "";
                txtCantidadGenerarFactura.Focus();



            }


            //this.Hide();
        }

        private void Limpiar()
        {
            txtCantidadGenerarFactura.Text = "";
            txtCodigoGenerarFactura.Text = "";
            txtDescripcionGenerarFactura.Text = "";
            txtDireccionGenerarFactura.Text = "";
            txtidClienteGenerarFactura.Text = "";
            txtBoxClienteGenerarFactura.Text = "";
            txtSubtotalGenerarFactura.Text = "";
            txtTelefonoGenerarFactura.Text = "";
            txtValUniGenerarFactura.Text = "";
            txtImpuestoGenerarFactura.Text = "";
            txtTotalGenerarFactura.Text = "";
            lblClienteGenerarFactura.Text = "";

            comboBoxTAX.SelectedIndex = -1;
            DGVGenerarFactura.Rows.Clear();
            contFila = 0;
            total = 0;

            txtidClienteGenerarFactura.Focus();
        }

        private void botonNuevaFactura_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void botonListaClientesGenerarFactura_Click(object sender, EventArgs e)
        {
            FormListaClientes nuevaLista = new FormListaClientes();
            nuevaLista.StartPosition = FormStartPosition.CenterScreen;
            nuevaLista.ShowDialog();


            if (nuevaLista.DialogResult == DialogResult.OK)
            {
                //Administración-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                txtidClienteGenerarFactura.Text = nuevaLista.dataGridView1.Rows[nuevaLista.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtBoxClienteGenerarFactura.Text = nuevaLista.dataGridView1.Rows[nuevaLista.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString() +" "+ nuevaLista.dataGridView1.Rows[nuevaLista.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                txtDireccionGenerarFactura.Text = nuevaLista.dataGridView1.Rows[nuevaLista.dataGridView1.CurrentRow.Index].Cells[12].Value.ToString();
                txtTelefonoGenerarFactura.Text = nuevaLista.dataGridView1.Rows[nuevaLista.dataGridView1.CurrentRow.Index].Cells[13].Value.ToString();

                //JUDYSOFT----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                //txtidCliente.Text = nuevaLista.dataGridView1.Rows[nuevaLista.dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
                //txtBoxCliente.Text = nuevaLista.dataGridView1.Rows[nuevaLista.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString() +" "+ nuevaLista.dataGridView1.Rows[nuevaLista.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString()+" "+ nuevaLista.dataGridView1.Rows[nuevaLista.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString()+" "+ nuevaLista.dataGridView1.Rows[nuevaLista.dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                //txtDireccion.Text = nuevaLista.dataGridView1.Rows[nuevaLista.dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();
                //txtTelefono.Text = nuevaLista.dataGridView1.Rows[nuevaLista.dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();

                txtCodigoGenerarFactura.Focus();

            }
        }
        double montoTotal;
        

        public void CalculoMontoTotalGenerarFactura(string tax, string Subt)
        {
            montoTotal = (Convert.ToDouble(Subt) * Convert.ToDouble(tax)) + Convert.ToDouble(Subt);
            txtTotalGenerarFactura.Text = montoTotal.ToString();
        }

        private void botonNuevaFacturaGenerarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                //Administración------------------------------------------------------------------------------------------------------------------------------------------------------------------
                string cmd = string.Format("Exec ActualizarFactura '{0}'", txtidClienteGenerarFactura.Text.Trim());
                DataSet DS = Utilidades.Ejecutar(cmd);

                string NumFac = DS.Tables[0].Rows[0]["NumFactura"].ToString().Trim();

                foreach(DataGridViewRow Fila in DGVGenerarFactura.Rows)
                {
                    cmd = string.Format("Exec ActualizarDetalle '{0}','{1}','{2}','{3}','{4}','{6}'", NumFac, Fila.Cells[0].Value.ToString(), Fila.Cells[3].Value.ToString(), Fila.Cells[1].Value.ToString(), txtSubtotalGenerarFactura.Text.ToString(), txtTotalGenerarFactura.Text.ToString());
                    DS = Utilidades.Ejecutar(cmd);
                     
                }

                cmd = "Exec DatosFacturaAct " + NumFac;
                DS = Utilidades.Ejecutar(cmd);
                //JUDYSOFT------------------------------------------------------------------------------------------------------------------------------------------------------------------------


                ReporteFactura report = new ReporteFactura();
                report.reportViewer1.LocalReport.DataSources[0].Value = DS.Tables[0];
                report.ShowDialog();
                Limpiar();



            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtCodigoGenerarFactura_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void BotonEliminarGenerarfactura_Click(object sender, EventArgs e)
        {
            if (contFila > 0)
            {
                string message = "¿Está seguro de eliminar el objeto?";
                string caption = "Advertencia";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    total = total - (Convert.ToDouble(DGVGenerarFactura.Rows[DGVGenerarFactura.CurrentRow.Index].Cells[4].Value));
                    txtSubtotalGenerarFactura.Text = total.ToString();

                    DGVGenerarFactura.Rows.RemoveAt(DGVGenerarFactura.CurrentRow.Index);
                    contFila--;


                }

            }

            else
            {
                MessageBox.Show("No hay elementos a eliminar.", "Advertencia");
            }
        }

        private void comboBoxTAX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTAX.SelectedIndex == 0)
            {
                txtImpuestoGenerarFactura.Text = "0.12";
                CalculoMontoTotalGenerarFactura(txtImpuestoGenerarFactura.Text, txtSubtotalGenerarFactura.Text);
            }
            else if (comboBoxTAX.SelectedIndex == 1)
            {
                txtImpuestoGenerarFactura.Text = "0.14";
                CalculoMontoTotalGenerarFactura(txtImpuestoGenerarFactura.Text, txtSubtotalGenerarFactura.Text);
            }
            else
            {
                return;
            }
        }
    }
}
