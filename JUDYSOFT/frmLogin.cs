﻿using System;
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

            try
            {
                string CMD = string.Format("SELECT * FROM usuario WHERE Cuenta = '{0}' AND password = '{1}'", txtuser.Text.Trim(), txtpass.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(CMD);
                string cuenta = ds.Tables[0].Rows[0]["Cuenta"].ToString().Trim();
                string psd = ds.Tables[0].Rows[0]["password"].ToString().Trim();
                Codigo = ds.Tables[0].Rows[0]["idUsuario"].ToString().Trim();
                
                if (cuenta == txtuser.Text.Trim() && psd == txtpass.Text.Trim())
                   {
                    frmMenuPrincipal frmHab = new frmMenuPrincipal();
                    this.Visible = false;
                    frmHab.Show();
                    this.FormClosing += Form1_FormClosing;
                   }
                
                
                
                            }
            catch (Exception ex)
             {
                MessageBox.Show("Error: " + ex.Message);
                            }


            //frmMenuPrincipal frm = new frmMenuPrincipal();
            //frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
            
            


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
