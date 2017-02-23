using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria;

namespace JUDYSOFT
{
    public partial class FormReservas : Form
    {
        
        public FormReservas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reservacionesPasadas nueva = new reservacionesPasadas();
            nueva.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Está seguro que desea cancelar la reserva?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            String idR = tablaReservaciones.Rows[tablaReservaciones.CurrentRow.Index].Cells[0].Value.ToString();
            DataSet DS;
            string cmd = string.Format("DELETE FROM RESERVACION WHERE CODRESERVACION = {0}",idR);
            DS = Utilidades.Ejecutar(cmd);
            tablaRefresco();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            FormNuevaReservacion nueva = new FormNuevaReservacion();
            nueva.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormReservas_Load(object sender, EventArgs e)
        {
            tablaRefresco();
        }

        public void tablaRefresco()
        {
            tablaReservaciones.DataSource = LLenarDGv().Tables[0];
            tablaReservaciones.Columns[0].HeaderCell.Value = "Código de Reservación";
            tablaReservaciones.Columns[1].HeaderCell.Value = "Apellido Cliente";
            tablaReservaciones.Columns[2].HeaderCell.Value = "Nombre Cliente";
            tablaReservaciones.Columns[3].HeaderCell.Value = "Fecha de Ingreso";
            tablaReservaciones.Columns[4].HeaderCell.Value = "Fecha de Salida";
        }

        private DataSet LLenarDGv()
        {
            DataSet DS;
            string cmd = string.Format("SELECT CODRESERVACION,APELLIDO1CLIENTE,NOMBRE1CLIENTE,FECHAINGRESORESERVACION,FECHASALIDARESERVACION "+
                "FROM RESERVACION R JOIN CLIENTE C ON R.CODCLIENTE = C.CODCLIENTE "+
                "WHERE FECHASALIDARESERVACION >= GETDATE()");
            DS = Utilidades.Ejecutar(cmd);
            return DS;
        }

        private void FormReservas_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Esta seguro que desea salir", "JUDYSOFT", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (confirmacion == System.Windows.Forms.DialogResult.OK)
            {
                Dispose();
                MenuSettings.EnableMenuItem("habitacionesToolStripMenuItem","reservacionesToolStripMenuItem");
            }
        }

        private void tablaReservaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

    }
}
