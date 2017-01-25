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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
            frmAdministracionHabitaciones frmAdmin= new frmAdministracionHabitaciones();
            frmAdmin.MdiParent = this;
            frmAdmin.Show();
        }

        private void acercaEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
