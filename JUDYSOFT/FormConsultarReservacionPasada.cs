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
            SqlDataAdapter SDA = new SqlDataAdapter();
            BindingSource bs = new BindingSource();
            tablaReservacionesPasadas.DataSource  = bs;
            Utilidades.GetData("SELECT R.CODRESERVACION,C.NOMBRE1CLIENTE,C.APELLIDO1CLIENTE,R.FECHAINGRESORESERVACION,R.FECHASALIDARESERVACION "+
                               "FROM  CLIENTE C JOIN RESERVACION R "+
                               "ON R.CODCLIENTE = C.CODCLIENTEWHERE R.FECHASALIDARESERVACION < GETDATE()",bs,SDA);
            tablaReservacionesPasadas.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void tablaReservacionesPasadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        
    }

}