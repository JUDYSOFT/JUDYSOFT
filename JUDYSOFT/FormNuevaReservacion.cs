using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Libreria;

namespace JUDYSOFT
{
    public partial class FormNuevaReservacion : Form
    {
        FormReservas obj = (FormReservas)Application.OpenForms["FormReservas"];
        Validaciones val = new Validaciones();
        public FormNuevaReservacion()
        {
            InitializeComponent();
            fechaArrivoNuevaReservacion.Value = DateTime.Now;
            fechaSalidaNuevaReservacion.Value = DateTime.Now;
        }

        private void botonReservacion_Click(object sender, EventArgs e)
        {
            if (fechaSalidaNuevaReservacion.Value.Date < fechaArrivoNuevaReservacion.Value.Date)
            {
                MessageBox.Show("La fecha de salida no puede ser anterior a la fecha de llegada del cliente",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(tBoxNumeroIdClienteNuevareservacion.Text == "")
            {
                MessageBox.Show("El campo de Identificación no puede estar vacío",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (tBoxNumeroIdClienteNuevareservacion.Text.Length != 10)
            {
                MessageBox.Show("El campo de Identificación debe contener 10 dígitos ",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(tBoxNumeroNiniosNuevaReserva.Text==""|| tBoxNumeroAdultosNuevaReserva.Text == "")
            {
                MessageBox.Show("Algún campo de número de personas se encuentra vacío",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                DataSet DS;
                string cmd1 = string.Format("SELECT CODCLIENTE FROM CLIENTE WHERE NUMERODOCUMENTOIDENTIFICACIONCLIENTE = {0}",tBoxNumeroIdClienteNuevareservacion.Text);
                DS = Utilidades.Ejecutar(cmd1);
                int codCliente = Convert.ToInt32(DS.Tables[0].Rows[0]["CODCLIENTE"].ToString().Trim());
                try
                {
                    
                    {
                        cmd1 = string.Format("INSERT INTO RESERVACION VALUES (" +
                            codCliente + ",'"
                            + fechaArrivoNuevaReservacion.Value.Year.ToString() + "-"
                            + fechaArrivoNuevaReservacion.Value.Month.ToString()+"-"
                            + fechaArrivoNuevaReservacion.Value.Day.ToString()+"','"
                            + fechaSalidaNuevaReservacion.Value.Year.ToString() + "-"
                            + fechaSalidaNuevaReservacion.Value.Month.ToString() + "-"
                            + fechaSalidaNuevaReservacion.Value.Day.ToString() + "')");
                        DS = Utilidades.Ejecutar(cmd1);
                        MessageBox.Show("Reserva Ingresada Correctamente", "JUDYSOFT");
                        obj.tablaRefresco();
                        Dispose();       
                    }

                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }

        private void botonCancelarReservacion_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Está seguro que desea cancelar?", "JUDYSOFT", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (confirmacion == System.Windows.Forms.DialogResult.OK)
            {
                Dispose();
                MenuSettings.EnableMenuItem("clientesToolStripMenuItem", "ingresarNuevoClienteToolStripMenuItem");
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormListaClientes frm = new FormListaClientes();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Normal;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                tBoxNombreClienteNuevaReservacion.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[3].Value.ToString()+" "
                    + frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[1].Value.ToString();
                tBoxNumeroIdClienteNuevareservacion.Text = frm.dataGridViewModificarClientes.Rows[frm.dataGridViewModificarClientes.CurrentRow.Index].Cells[6].Value.ToString();


                habilitarCampos();
                tBoxNumeroIdClienteNuevareservacion.BackColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd3 = string.Format("select * from CLIENTE where NUMERODOCUMENTOIDENTIFICACIONCLIENTE= '{0}' ",tBoxNumeroIdClienteNuevareservacion.Text);
                DataSet DS3 = Utilidades.Ejecutar(cmd3);
                if (DS3.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("El cliente no se encuentra registrado en la base de datos", "JUDYSOFT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tBoxNombreClienteNuevaReservacion.Text = DS3.Tables[0].Rows[0]["APELLIDO1CLIENTE"].ToString().Trim()+" "+ DS3.Tables[0].Rows[0]["NOMBRE1CLIENTE"].ToString().Trim();
                    
                }

              

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void habilitarCampos()
        {
            
            fechaArrivoNuevaReservacion.Enabled = true;
            fechaSalidaNuevaReservacion.Enabled = true;
            tBoxNumeroAdultosNuevaReserva.Enabled = true;
            tBoxNumeroNiniosNuevaReserva.Enabled = true;
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tBoxNumeroIdClienteNuevareservacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormNuevaReservacion_Load(object sender, EventArgs e)
        {

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxNumeroIdClienteNuevareservacion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            

            if (Convert.ToInt32(tBoxNumeroIdClienteNuevareservacion.Text.Length) == 10 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (val.validarCamposNumericos(e, tBoxNumeroIdClienteNuevareservacion))
                return;

        }

        

        private void tBoxNumeroNiniosNuevaReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(tBoxNumeroNiniosNuevaReserva.Text.Length) == 2
                && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (val.validarCamposNumericos(e, tBoxNumeroNiniosNuevaReserva))
            {
                return;

            }
        }

        private void FormNuevaReservacion_Load_1(object sender, EventArgs e)
        {
            fechaArrivoNuevaReservacion.Enabled = false;
            fechaSalidaNuevaReservacion.Enabled = false;
            tBoxNumeroAdultosNuevaReserva.Enabled = false;
            tBoxNumeroNiniosNuevaReserva.Enabled = false;
            tBoxNombreClienteNuevaReservacion.Enabled = false;
        }

        private void tBoxNumeroIdClienteNuevareservacion_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}