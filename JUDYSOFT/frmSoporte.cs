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
    public partial class frmAcerca : Form
    {
        public frmAcerca()
        {
            InitializeComponent();
        }

        private void frmSoporte_Load(object sender, EventArgs e)
        {
            label1.Text="JUDYSOFT V 1.0\nDesarrolladores\nAlexis Miranda\nBryan Lema\nJose Limaico\nDanni Brito\nAndres Salazar";
        }

        private void frmAcerca_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuSettings.EnableMenuItem("ayudaToolStripMenuItem", "acercaEToolStripMenuItem");
        }
    }
}
