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
        public FormNuevaReservacion()
        {
            InitializeComponent();
        }

        private void botonReservacion_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void botonCancelarReservacion_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormConsultarReservacionPasada reservacionPasada = new FormConsultarReservacionPasada();
            
        }

        private void tBoxNumeroIdClienteNuevareservacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
