using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria;


namespace JUDYSOFT
{

    public partial class frmAdministracionHabitaciones : Form
    {
        //Habitaciones
        private clsHabitacion objHab15 = new clsHabitacion();
        private clsHabitacion objHab16 = new clsHabitacion();
        private clsHabitacion objHab17 = new clsHabitacion();
        private clsHabitacion objHab18 = new clsHabitacion();
        private clsHabitacion objHab19 = new clsHabitacion();
        private clsHabitacion objHab20 = new clsHabitacion();
        private clsHabitacion objHab21 = new clsHabitacion();
        private clsHabitacion objHab22 = new clsHabitacion();
        private clsHabitacion objHab23 = new clsHabitacion();
        private clsHabitacion objHab24 = new clsHabitacion();
        private clsHabitacion objHab25 = new clsHabitacion();
        private clsHabitacion objHab26 = new clsHabitacion();
        private clsHabitacion objHab27 = new clsHabitacion();
        public event FormClosingEventHandler FormClosing;
        public frmAdministracionHabitaciones()
        {
            objHab15.Numero = "15";
            objHab16.Numero = "16";
            objHab17.Numero = "17";
            objHab18.Numero = "18";
            objHab19.Numero = "19";
            objHab20.Numero = "20";
            objHab21.Numero = "21";
            objHab22.Numero = "22";
            objHab23.Numero = "23";
            objHab24.Numero = "24";
            objHab25.Numero = "25";
            objHab26.Numero = "26";
            objHab27.Numero = "27";

            DateTime thisDay = DateTime.Today;
            InitializeComponent();
            btnh15.Text = "Habitacion 15 Matrimonial";
            btnh15.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh16.Text = "Habitacion 16 Matrimonial";
            btnh16.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh17.Text = "Habitacion 17 Matrimonial";
            btnh17.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh18.Text = "Habitacion 18 Matrimonial";
            btnh18.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh19.Text = "Habitacion 19 Doble";
            btnh19.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh20.Text = "Habitacion 20 Triple";
            btnh20.TextImageRelation = TextImageRelation.TextAboveImage;

            //Segundo Piso

            btnh21.Text = "Habitacion 21 Matrimonial";
            btnh21.TextImageRelation = TextImageRelation.TextAboveImage;
            groupBox1.BackColor = Color.Transparent;

            btnh22.Text = "Habitacion 22 Matrimonial";
            btnh22.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh23.Text = "Habitacion 23 Matrimonial";
            btnh23.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh24.Text = "Habitacion 24 Matrimonial";
            btnh24.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh25.Text = "Habitacion 25 Matrimonial";
            btnh25.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh26.Text = "Habitacion 26 Doble";
            btnh26.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh27.Text = "Habitacion 27 Triple";
            btnh27.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh15.Cursor = Cursors.Hand;
            lblh15.BackColor = Color.Silver;

            btnh16.Cursor = Cursors.Hand;
            lblh16.BackColor = Color.Silver;

            btnh17.Cursor = Cursors.Hand;
            lblh17.BackColor = Color.Silver;

            btnh17.Cursor = Cursors.Hand;
            lblh17.BackColor = Color.Silver;

            btnh18.Cursor = Cursors.Hand;
            lblh18.BackColor = Color.Silver;

            btnh19.Cursor = Cursors.Hand;
            lblh19.BackColor = Color.Silver;

            btnh20.Cursor = Cursors.Hand;
            lblh20.BackColor = Color.Silver;

            btnh21.Cursor = Cursors.Hand;
            lblh21.BackColor = Color.Silver;

            btnh22.Cursor = Cursors.Hand;
            lblh22.BackColor = Color.Silver;

            btnh23.Cursor = Cursors.Hand;
            lblh23.BackColor = Color.Silver;

            btnh24.Cursor = Cursors.Hand;
            lblh24.BackColor = Color.Silver;

            btnh25.Cursor = Cursors.Hand;
            lblh25.BackColor = Color.Silver;

            btnh26.Cursor = Cursors.Hand;
            lblh26.BackColor = Color.Silver;

            btnh27.Cursor = Cursors.Hand;
            lblh27.BackColor = Color.Silver;
             
        }

        public void actualizarHabitaciones()
        {
            System.Drawing.Bitmap limpieza = JUDYSOFT.Properties.Resources.l;
            System.Drawing.Bitmap disponible = JUDYSOFT.Properties.Resources.a;
            System.Drawing.Bitmap ocupado = JUDYSOFT.Properties.Resources.o;
            try
            {
                string CMD = string.Format("SELECT ESTADOHABITACION FROM HABITACION WHERE NUMEROHABITACION='{0}'", objHab15.Numero);
                DataSet ds = Utilidades.Ejecutar(CMD);
                objHab15.Estado = ds.Tables[0].Rows[0]["ESTADOHABITACION"].ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            try
            {
                string CMD = string.Format("SELECT ESTADOHABITACION FROM HABITACION WHERE NUMEROHABITACION='{0}'", objHab16.Numero);
                DataSet ds = Utilidades.Ejecutar(CMD);
                objHab16.Estado = ds.Tables[0].Rows[0]["ESTADOHABITACION"].ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            try
            {
                string CMD = string.Format("SELECT ESTADOHABITACION FROM HABITACION WHERE NUMEROHABITACION='{0}'", objHab17.Numero);
                DataSet ds = Utilidades.Ejecutar(CMD);
                objHab17.Estado = ds.Tables[0].Rows[0]["ESTADOHABITACION"].ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            try
            {
                string CMD = string.Format("SELECT ESTADOHABITACION FROM HABITACION WHERE NUMEROHABITACION='{0}'", objHab18.Numero);
                DataSet ds = Utilidades.Ejecutar(CMD);
                objHab18.Estado = ds.Tables[0].Rows[0]["ESTADOHABITACION"].ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            try
            {
                string CMD = string.Format("SELECT ESTADOHABITACION FROM HABITACION WHERE NUMEROHABITACION='{0}'", objHab19.Numero);
                DataSet ds = Utilidades.Ejecutar(CMD);
                objHab19.Estado = ds.Tables[0].Rows[0]["ESTADOHABITACION"].ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            try
            {
                string CMD = string.Format("SELECT ESTADOHABITACION FROM HABITACION WHERE NUMEROHABITACION='{0}'", objHab20.Numero);
                DataSet ds = Utilidades.Ejecutar(CMD);
                objHab20.Estado = ds.Tables[0].Rows[0]["ESTADOHABITACION"].ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            try
            {
                string CMD = string.Format("SELECT ESTADOHABITACION FROM HABITACION WHERE NUMEROHABITACION='{0}'", objHab21.Numero);
                DataSet ds = Utilidades.Ejecutar(CMD);
                objHab21.Estado = ds.Tables[0].Rows[0]["ESTADOHABITACION"].ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            try
            {
                string CMD = string.Format("SELECT ESTADOHABITACION FROM HABITACION WHERE NUMEROHABITACION='{0}'", objHab22.Numero);
                DataSet ds = Utilidades.Ejecutar(CMD);
                objHab22.Estado = ds.Tables[0].Rows[0]["ESTADOHABITACION"].ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            try
            {
                string CMD = string.Format("SELECT ESTADOHABITACION FROM HABITACION WHERE NUMEROHABITACION='{0}'", objHab23.Numero);
                DataSet ds = Utilidades.Ejecutar(CMD);
                objHab23.Estado = ds.Tables[0].Rows[0]["ESTADOHABITACION"].ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            try
            {
                string CMD = string.Format("SELECT ESTADOHABITACION FROM HABITACION WHERE NUMEROHABITACION='{0}'", objHab24.Numero);
                DataSet ds = Utilidades.Ejecutar(CMD);
                objHab24.Estado = ds.Tables[0].Rows[0]["ESTADOHABITACION"].ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            try
            {
                string CMD = string.Format("SELECT ESTADOHABITACION FROM HABITACION WHERE NUMEROHABITACION='{0}'", objHab25.Numero);
                DataSet ds = Utilidades.Ejecutar(CMD);
                objHab25.Estado = ds.Tables[0].Rows[0]["ESTADOHABITACION"].ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            try
            {
                string CMD = string.Format("SELECT ESTADOHABITACION FROM HABITACION WHERE NUMEROHABITACION='{0}'", objHab26.Numero);
                DataSet ds = Utilidades.Ejecutar(CMD);
                objHab26.Estado = ds.Tables[0].Rows[0]["ESTADOHABITACION"].ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            try
            {
                string CMD = string.Format("SELECT ESTADOHABITACION FROM HABITACION WHERE NUMEROHABITACION='{0}'", objHab27.Numero);
                DataSet ds = Utilidades.Ejecutar(CMD);
                objHab27.Estado = ds.Tables[0].Rows[0]["ESTADOHABITACION"].ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //Habitacion 15
            try
            {
                switch (objHab15.Estado.Trim())
                {
                    case "Ocupado":
                        btnh15.Image = ocupado;
                        lblh15.Text = "Ocupado";
                        lblh15.BackColor = Color.FromArgb(230, 115, 130);
                        break;
                    case "Limpieza":
                        lblh15.Text = "Limpieza";
                        lblh15.BackColor = Color.FromArgb(200, 200, 180);
                        btnh15.Image = limpieza;
                        break;
                    case "Disponible":
                        lblh15.Text = "Disponible";
                        lblh15.BackColor = Color.FromArgb(110, 205, 228);
                        btnh15.Image = disponible;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            //Habitacion 16
            try
            {
                switch (objHab16.Estado.Trim())
                {
                    case "Ocupado":
                        btnh16.Image = ocupado;
                        lblh16.Text = "Ocupado";
                        lblh16.BackColor = Color.FromArgb(230, 115, 130);
                        break;
                    case "Limpieza":
                        lblh16.Text = "Limpieza";
                        lblh16.BackColor = Color.FromArgb(200, 200, 180);
                        btnh16.Image = limpieza;
                        break;
                    case "Disponible":
                        lblh16.Text = "Disponible";
                        lblh16.BackColor = Color.FromArgb(110, 205, 228);
                        btnh16.Image = disponible;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            //Habitacion 17
            try
            {
                switch (objHab17.Estado.Trim())
                {
                    case "Ocupado":
                        btnh17.Image = ocupado;
                        lblh17.Text = "Ocupado";
                        lblh17.BackColor = Color.FromArgb(230, 115, 130);
                        break;
                    case "Limpieza":
                        lblh17.Text = "Limpieza";
                        lblh17.BackColor = Color.FromArgb(200, 200, 180);
                        btnh17.Image = limpieza;
                        break;
                    case "Disponible":
                        lblh17.Text = "Disponible";
                        lblh17.BackColor = Color.FromArgb(110, 205, 228);
                        btnh17.Image = disponible;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            //Habitacion 18
            try
            {
                switch (objHab18.Estado.Trim())
                {
                    case "Ocupado":
                        btnh18.Image = ocupado;
                        lblh18.Text = "Ocupado";
                        lblh18.BackColor = Color.FromArgb(230, 115, 130);
                        break;
                    case "Limpieza":
                        lblh18.Text = "Limpieza";
                        lblh18.BackColor = Color.FromArgb(200, 200, 180);
                        btnh18.Image = limpieza;
                        break;
                    case "Disponible":
                        lblh18.Text = "Disponible";
                        lblh18.BackColor = Color.FromArgb(110, 205, 228);
                        btnh18.Image = disponible;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            //Habitacion 19
            try
            {
                switch (objHab19.Estado.Trim())
                {
                    case "Ocupado":
                        btnh19.Image = ocupado;
                        lblh19.Text = "Ocupado";
                        lblh19.BackColor = Color.FromArgb(230, 115, 130);
                        break;
                    case "Limpieza":
                        lblh19.Text = "Limpieza";
                        lblh19.BackColor = Color.FromArgb(200, 200, 180);
                        btnh19.Image = limpieza;
                        break;
                    case "Disponible":
                        lblh19.Text = "Disponible";
                        lblh19.BackColor = Color.FromArgb(110, 205, 228);
                        btnh19.Image = disponible;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            //Habitacion 20
            try
            {
                switch (objHab20.Estado.Trim())
                {
                    case "Ocupado":
                        btnh20.Image = ocupado;
                        lblh20.Text = "Ocupado";
                        lblh20.BackColor = Color.FromArgb(230, 115, 130);
                        break;
                    case "Limpieza":
                        lblh20.Text = "Limpieza";
                        lblh20.BackColor = Color.FromArgb(200, 200, 180);
                        btnh20.Image = limpieza;
                        break;
                    case "Disponible":
                        lblh20.Text = "Disponible";
                        lblh20.BackColor = Color.FromArgb(110, 205, 228);
                        btnh20.Image = disponible;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            //Habitacion 21
            try
            {
                switch (objHab21.Estado.Trim())
                {
                    case "Ocupado":
                        btnh21.Image = ocupado;
                        lblh21.Text = "Ocupado";
                        lblh21.BackColor = Color.FromArgb(230, 115, 130);
                        break;
                    case "Limpieza":
                        lblh21.Text = "Limpieza";
                        lblh21.BackColor = Color.FromArgb(200, 200, 180);
                        btnh21.Image = limpieza;
                        break;
                    case "Disponible":
                        lblh21.Text = "Disponible";
                        lblh21.BackColor = Color.FromArgb(110, 205, 228);
                        btnh21.Image = disponible;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            //Habitacion 17
            try
            {
                switch (objHab22.Estado.Trim())
                {
                    case "Ocupado":
                        btnh22.Image = ocupado;
                        lblh22.Text = "Ocupado";
                        lblh22.BackColor = Color.FromArgb(230, 115, 130);
                        break;
                    case "Limpieza":
                        lblh22.Text = "Limpieza";
                        lblh22.BackColor = Color.FromArgb(200, 200, 180);
                        btnh22.Image = limpieza;
                        break;
                    case "Disponible":
                        lblh22.Text = "Disponible";
                        lblh22.BackColor = Color.FromArgb(110, 205, 228);
                        btnh22.Image = disponible;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            //Habitacion 23
            try
            {
                switch (objHab23.Estado.Trim())
                {
                    case "Ocupado":
                        btnh23.Image = ocupado;
                        lblh23.Text = "Ocupado";
                        lblh23.BackColor = Color.FromArgb(230, 115, 130);
                        break;
                    case "Limpieza":
                        lblh23.Text = "Limpieza";
                        lblh23.BackColor = Color.FromArgb(200, 200, 180);
                        btnh23.Image = limpieza;
                        break;
                    case "Disponible":
                        lblh23.Text = "Disponible";
                        lblh23.BackColor = Color.FromArgb(110, 205, 228);
                        btnh23.Image = disponible;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            //Habitacion 24
            try
            {
                switch (objHab24.Estado.Trim())
                {
                    case "Ocupado":
                        btnh24.Image = ocupado;
                        lblh24.Text = "Ocupado";
                        lblh24.BackColor = Color.FromArgb(230, 115, 130);
                        break;
                    case "Limpieza":
                        lblh24.Text = "Limpieza";
                        lblh24.BackColor = Color.FromArgb(200, 200, 180);
                        btnh24.Image = limpieza;
                        break;
                    case "Disponible":
                        lblh24.Text = "Disponible";
                        lblh24.BackColor = Color.FromArgb(110, 205, 228);
                        btnh24.Image = disponible;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            //Habitacion 25
            try
            {
                switch (objHab25.Estado.Trim())
                {
                    case "Ocupado":
                        btnh25.Image = ocupado;
                        lblh25.Text = "Ocupado";
                        lblh25.BackColor = Color.FromArgb(230, 115, 130);
                        break;
                    case "Limpieza":
                        lblh25.Text = "Limpieza";
                        lblh25.BackColor = Color.FromArgb(200, 200, 180);
                        btnh25.Image = limpieza;
                        break;
                    case "Disponible":
                        lblh25.Text = "Disponible";
                        lblh25.BackColor = Color.FromArgb(110, 205, 228);
                        btnh25.Image = disponible;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            //Habitacion 26
            try
            {
                switch (objHab26.Estado.Trim())
                {
                    case "Ocupado":
                        btnh26.Image = ocupado;
                        lblh26.Text = "Ocupado";
                        lblh26.BackColor = Color.FromArgb(230, 115, 130);
                        break;
                    case "Limpieza":
                        lblh26.Text = "Limpieza";
                        lblh26.BackColor = Color.FromArgb(200, 200, 180);
                        btnh26.Image = limpieza;
                        break;
                    case "Disponible":
                        lblh26.Text = "Disponible";
                        lblh26.BackColor = Color.FromArgb(110, 205, 228);
                        btnh26.Image = disponible;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            //Habitacion 27
            try
            {
                
                switch (objHab27.Estado.Trim())
                {
                    case "Ocupado":
                        btnh27.Image = ocupado;
                        lblh27.Text = "Ocupado";
                        lblh27.BackColor = Color.FromArgb(230, 115, 130);
                        break;
                    case "Limpieza":
                        lblh27.Text = "Limpieza";
                        lblh27.BackColor = Color.FromArgb(200, 200, 180);
                        btnh27.Image = limpieza;
                        break;
                    case "Disponible":
                        lblh27.Text = "Disponible";
                        lblh27.BackColor = Color.FromArgb(110, 205, 228);
                        btnh27.Image = disponible;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

        }
        /*private void groupBox1_MouseHover(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseHover event occurred.
            lblfecha.Text = sender.GetType().ToString() + ": MouseHover";
        }*/

        private void frmAdministracionHabitaciones_Load(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            label3.Text = (thisDay.ToString("D"));
            actualizarHabitaciones();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.MdiParent = MdiParent;
            frmOpcion.LoadNumeroHabitacion("15");
            frmOpcion.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.MdiParent = MdiParent;
            frmOpcion.LoadNumeroHabitacion("16");
            frmOpcion.Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnh17_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void btnh18_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void btnh26_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void btnh25_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnh24_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void btnh19_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void btnh20_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void btnh21_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void btnh22_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void btnh23_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void btnh27_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void frmAdministracionHabitaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Esta seguro que desea salir", "JUDYSOFT", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (confirmacion == System.Windows.Forms.DialogResult.OK)
            {
                Dispose();
                MenuSettings.EnableMenuItem("habitacionesToolStripMenuItem", "consultarToolStripMenuItem");
            }
        }
   
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            switch (objHab15.Estado)
            {
                case "Disponible":
       
                    /*foreach (Label l in this.Controls.OfType<Label>().Where(l => l.Name.StartsWith("")))
                    {
                        l.Text = "bla bla";
                    }*/
                    
                  
                    lblh15.ForeColor = Color.Blue;
                    break;
                case "Ocupado":
                    
                    break;
                default:
                    break;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnh17_Click_1(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.MdiParent = MdiParent;
            frmOpcion.Show();
            frmOpcion.LoadNumeroHabitacion("17");
        }

        private void btnh18_Click_1(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.MdiParent = MdiParent;
            frmOpcion.Show();
            frmOpcion.LoadNumeroHabitacion("18");
        }

        private void btnh19_Click_1(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.MdiParent = MdiParent;
            frmOpcion.Show();
            frmOpcion.LoadNumeroHabitacion("19");
        }

        private void btnh20_Click_1(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.MdiParent = MdiParent;
            frmOpcion.Show();
            frmOpcion.LoadNumeroHabitacion("20");
        }

        private void btnh21_Click_1(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.MdiParent = MdiParent;
            frmOpcion.Show();
            frmOpcion.LoadNumeroHabitacion("21");
        }

        private void btnh22_Click_1(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.MdiParent = MdiParent;
            frmOpcion.Show();
            frmOpcion.LoadNumeroHabitacion("22");
        }

        private void btnh23_Click_1(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.MdiParent = MdiParent;
            frmOpcion.Show();
            frmOpcion.LoadNumeroHabitacion("23");
        }

        private void btnh24_Click_1(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.MdiParent = MdiParent;
            frmOpcion.Show();
            frmOpcion.LoadNumeroHabitacion("24");
        }

        private void btnh25_Click_1(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.MdiParent = MdiParent;
            frmOpcion.Show();
            frmOpcion.LoadNumeroHabitacion("25");
        }

        private void btnh26_Click_1(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.MdiParent = MdiParent;
            frmOpcion.Show();
            frmOpcion.LoadNumeroHabitacion("26");
        }

        private void btnh27_Click_1(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.MdiParent = MdiParent;
            frmOpcion.Show();
            frmOpcion.LoadNumeroHabitacion("27");
        }

       private void frmAdministracionHabitaciones_MdiChildActivate(object sender, EventArgs e)
        {
            actualizarHabitaciones();
        }

        private void frmAdministracionHabitaciones_MouseHover(object sender, EventArgs e)
        {
            actualizarHabitaciones();
        }

        private void frmAdministracionHabitaciones_Activated(object sender, EventArgs e)
        {
            //actualizarHabitaciones();
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            actualizarHabitaciones();

        }

        private void groupBox3_MouseHover(object sender, EventArgs e)
        {
            actualizarHabitaciones();
        }

        private void groupBox4_MouseHover(object sender, EventArgs e)
        {
            actualizarHabitaciones();

        }

    }

        /*      private void btnh20_Click_1(object sender, EventArgs e)
              {

              }
              */


        /*private void button2_MouseHover(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseHover event occurred.
            lblfecha.Text = "BTN 2";
            btnh16.Image = Image.FromFile("C:\\JUDYSOFT\\JUDYSOFT\\Images\\a.png");
            // The text is displayed vertically above the image of a control.
            btnh16.TextImageRelation = TextImageRelation.TextAboveImage;
  
        }

        private void button2_MouseLeave(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseHover event occurred.
            lblfecha.Text = "BTN 2";
            try
            {
                btnh16.Image = Image.FromFile("C:\\JUDYSOFT\\JUDYSOFT\\Images\\o.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error",MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
           
            // The text is displayed vertically above the image of a control.
            btnh16.TextImageRelation = TextImageRelation.TextAboveImage;

        }*/
}

