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
    public partial class frmOpcionHab : Form
    {
        clsHabitacion objHab = new clsHabitacion();
        public frmOpcionHab()
        {
            System.Drawing.Bitmap limpieza = JUDYSOFT.Properties.Resources.l;
            System.Drawing.Bitmap disponible = JUDYSOFT.Properties.Resources.a;
            System.Drawing.Bitmap ocupado = JUDYSOFT.Properties.Resources.o;
            InitializeComponent();
            btnocupado.TextImageRelation = TextImageRelation.TextAboveImage;
            btndisponible.TextImageRelation = TextImageRelation.TextAboveImage;
            button3.TextImageRelation = TextImageRelation.TextAboveImage;
            try
            {
                btnocupado.Image = ocupado;   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            try
            {
                btndisponible.Image = disponible;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            try
            {
                button3.Image = limpieza;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            objHab.Estado = "Ocupado";
            btnlistar.Text = "Clientes";
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void frmOpcionHab_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        internal void LoadNumeroHabitacion(String numHabitacion)
        {
            lblHabitacion.Text = "Habitacion: " + numHabitacion;
            objHab.Numero = numHabitacion;           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnlistar.Text = "Empleados";
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            groupBox1.Enabled=false;
            try
            {
                string CMD = string.Format("UPDATE HABITACION SET ESTADOHABITACION='Disponible' WHERE NUMEROHABITACION='{0}'", objHab.Numero);
                DataSet ds = Utilidades.Ejecutar(CMD);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            btnlistar.Text = "Clientes";
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            frmNomina Listar = new frmNomina();
            Listar.LoadTipoNomina(btnlistar.Text.Trim());
            Listar.ShowDialog();
            Listar.StartPosition = FormStartPosition.CenterScreen;

            if (Listar.dataGridViewNomina.Rows.Count != 0)
            {
                textBox1.Text = Listar.dataGridViewNomina.Rows[Listar.dataGridViewNomina.CurrentRow.Index].Cells[0].Value.ToString();
                textBox2.Text = Listar.dataGridViewNomina.Rows[Listar.dataGridViewNomina.CurrentRow.Index].Cells[2].Value.ToString();
                textBox3.Text = Listar.dataGridViewNomina.Rows[Listar.dataGridViewNomina.CurrentRow.Index].Cells[4].Value.ToString();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox1.Text==null)
            {
                MessageBox.Show("Debe Seleccionar un Cliente","JUDYSOFT");
            }
            else
            {
                switch (btnlistar.Text)
                {
                    case "Clientes":
                        try
                        {
                            string CMD1 = string.Format("SELECT CODCLIENTE FROM CLIENTE WHERE NUMERODOCUMENTOCLIENTE='{0}'", textBox1.Text.Trim());
                            DataSet ds1 = Utilidades.Ejecutar(CMD1);
                            string CodCliente = ds1.Tables[0].Rows[0]["CODCLIENTE"].ToString().Trim();
                            string CMD = string.Format("UPDATE HABITACION SET ESTADOHABITACION='Ocupado',CODCLIENTE='{0}' WHERE NUMEROHABITACION='{1}'", CodCliente,objHab.Numero);
                            DataSet ds = Utilidades.Ejecutar(CMD);
                            Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                        break;
                    case "Empleados":
                        try
                        {
                            string CMD1 = string.Format("SELECT CODEMPLEADO FROM EMPLEADO WHERE NUMERODOCUMENTOEMPLEADO='{0}'", textBox1.Text.Trim());
                            DataSet ds1 = Utilidades.Ejecutar(CMD1);
                            string CodEmpleado = ds1.Tables[0].Rows[0]["CODEMPLEADO"].ToString().Trim();
                            string CMD = string.Format("UPDATE HABITACION SET ESTADOHABITACION='Limpieza' WHERE NUMEROHABITACION='{0}'", objHab.Numero);
                            DataSet ds = Utilidades.Ejecutar(CMD);
                            Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                        break;
                    default:break;
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}

