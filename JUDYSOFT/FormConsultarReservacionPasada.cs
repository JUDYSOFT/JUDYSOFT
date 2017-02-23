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
    public partial class reservacionesPasadas : Form
    {
        

        public reservacionesPasadas()
        {
            InitializeComponent();

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void reservacionesPasadas_Load(object sender, EventArgs e)
        {
            tablaRefresco();
        }

        public void tablaRefresco()
        {
            tablaReservacionesPasadas.DataSource = LLenarDGv().Tables[0];
            tablaReservacionesPasadas.Columns[0].HeaderCell.Value = "Código de Reservación";
            tablaReservacionesPasadas.Columns[1].HeaderCell.Value = "Apellido Cliente";
            tablaReservacionesPasadas.Columns[2].HeaderCell.Value = "Nombre Cliente";
            tablaReservacionesPasadas.Columns[3].HeaderCell.Value = "Fecha de Ingreso";
            tablaReservacionesPasadas.Columns[4].HeaderCell.Value = "Fecha de Salida";
        }

        private DataSet LLenarDGv()
        {
            DataSet DS;
            string cmd = string.Format("SELECT CODRESERVACION,APELLIDO1CLIENTE,NOMBRE1CLIENTE,FECHAINGRESORESERVACION,FECHASALIDARESERVACION " +
                "FROM RESERVACION R JOIN CLIENTE C ON R.CODCLIENTE = C.CODCLIENTE " +
                "WHERE FECHASALIDARESERVACION < GETDATE()");
            DS = Utilidades.Ejecutar(cmd);
            return DS;
        }

        private void tablaReservacionesPasadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        
    }

}