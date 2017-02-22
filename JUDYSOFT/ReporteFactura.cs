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
    public partial class ReporteFactura : Form
    {
        public ReporteFactura()
        {
            InitializeComponent();
        }

        private void ReporteFactura_Load(object sender, EventArgs e)
        {

    
        }

        private void ReporteFactura_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet2.DatosFactura' Puede moverla o quitarla según sea necesario.
            this.DatosFacturaTableAdapter.Fill(this.DataSet2.DatosFactura);

            reportViewer1.RefreshReport();
        }
    }
}
