using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data;
using Libreria;

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
           
            if (txtpass.Text.Trim()!="" || txtuser.Text.Trim()!="") {
                try {
                    string CMD = string.Format("SELECT * FROM EMPLEADO WHERE USUARIO = '{0}' AND PASSWORD = '{1}'", txtuser.Text.Trim(), txtpass.Text.Trim());
                    DataSet ds = Utilidades.Ejecutar(CMD);
                    string cuenta = ds.Tables[0].Rows[0]["USUARIO"].ToString().Trim();
    
                    string psd = ds.Tables[0].Rows[0]["PASSWORD"].ToString().Trim();
                    Codigo = ds.Tables[0].Rows[0]["CODEMPLEADO"].ToString().Trim();

                    if (cuenta == txtuser.Text.Trim() && psd == txtpass.Text.Trim())
                    {
                        frmMenuPrincipal frmHab = new frmMenuPrincipal();
                        Visible = false;
                        frmHab.Show();
                        FormClosing += Form1_FormClosing;
                    }
                    else if(cuenta!=txtuser.Text.Trim() || psd!=txtpass.Text.Trim())
                    {
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos","JUDYSOFT",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el Usuario y su Contraseña: ","JUDYSOFT");

            }



        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }
    }
}
