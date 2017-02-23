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
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.prueba' Puede moverla o quitarla según sea necesario.
            //this.pruebaTableAdapter.Fill(this.DataSet1.prueba);

            this.reportViewer1.RefreshReport();
        }
    }
}
