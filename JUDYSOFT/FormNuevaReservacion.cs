using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JUDYSOFT
{
    public partial class FormNuevaReservacion : Form
    {
        Validaciones val = new Validaciones();
        public FormNuevaReservacion()
        {
            InitializeComponent();
            this.fechaArrivoNuevaReservacion.Value = DateTime.Now;
            this.fechaSalidaNuevaReservacion.Value = DateTime.Now;


        }

        private void botonReservacion_Click(object sender, EventArgs e)
        {


            if (this.fechaSalidaNuevaReservacion.Value.Year < this.fechaArrivoNuevaReservacion.Value.Year)
            {
                MessageBox.Show("La fecha de salida no puede ser anterior a la fecha de llegada del cliente",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.fechaSalidaNuevaReservacion.Value.Month < this.fechaArrivoNuevaReservacion.Value.Month)
            {
                MessageBox.Show("La fecha de salida no puede ser anterior a la fecha de llegada del cliente",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.fechaSalidaNuevaReservacion.Value.Day < this.fechaArrivoNuevaReservacion.Value.Day)
            {
                MessageBox.Show("La fecha de salida no puede ser anterior a la fecha de llegada del cliente",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Codigo de ingreso de la reserva a la base de datos
            }



        }

        private void botonCancelarReservacion_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormListaClientes nueva = new FormListaClientes();
            nueva.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tBoxNumeroIdClienteNuevareservacion.TextLength == 10 || tBoxNumeroIdClienteNuevareservacion.TextLength == 8) { }
            else
            {
                MessageBox.Show("Recuerde que una cédula contiene 10 dígitos y un pasporte 8 dígitos",
                                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            if (Convert.ToInt32(tBoxNumeroIdClienteNuevareservacion.Text.Length) == 10
                && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (val.validarCamposNumericos(e, tBoxNumeroIdClienteNuevareservacion))
            {
                return;

            }

        }

        private void tBoxNumeroAdultosNuevaReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(tBoxNumeroAdultosNuevaReserva.Text.Length) == 2
                && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (val.validarCamposNumericos(e, tBoxNumeroAdultosNuevaReserva))
            {
                return;

            }
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

        private void tBoxNumeroIdClienteNuevareservacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
