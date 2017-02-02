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

namespace JUDYSOFT
{

    
    public partial class frmLogin : Form
    {
        public static String Codigo = "";
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;

        }

       
        private void btningresar_Click(object sender, EventArgs e)
        {
            
            frmMenuPrincipal frmHab = new frmMenuPrincipal();
            this.Visible=false;
            frmHab.Show();
            this.FormClosing += Form1_FormClosing;

            SqlConnection con = new SqlConnection("Data Source=LENOVO-PC\\SQLEXPRESS;Initial Catalog=Administracion;Integrated Security=True");
            con.Open();
            MessageBox.Show("conexion exitosa");
            con.Close();


        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }
    }
}
